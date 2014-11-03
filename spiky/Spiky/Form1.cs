﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Spiky
{
    public partial class Form1 : Form
    {
        private string sendText;
        private string clientName;
        private TcpClient client;
        public Form1()
        {
            InitializeComponent();
            //client = new TcpClient("127.0.0.1", 1330);

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
                client = new TcpClient("127.0.0.1", 1330);
                outputTextBox.AppendText("You are now joining the chat" + "\n");
                outputTextBox.AppendText(" " + "\n");
                SendMessage(client, clientName + " has joined the chat");
                clientName += ": ";
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

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.Unicode.GetBytes("qwertyuiop");
            client.GetStream().Write(bytes, 0, bytes.Length);
            outputTextBox.AppendText("you are now disconnected from the server " + "\n");
            sendButton.BackColor = Color.FromArgb(255, Color.Gray);
            inputTextBox.BackColor = Color.FromArgb(255, Color.Gray);
            inputTextBox.ReadOnly = true;
        }        


    }
}
