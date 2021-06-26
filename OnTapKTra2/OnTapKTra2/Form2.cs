using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapKTra2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataUtils dat = new DataUtils();
        private void button1_Click(object sender, EventArgs e)
        {
            List<Student> list = new List<Student>();
            list = dat.readFile();
            if(txtDiaChi.Text.Equals("")|| txtMaSV.Text.Equals("")|| txtQue.Text.Equals("")|| txtTenSV.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu ");
            }
            else
            {
                Student x = new Student();
                x.diaChi = txtDiaChi.Text;
                try
                {
                    x.maSV = int.Parse(txtMaSV.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhập sai dữ liệu ");
                    return;
                }
                x.queQuan = txtQue.Text;
                x.tenSV = txtTenSV.Text;
                list.Add(x);
                dat.writeFile(list);
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
