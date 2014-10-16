using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress localhost; //= IPAddress.Parse("127.0.0.1");

            bool ipIsOk = IPAddress.TryParse("127.0.0.1", out localhost);
            if (!ipIsOk) { Console.WriteLine("ip adres kan niet geparsed worden."); Environment.Exit(1); }

            TcpListener listener = new System.Net.Sockets.TcpListener(localhost, 1330);
            listener.Start();

            while (true)
            {
                Console.WriteLine("Waiting for connection");

                //AcceptTcpClient waits for a connection from the client
                TcpClient client = listener.AcceptTcpClient();

                //start a new thread to handle this connection so we can go back 
                //to waiting for another client
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
                string received = ReadTextMessage(client);
                Console.WriteLine("Received: {0}", received);
                done = received.Equals("bye");
                if (done) WriteTextMessage(client, "BYE");
                else WriteTextMessage(client, "OK");

            }
            client.Close();
            Console.WriteLine("Connection closed");
        }

        public static string ReadTextMessage(TcpClient client)
        {

            StreamReader stream = new StreamReader(client.GetStream(), Encoding.ASCII);
            string line = stream.ReadLine();


            return line;
        }

        public static void WriteTextMessage(TcpClient client, string message)
        {
            var stream = new StreamWriter(client.GetStream(), Encoding.ASCII);
            stream.WriteLine(message);
            stream.Flush();
        }

        public static string ReadMessage(TcpClient client)
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

        public static void SendMessage(TcpClient client, string message)
        {
            //make sure the other end decodes with the same format!
            byte[] bytes = Encoding.Unicode.GetBytes(message);
            client.GetStream().Write(bytes, 0, bytes.Length);
        }
    }
}
