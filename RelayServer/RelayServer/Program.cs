using System;
using Riptide;
using System.Threading;

namespace RelayServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Relay Server";
            Server _Server = new Server();
            _Server.Start(7777, 10);
            Thread.Sleep(50000);
            _Server.Stop();
            Console.ReadKey();
        }
    }
}
