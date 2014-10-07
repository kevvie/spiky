using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace spiky
{
    public partial class spikyStartUp : Form
    {
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);

        public spikyStartUp()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            new GameWindow().ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void colorButton_Click(object sender, EventArgs e)
        {
                new ColorWindow().ShowDialog();
        }

        private void spikyStartUp_Load(object sender, EventArgs e)
        {
        }
    }
}
