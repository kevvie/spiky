using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Spiky
{
    public partial class Form1 : Form
    {
        private string sendText;
        private string clientName;
        private TcpClient client;

        int line = 0;


        public static string ServerIP = "127.0.0.1";
        public static int ServerPort = 9001;

        TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;

        public Form1()
        {
            InitializeComponent();
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
                SendMessage(client, clientName + ": " + sendText);
            }
        }

        private void serverButton_Click(object sender, EventArgs e)
        {
            clientName = serverNameTextBox.Text;
            if (!String.IsNullOrEmpty(clientName))
            {
                outputTextBox.Clear();
                client = new TcpClient(ServerIP, ServerPort);
                outputTextBox.AppendText("You are now joining the chat" + "\n");
                outputTextBox.AppendText(" " + "\n");
                SendMessage(client, clientName + " has joined the chat");
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
            byte[] bytes = Encoding.Unicode.GetBytes(message);
            client.GetStream().Write(bytes, 0, bytes.Length);
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            SendMessage(client, "qwertyuiop");
            outputTextBox.Clear();
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
                readData = ReadResponse(client);
                msg();
            }
        }

        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
            {
                if ((readData != clientName + ": " + sendText) && (readData != clientName + " has joined the chat") && (!readData.Contains(" @")))
                {
                    outputTextBox.AppendText(readData + "\n");
                    outputTextBox.AppendText("\n");
                }
                if ((readData != clientName + ": " + sendText) && (readData != clientName + " has joined the chat") && (readData.Contains(" @"))){
                    if (readData.Contains(" @" + clientName))
                    {
                        outputTextBox.AppendText(readData + "\n");
                        outputTextBox.AppendText("\n");
                    }
                }
            }
        }

        private void openChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outputTextBox.Lines = File.ReadAllLines(openFileDialog1.FileName);
            }
        }

        private void outputTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

    }
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
