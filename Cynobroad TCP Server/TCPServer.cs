using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cynobroad_TCP_Server
{
    class TCPServer
    {
        private TcpListener _server;
        private Boolean _isRunning;

        private List<string> connectedUsers;
        private ConcurrentQueue<string> messageQueue;

        public ConcurrentQueue<string> MessageQueue
        {
            get { return messageQueue; }
        }

        public TCPServer(int port)
        {
            _server = new TcpListener(IPAddress.Any, port);
            _server.Start();

            messageQueue = new ConcurrentQueue<string>();

            _isRunning = true;

            LoopClients();
        }

        public void LoopClients()
        {
            while (_isRunning)
            {
                // wait for client connection
                TcpClient newClient = _server.AcceptTcpClient();
                Console.WriteLine("Connection accepted from " + newClient.Client.RemoteEndPoint);

                // create a thread to handle communication
                Thread t = new Thread(new ParameterizedThreadStart(HandleSender));
                t.Start(newClient);
            }
        }

        public void HandleSender(object obj)
        {
            // retrieve client from parameter passed to thread
            TcpClient client = (TcpClient)obj;

            // sets two streams for in/out
            StreamWriter sWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.ASCII);

            Thread receiveThread = new Thread(new ParameterizedThreadStart(HandleReceiver));
            receiveThread.Start(sReader);

            while (true)
            {
                if (!MessageQueue.IsEmpty)
                {
                    foreach (string msg in MessageQueue)
                    {
                        sWriter.WriteLine(msg);
                        sWriter.Flush();
                        Thread.Sleep(10);
                        MessageQueue.TryDequeue(out string str);
                    }
                }
            }
        }

        public void HandleReceiver(object obj)
        {
            StreamReader sReader = (StreamReader)obj;

            String sData = null;
            Boolean isConnected = true;

            while (isConnected)
            {
                sData = sReader.ReadLine();
                Console.WriteLine(sData);

                if (sData.StartsWith("join://"))
                {
                    sData = sData.Substring(7);
                    MessageQueue.Enqueue($"{sData} has joined the network.");
                    connectedUsers.Add(sData);
                    MessageQueue.Enqueue($"post://join.{sData}");
                }
                else if (sData.StartsWith("close://"))
                {
                    sData = sData.Substring(7);
                    MessageQueue.Enqueue($"{sData} has left the network.");
                    if (connectedUsers.Contains(sData))
                        connectedUsers.Remove(sData);
                    MessageQueue.Enqueue($"post://close.{sData}");
                    break;
                }
                else if (sData.StartsWith("send://"))
                {
                    sData = sData.Substring(7);
                    MessageQueue.Enqueue(sData);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
