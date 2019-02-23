using Newtonsoft.Json;
using System.Collections.Concurrent;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Cynobroad
{
    class TCPClient
    {
        private TcpClient _client;
        private bool isConnected;

        private StreamWriter _sWriter;
        private StreamReader _sReader;

        private ConcurrentQueue<string> MessageQueue = new ConcurrentQueue<string>();

        public string ServerIP;
        public TCPClient(string serverIP, int port)
        {
            _client = new TcpClient();
            isConnected = true;
            ServerIP = serverIP;

            try   { InitializeConnection(serverIP, port); }
            catch { isConnected = false; }
        }

        public void AddMessageToQueue(string message)
        {
            MessageQueue.Enqueue(message);
        }

        private void InitializeConnection(string serverIP, int port)
        {
            _client.Connect(serverIP, port);
            _sWriter = new StreamWriter(_client.GetStream(), Encoding.ASCII);
            _sReader = new StreamReader(_client.GetStream(), Encoding.ASCII);
            
            ThreadStart startReceiver = new ThreadStart(HandleReceiver);
            Thread receivingThread = new Thread(startReceiver)
            { IsBackground = true };
            receivingThread.Start();
            
            ThreadStart startSender = new ThreadStart(HandleSender);
            Thread sendingThread = new Thread(startSender)
            { IsBackground = true };
            sendingThread.Start();
        }

        private void HandleReceiver()
        {
            PacketStruct packet = new PacketStruct();
            while (isConnected)
            {
                //Deserialize packet from StreamReader
                try { packet = JsonConvert.DeserializeObject<PacketStruct>(_sReader.ReadLine()); }
                catch { packet = new PacketStruct(); }

                //TODO: Forward this packet to Cynobroad.cs for processing
            }
        }

        private void HandleSender()
        {
            PacketStruct packetStruct = new PacketStruct
            {
                Type = "join"
            };
            _sWriter.WriteLine(JsonConvert.SerializeObject(packetStruct));
            _sWriter.Flush();

            while (isConnected)
            {
                if (!MessageQueue.IsEmpty)
                {
                    foreach (string msg in MessageQueue)
                    {
                        MessageQueue.TryDequeue(out string str);
                        _sWriter.WriteLine(msg);
                        _sWriter.Flush();
                    }
                }
                Thread.Sleep(10);
            }
        }
    }
}
