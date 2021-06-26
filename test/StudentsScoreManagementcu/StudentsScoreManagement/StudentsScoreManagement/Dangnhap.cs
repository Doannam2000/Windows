using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
namespace StudentsScoreManagement
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        public string  ten{ get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O90RJHC;Initial Catalog=QLDiem;Integrated Security=True");
            try
            {
                conn.Open();
                string ten = txtUserName.Text;
                string passw = txtPassword.Text;
                string sql = "select * from DangNhap where Ten=@ten or UserID=@ten and Password=@passw";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@passw", passw);
                cmd.Connection = conn;
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read())
                {
                    ten = dta["Ten"].ToString();
                    DanhSachDiemSV dssv = new DanhSachDiemSV();
                    dssv.welcome = ten;
                    dssv.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối "+ex.Message);
            }
        }

    }
}
