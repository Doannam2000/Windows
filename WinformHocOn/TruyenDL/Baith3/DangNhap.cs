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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUser.Text.Equals("Administrator") && txtPass.Text.Equals("123456"))
            {
                MessageBox.Show("Đăng nhập thành công", "Chúc mừng");
                Form1 f = new Form1();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        int x;
        private void timer1_Tick(object sender, EventArgs e)
        {
            x = d.Location.X;
            x--;
            d.Location = new Point(x, d.Location.Y);
 
            if (x == -371)
            {
                DangNhap m = new DangNhap();
                x = m.Size.Width;
                d.Location = new Point(x, d.Location.Y);
            }   
        }
    }
}
