using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Cynobroad_TCP_Server
{
    class Program
    {
        private const int port = 42069;

        static void Main(string[] args)
        {
            Console.WriteLine($"Starting TCP Server at port {port}...");
            TCPServer server = new TCPServer(port);
        }
    }
}
