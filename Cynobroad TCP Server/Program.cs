using System;

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
