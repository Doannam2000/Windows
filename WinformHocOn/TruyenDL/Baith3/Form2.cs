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
    public partial class Form2 : Form
    {
 
        public Form2()
        {
            InitializeComponent();
        }
        public void GetData(string data1)
        {
            label1.Text = data1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.x = txt.Text;
            f.data1 = new Form3.GetData(GetData);
            f.ShowDialog();
        }
    }
}
