using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsScoreManagement
{
    public partial class NhapSuaLop : Form
    {
        public NhapSuaLop()
        {
            InitializeComponent();
        }
        DataUtil data = new DataUtil();
        public string maLop { get; set; }
        private void NhapSuaLop_Load(object sender, EventArgs e)
        {
            this.Text = "Nhập Thông Tin Lớp";
            btnOK.Text = "Thêm";
            if(maLop!=null)
            {
                this.Text = "Sửa Thông Tin Lớp";
                btnOK.Text = "Sửa";
                DataRow x = data.timkiemLop(maLop, "", "", "", "", "").Rows[0];
                txtNam.Text = x["NamNhapHoc"].ToString();
                txtHeDT.Text = x["HeDaoTao"].ToString();
                txtKhoa.Text = x["Khoa"].ToString();
                txtMaKhoa.Text = x["MaKhoa"].ToString();
                txtMaLop.Text = x["MaLop"].ToString();
                txtMaLop.Enabled = false;
                txtSiSo.Text = x["SiSo"].ToString();
                txtTenLop.Text = x["TenLop"].ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtTenLop.Text.Equals("")|| txtNam.Text.Equals("")|| txtHeDT.Text.Equals("")|| txtKhoa.Text.Equals("")|| txtMaKhoa.Text.Equals("")|| txtMaLop.Text.Equals("")|| txtSiSo.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu !!!");
                return;
            }

            Lop lop = new Lop();
            lop.maLop = txtMaLop.Text;
            lop.maKhoa = txtMaKhoa.Text;
            lop.khoa = txtKhoa.Text;
            lop.heDaoTao = txtHeDT.Text;
            lop.nam = int.Parse(txtNam.Text);
            lop.siso = int.Parse(txtSiSo.Text);
            lop.tenLop = txtTenLop.Text;
            if (maLop != null)
            {
                if (!data.SuaLop(lop))
                {
                    MessageBox.Show("Không thể sửa!!!\nLưu ý nhập đúng mã");
                }
                else
                {
                    MessageBox.Show("Sửa thành công !!!");
                    Close();
                }
            }
            else
            {
                if (!data.NhapLop(lop))
                {
                    MessageBox.Show("Không thể sửa!!!\nLưu ý nhập đúng mã");
                }
                else
                {
                    MessageBox.Show("Nhập dữ liệu thành công");
                    txtNam.Text = "";
                    txtHeDT.Text = "";
                    txtKhoa.Text = "";
                    txtMaKhoa.Text ="";
                    txtMaLop.Text ="";
                    txtSiSo.Text = "";
                    txtTenLop.Text = "";
                }    
            }

        }
     }
}
