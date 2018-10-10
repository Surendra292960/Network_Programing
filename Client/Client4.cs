using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;


namespace Client
{
    class Client4
    {
        static void Main(string[] args)
        {

            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Connect("192.168.1.108", 8080);
            //s.Close();
            s.Dispose();
        }
    }

}
