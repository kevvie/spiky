using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Server
{
    class Program
    {

        private static List<TcpClient> clients = new List<TcpClient>();
        static void Main(string[] args)
        {
            var serverip = Dns.GetHostEntry(Dns.GetHostName()).AddressList.First(o => o.AddressFamily == AddressFamily.InterNetwork).ToString();
            Console.WriteLine("server adress is: " + ServerIP);            

            bool ipIsOk = IPAddress.TryParse("127.0.0.1", out localhost);
            if (!ipIsOk) { Console.WriteLine("ip adres kan niet geparsed worden."); Environment.Exit(1); }

            TcpListener listener = new System.Net.Sockets.TcpListener(localhost, 1330);
            listener.Start();
            
            while (true)
            {
                Console.WriteLine("Waiting for connection");

                TcpClient client = listener.AcceptTcpClient();

                clients.Add(client);
                Thread thread = new Thread(HandleClientThread);
                thread.Start(client);
            }
        }

        static void HandleClientThread(object obj)
        {
            TcpClient client = obj as TcpClient;

            bool done = false;
            while (!done)
            {
                string received = ReadMessage(client);
                Console.WriteLine("Received: {0}", received);
                done = received.Equals("qwertyuiop");
                if (done) SendResponse(client, "BYE");
                else
                {
                    foreach (TcpClient name in clients)
                    {
                        SendResponse(name, received);
                    }
                }
                
            }
            clients.Remove(client);
            client.Close();
            Console.WriteLine("Connection closed");
        }

        private static string ReadMessage(TcpClient client)
        {
            byte[] buffer = new byte[256];
            int totalRead = 0;
            //read bytes until stream indicates there are no more
            do
            {
                int read = client.GetStream().Read(buffer, totalRead, buffer.Length - totalRead);
                totalRead += read;
                Console.WriteLine("ReadMessage: " + read);
            } while (client.GetStream().DataAvailable);

            return Encoding.Unicode.GetString(buffer, 0, totalRead);

        }       

        private static void SendResponse(TcpClient client, string message)
        {
            //make sure the other end decodes with the same format!
            byte[] bytes = Encoding.Unicode.GetBytes(message);
            client.GetStream().Write(bytes, 0, bytes.Length);
        }
    }
}
