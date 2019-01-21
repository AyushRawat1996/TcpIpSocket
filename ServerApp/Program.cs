using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;

namespace ServerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress iPAddress = Dns.GetHostEntry("localhost").AddressList[0];
            TcpListener listener = new TcpListener(iPAddress, 9999);
            TcpClient client = default(TcpClient);
            try
            {
                listener.Start();
                Console.WriteLine("Server Started...");

            }
            catch (Exception exp) {
                Console.WriteLine(exp.ToString());
            }

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                // do nothing until escape
                while (true)
                {
                    client = listener.AcceptTcpClient();
                    byte[] recievedBytes = new byte[100];
                    NetworkStream stream = client.GetStream();
                    stream.Read(recievedBytes, 0, recievedBytes.Length);
                    string msg = Encoding.ASCII.GetString(recievedBytes, 0, recievedBytes.Length);
                    Console.WriteLine(msg + msg.Length);
                }
            }
            Environment.Exit(0);

        }
    }
}
