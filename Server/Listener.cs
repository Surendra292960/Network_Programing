using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Server
{
    class Listener
    {
    //    Socket s;

    //    public bool Listening {get; set;}
    //    public int Port { get; set; }

    //    public Listener(int port)
    //    {
    //        Port = port;
    //        s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

    //    }
    //    public void Start()
    //    {
    //        if (Listening)
    //            return;

    //        s.Bind(new IPEndPoint(0, Port));
    //        s.Listen(0);
    //        s.BeginAccept(callback, null);
    //        Listening = true;

    //    }

    //    public void Stop()
    //    {

    //        if (!Listening)
    //            return;

    //        s.Close();
    //        s.Dispose();
    //        s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

    //    }
    //    void callback(IAsyncResult ar)
    //    {
    //        try
    //        {
    //            Socket s = this.s.EndAccept(ar);
    //        }
    //        catch(Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //    }

    //    public delegate void SocketAcceptedHandler(Socket e);
    //    public event SocketAcceptedHandler SocketAccepted;
    }
}
