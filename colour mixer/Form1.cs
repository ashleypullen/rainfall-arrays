using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colour_mixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            lblColour.BackColor = Color.Transparent;

            if (rdoRed1.Checked)
            {
                if (rdoRed2.Checked)
                {
                    lblColour.BackColor = Color.Red;
                    lblColour.Text = "Red";
                }
                else if (rdoBlue2.Checked)
                {
                    lblColour.BackColor = Color.Purple;
                    lblColour.Text = "Purple";
                }
                else if (rdoGreen2.Checked)
                {
                    lblColour.BackColor = Color.Yellow;
                    lblColour.Text = "Yellow";
                }
            }
            if (rdoGreen1.Checked)
            {
                if (rdoGreen2.Checked)
                {
                    lblColour.BackColor = Color.Green;
                    lblColour.Text = "Green";
                }
                else if (rdoBlue2.Checked)
                {
                    lblColour.BackColor = Color.Cyan;
                    lblColour.Text = "Cyan";
                }
                else if (rdoRed2.Checked)
                {
                    lblColour.BackColor = Color.Yellow;
                    lblColour.Text = "Yellow";
                }
            }
            if (rdoBlue1.Checked)
            {
                if (rdoBlue2.Checked)
                {
                    lblColour.BackColor = Color.Blue;
                    lblColour.Text = "Blue";
                }
                else if (rdoRed2.Checked)
                {
                    lblColour.BackColor = Color.Purple;
                    lblColour.Text = "Purple";
                }
                else if (rdoGreen2.Checked)
                {
                    lblColour.BackColor = Color.Cyan;
                    lblColour.Text = "Cyan";
                }
            }
        }

        private void btnMixFore_Click(object sender, EventArgs e)
        {
            lblColour.ForeColor = Color.Transparent;

            if (rdoRed1.Checked)
            {
                if (rdoRed2.Checked)
                {
                    lblColour.ForeColor = Color.Red;
                    lblColour.Text = "Red";
                }
                else if (rdoBlue2.Checked)
                {
                    lblColour.ForeColor = Color.Purple;
                    lblColour.Text = "Purple";
                }
                else if (rdoGreen2.Checked)
                {
                    lblColour.ForeColor = Color.Yellow;
                    lblColour.Text = "Yellow";
                }
            }
            if (rdoGreen1.Checked)
            {
                if (rdoGreen2.Checked)
                {
                    lblColour.ForeColor = Color.Green;
                    lblColour.Text = "Green";
                }
                else if (rdoBlue2.Checked)
                {
                    lblColour.ForeColor = Color.Cyan;
                    lblColour.Text = "Cyan";
                }
                else if (rdoRed2.Checked)
                {
                    lblColour.ForeColor = Color.Yellow;
                    lblColour.Text = "Yellow";
                }
            }
            if (rdoBlue1.Checked)
            {
                if (rdoBlue2.Checked)
                {
                    lblColour.ForeColor = Color.Blue;
                    lblColour.Text = "Blue";
                }
                else if (rdoRed2.Checked)
                {
                    lblColour.ForeColor = Color.Purple;
                    lblColour.Text = "Purple";
                }
                else if (rdoGreen2.Checked)
                {
                    lblColour.ForeColor = Color.Cyan;
                    lblColour.Text = "Cyan";
                }
            }
        }
    }
}
