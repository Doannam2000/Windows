using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapForm
{
    public partial class Del : Form
    {
        public Del()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin");
            }    
            else
            {
                if(new DataUlit().del(textBox1.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    Close();
                }    
                else
                {
                    MessageBox.Show("Xóa không thành công");
                    
                }    
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
