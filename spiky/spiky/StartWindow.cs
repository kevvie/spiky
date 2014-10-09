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
        public spikyStartUp()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            new GameWindow().Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void colorButton_Click(object sender, EventArgs e)
        {   
            new ColorWindow().Show();
            this.Hide(); 
        }

        private void spikyStartUp_Load(object sender, EventArgs e)
        {
        }
    }
}
