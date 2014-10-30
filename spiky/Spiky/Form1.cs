using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spiky
{
    public partial class Form1 : Form
    {
        private string sendText;
        public Form1()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            sendText = inputTextBox.Text;
            inputTextBox.Clear();
            if (!String.IsNullOrEmpty(sendText))
            {
                outputTextBox.AppendText("Me: " + sendText + "\n");
                outputTextBox.AppendText(" " + "\n");
            }
        }

    }
}
