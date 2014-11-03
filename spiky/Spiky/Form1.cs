using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Spiky
{
    public partial class Form1 : Form
    {
        private string sendText;
        private string clientName;
        private TcpClient client;

        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;


        public Form1()
        {
            InitializeComponent();
            //client = new TcpClient("127.0.0.1", 1330);
            sendButton.BackColor = Color.FromArgb(255, Color.Gray);
            inputTextBox.BackColor = Color.FromArgb(255, Color.Gray);
            inputTextBox.ReadOnly = true;
            outputTextBox.AppendText("Choose your chat name");

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            sendText = inputTextBox.Text;
            inputTextBox.Clear();
            if (!String.IsNullOrEmpty(sendText))
            {
                outputTextBox.AppendText("Me: " + sendText + "\n");
                outputTextBox.AppendText(" " + "\n");
                SendMessage(client, clientName + sendText);
            }
        }

        private void serverButton_Click(object sender, EventArgs e)
        {
            clientName = serverNameTextBox.Text;
            if (!String.IsNullOrEmpty(clientName))
            {
                outputTextBox.Clear();
                client = new TcpClient("127.0.0.1", 1330);
                outputTextBox.AppendText("You are now joining the chat" + "\n");
                outputTextBox.AppendText(" " + "\n");
                SendMessage(client, clientName + " has joined the chat");
                clientName += ": ";
                sendButton.BackColor = Control.DefaultBackColor;
                inputTextBox.BackColor = Control.DefaultBackColor;
                inputTextBox.ReadOnly = false;

                Thread ctThread = new Thread(getMessage);
                ctThread.Start();

            }
            else
            {
                MessageBox.Show("No chat name chosen!");
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static void SendMessage(TcpClient client, string message)
        {
            //make sure the other end encodes with the same format!
            byte[] bytes = Encoding.Unicode.GetBytes(message);
            client.GetStream().Write(bytes, 0, bytes.Length);
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.Unicode.GetBytes("qwertyuiop");
            client.GetStream().Write(bytes, 0, bytes.Length);
            outputTextBox.AppendText("you are now disconnected from the server " + "\n");
            sendButton.BackColor = Color.FromArgb(255, Color.Gray);
            inputTextBox.BackColor = Color.FromArgb(255, Color.Gray);
            inputTextBox.ReadOnly = true;
        }

        private void saveChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName, outputTextBox.Lines);
            }
        }

        private static string ReadResponse(TcpClient client)
        {
            byte[] buffer = new byte[256];
            int totalRead = 0;
            //read bytes until there are none left
            do
            {
                int read = client.GetStream().Read(buffer, totalRead,
                    buffer.Length - totalRead);
                totalRead += read;
            } while (client.GetStream().DataAvailable);
            return Encoding.Unicode.GetString(buffer, 0, totalRead);
        }

        private void getMessage()
        {
            while (true)
            {
                // to do

                //msg();
            }
        }

        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                outputTextBox.AppendText(readData + "\n");
        } 


    }
}
