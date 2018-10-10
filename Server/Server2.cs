using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Server2
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Hello form Server");
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind( new IPEndPoint(IPAddress.Parse("192.168.1.108"), 63557));

            //sck.Bind(new IPEndPoint(0, 63557));  it's not working
            sck.Listen(0); //calling Listen method
            
            Socket acc = sck.Accept();

            byte[] buffer = Encoding.Default.GetBytes("Hello Client");
            acc.Send(buffer, 0, buffer.Length, 0);

            Console.WriteLine(buffer);

            byte[] recBuffer = new byte[255];

            int rec = acc.Receive(buffer, 0, buffer.Length, 0);

            Array.Resize(ref buffer, rec);

            Console.WriteLine("Recieved:{0}", Encoding.Default.GetString(buffer));

            sck.Close();
            acc.Close();
            Console.Read();
        }
    }
}
