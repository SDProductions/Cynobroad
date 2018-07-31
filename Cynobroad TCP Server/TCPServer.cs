using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Cynobroad_TCP_Server
{
    class TCPServer
    {
        private TcpListener _server;
        private Boolean _isRunning;

        private List<string> connectedUsers = new List<string>();
        public List<string> ConnectedUsers
        {
            get { return connectedUsers; }
        }

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

            Thread receiveThread = new Thread(new ParameterizedThreadStart(HandleReceiver));
            receiveThread.Start(client);

            while (client.Connected)
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
                Thread.Sleep(10);
            }
        }

        public void HandleReceiver(object _client)
        {
            TcpClient client = (TcpClient)_client;
            
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.ASCII);

            String sData = null;
            Boolean isConnected = true;

            while (isConnected)
            {
                sData = sReader.ReadLine();
                Console.WriteLine(sData);

                if (sData.StartsWith("join://"))
                {
                    sData = sData.Substring(7);
                    MessageQueue.Enqueue($"SERVER>{sData} has joined the network.");

                    ConnectedUsers.Add(sData);
                    ConnectedUsers.Sort();

                    MessageQueue.Enqueue("post://rcu");
                    foreach (string user in ConnectedUsers)
                    {
                        MessageQueue.Enqueue($"post://acu.{user}");
                    }
                }
                else if (sData.StartsWith("close://"))
                {
                    sData = sData.Substring(8);
                    MessageQueue.Enqueue($"SERVER>{sData} has left the network.");

                    if (ConnectedUsers.Contains(sData))
                        ConnectedUsers.Remove(sData);
                    ConnectedUsers.Sort();

                    MessageQueue.Enqueue("post://rcu");
                    foreach (string user in ConnectedUsers)
                    {
                        MessageQueue.Enqueue($"post://acu.{user}");
                    }

                    client.Dispose();
                    break;
                }
                else if (sData.StartsWith("send://"))
                {
                    sData = sData.Substring(7);
                    MessageQueue.Enqueue(sData);
                }
                else
                {
                    Console.WriteLine($"Connection from {client.Client.RemoteEndPoint} disposed due to not being a valid client.");
                    client.Dispose();
                    break;
                }
            }
        }
    }
}
