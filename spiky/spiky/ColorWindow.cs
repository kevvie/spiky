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
    public partial class ColorWindow : Form
    {
        public ColorWindow()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            new spikyStartUp().Show();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            new spikyStartUp().Show();
            this.Close();
        }

        private void blackButton_Click(object sender, EventArgs e)
        {

        }

        private void whiteButton_Click(object sender, EventArgs e)
        {

        }

        private void redButton_Click(object sender, EventArgs e)
        {
                                                
        }

        private void blueButton_Click(object sender, EventArgs e)
        {

        }

        private void yellowButton_Click(object sender, EventArgs e)
        {

        }

        private void greenButton_Click(object sender, EventArgs e)
        {

        }

        private void orangeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
