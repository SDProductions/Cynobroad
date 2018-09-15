using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Cynobroad_Console
{
    class TCPClient
    {
        private const int port = 42069;
        private readonly string serverIP;

        private readonly string username;

        private Thread receivingThread;
        private Thread sendingThread;
        private TcpClient _client;
        string sData = null;

        public TCPClient()
        {
            Console.WriteLine("Username:");
            username = Console.ReadLine();
            Console.WriteLine("Server IPv4 Address:");
            serverIP = Console.ReadLine();

            _client = new TcpClient();

            try
            {
                Console.WriteLine("Attempting to connect...");
                _client.Connect(IPAddress.Parse(serverIP), port);
            }
            catch
            {
                Console.WriteLine($"Failed to connect to {serverIP}.");
                Console.WriteLine("Press any key to exit the client.");
                Console.Read();
            }

            Console.WriteLine("Successfully connected! Entering chat network...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("----Chat----");

            receivingThread = new Thread(new ParameterizedThreadStart(ClientReceiver));
            receivingThread.Start(_client);
        }

        private void ClientReceiver(object obj)
        {
            TcpClient client = (TcpClient)obj;

            StreamWriter _sWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.ASCII);

            _sWriter.WriteLine($"join://{username}");
            _sWriter.Flush();

            sendingThread = new Thread(new ParameterizedThreadStart(ClientSender));
            sendingThread.Start(_sWriter);

            while (true)
            {
                sData = sReader.ReadLine();

                if (sData != null && !sData.StartsWith("post://"))
                {
                    string[] data = sData.Split('>');
                    string username = data[0];
                    sData = sData.Remove(0, username.Length + 1);
                    
                    if (username == this.username)
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.WriteLine(username + ": " + sData);
                }
            }
        }

        private void ClientSender(object obj)
        {
            StreamWriter sWriter = (StreamWriter)obj;
            
            while (true)
            {
                sData = Console.ReadLine();
                if (sData.StartsWith("close://"))
                {
                    sWriter.WriteLine($"close://{username}");
                    sWriter.Flush();
                    Thread.Sleep(10);
                    _client.Dispose();
                    Console.WriteLine(">>: You have been disconnected from the network.");
                }
                else
                {
                    sWriter.WriteLine($"send://{username}>{sData}");
                    sWriter.Flush();
                }
            }
        }
    }
}
