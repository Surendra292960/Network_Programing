﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class ServerProgram
    {
        static Socket sck;
        static Socket acc;
        static int port = 9000;
        static IPAddress ip;
        static Thread rec;
        static string name;

        static string GetIP()
        {
            string strHostName = System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            return addr[addr.Length - 2].ToString();
        }
        static void recV()
        {
            while (true)
            {
                Thread.Sleep(500);
                byte[] Buffer = new byte[255];
                int rec = acc.Receive(Buffer, 0, Buffer.Length, 0);
                Array.Resize(ref Buffer, rec);
                Console.WriteLine(Encoding.Default.GetString(Buffer));
            }
        }
        static void Main(string[] args)
        {
            rec = new Thread(recV);
            Console.WriteLine("Your Local Ip is : " + GetIP());
            Console.WriteLine("Please Enter Your name");
            name = Console.ReadLine();
            Console.WriteLine("Please Enter Your Host Port");
            string inputPort = Console.ReadLine();
            try {port = Convert.ToInt32(inputPort);}
            catch { port = 9000; }
            ip = IPAddress.Parse(GetIP());
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind(new IPEndPoint(ip, port));
            sck.Listen(0);
            acc = sck.Accept();
            rec.Start();
            while (true)
            {
                byte[] sdata = Encoding.ASCII.GetBytes("<" + name + ">" + Console.ReadLine());
                acc.Send(sdata, 0, sdata.Length, 0);
            }
        }
    }
}