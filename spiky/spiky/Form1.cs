using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spiky
{
    public partial class spikyStartUp : Form
    {
        public spikyStartUp()
        {
            InitializeComponent();
        }

        private void multiPlayerButton_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }
        
        private void muteButton_Click_1(object sender, EventArgs e)
        {
            new MuteSound();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
