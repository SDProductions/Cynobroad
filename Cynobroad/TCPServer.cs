using Newtonsoft.Json;
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

namespace Cynobroad
{
    class TCPServer
    {
        private TcpListener _server;
        private readonly bool _isRunning;

        private List<string> ConnectedUsers = new List<string>();

        private ConcurrentQueue<string> MessageQueue;

        public TCPServer(int port)
        {
            _server = new TcpListener(IPAddress.Any, port);
            _server.Start();

            MessageQueue = new ConcurrentQueue<string>();

            _isRunning = true;

            LoopClients();
        }

        public void LoopClients()
        {
            while (_isRunning)
            {
                // wait for client connection
                TcpClient newClient = _server.AcceptTcpClient();

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
            
            PacketStruct packet = new PacketStruct();
            bool isConnected = true;
            while (isConnected)
            {
                try
                {
                    packet = JsonConvert.DeserializeObject<PacketStruct>(sReader.ReadLine());
                }
                catch { }

                if (packet.Type == "join")
                {
                    MessageQueue.Enqueue($"SERVER>{packet.User} has joined the network.");

                    ConnectedUsers.Add(packet.User);
                    ConnectedUsers.Sort();

                    MessageQueue.Enqueue("rcu");
                    foreach (string user in ConnectedUsers)
                    {
                        MessageQueue.Enqueue($"acu.{user}");
                    }
                }
                else if (packet.Type == "close")
                {
                    MessageQueue.Enqueue($"SERVER>{packet.User} has left the network.");

                    if (ConnectedUsers.Contains(packet.User))
                        ConnectedUsers.Remove(packet.User);
                    ConnectedUsers.Sort();

                    MessageQueue.Enqueue("rcu");
                    foreach (string user in ConnectedUsers)
                    {
                        MessageQueue.Enqueue($"acu.{packet.User}");
                    }

                    client.Dispose();
                    break;
                }
                else if (packet.Type == "statchange")
                {
                    MessageQueue.Enqueue($"statchange.{packet.User}.{packet.Message}");
                }
                else if (packet.Type == "send")
                {
                    MessageQueue.Enqueue($"{packet.User}>{packet.Message}");
                }
                else
                {
                    client.Dispose();
                    break;
                }
            }
        }
    }
}
