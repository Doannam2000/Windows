using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_winform1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void radred_CheckedChanged(object sender, EventArgs e)
        {
            lblhienthi.ForeColor = Color.Red;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblhienthi.ForeColor = Color.Black;
        }

        private void radY_CheckedChanged(object sender, EventArgs e)
        {
            lblhienthi.ForeColor = Color.Yellow;
        }

        private void radG_CheckedChanged(object sender, EventArgs e)
        {
            lblhienthi.ForeColor = Color.Green;
        }

        private void checkhienthi_CheckedChanged(object sender, EventArgs e)
        {
            lblhienthi.Visible = checkhienthi.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblhienthi.Text = txtTen.Text + " " + txtTB.Text;
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            picBig.Visible = false;
            picSmall.Visible = true;
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            picBig.Visible = true;
            picSmall.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTB.Clear();
            txtTen.Clear();
            lblhienthi.Text = String.Empty;
        }
    }
}
