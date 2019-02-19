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
            // retrieve client and create writer
            TcpClient client = (TcpClient)obj;
            StreamWriter sWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);

            // pass client onto reciever
            Thread receiveThread = new Thread(new ParameterizedThreadStart(HandleReceiver));
            receiveThread.Start(client);

            // while connected, if messages to send, send them
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

        private void CreateAndSendPacket(string type, string username, string message = null)
        {
            PacketStruct packetStruct = new PacketStruct
            {
                Type = type,
                User = username,
                Message = message
            };

            MessageQueue.Enqueue(JsonConvert.SerializeObject(packetStruct));
        }

        public void HandleReceiver(object _client)
        {
            // retrieve client and create reader
            TcpClient client = (TcpClient)_client;
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.ASCII);
            
            PacketStruct packet = new PacketStruct();
            while (client.Connected)
            {
                //Deserialize packet from StreamReader
                try   { packet = JsonConvert.DeserializeObject<PacketStruct>(sReader.ReadLine()); }
                catch { packet = new PacketStruct(); }

                //Check packet type and act accordingly
                switch (packet.Type)
                {
                    case "join":
                        CreateAndSendPacket("send", "Server", $"{packet.User} has joined the network!");

                        CreateAndSendPacket("ucu", packet.User, JsonConvert.SerializeObject(ConnectedUsers));

                        ConnectedUsers.Add(packet.User);
                        ConnectedUsers.Sort();

                        CreateAndSendPacket("acu", packet.User);

                        break;
                    case "close":
                        CreateAndSendPacket("send", "Server", $"{packet.User} has left the network!");

                        ConnectedUsers.Remove(packet.User);
                        ConnectedUsers.Sort();
                        CreateAndSendPacket("rcu", packet.User);

                        client.Dispose();
                        break;
                    case "statchange":
                        CreateAndSendPacket("statchange", packet.User, packet.Message);
                        break;
                    case "send":
                        CreateAndSendPacket("send", packet.User, packet.Message);
                        break;
                    default:
                        client.Dispose();
                        break;
                }
            }
        }
    }
}
