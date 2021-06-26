using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baith3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string x;
        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Xin chào " + x;
        }
        public delegate void GetData(string data1);
        public GetData data1;

        private void button1_Click(object sender, EventArgs e)
        {
            data1(textBox1.Text);
            Close();
        }
    }
}
