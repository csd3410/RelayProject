using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiptideNetworking;

namespace RelayServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Relay Server";
            Server _Server = new Server();
            _Server.Start(7777, 10);
            Console.ReadKey();
            _Server.Stop();
        }
    }
}
