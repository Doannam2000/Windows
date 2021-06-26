using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            string filePath = @"file.txt";

            ​if (File.Exists(filePath))
            {
                txthienthi.Text = File.ReadAllText(filePath);
            }
            else
            {
                File.Create(filePath);
            }    
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            File.WriteAllText("file.txt", txthienthi.Text);
        }
    }
}
