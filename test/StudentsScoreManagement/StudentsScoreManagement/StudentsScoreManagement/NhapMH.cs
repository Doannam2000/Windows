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
    public partial class NhapMH : Form
    {
        public NhapMH()
        {
            InitializeComponent();
        }
        public string maMH { get; set; }
        public string tenMH { get; set; }
        public string soTC { get; set; }
        public string hocKy { get; set; }
        DataUtil data = new DataUtil();
        private void NhapMH_Load(object sender, EventArgs e)
        {
            this.Text = "Thêm Môn Học";
            if(maMH!=null)
            {
                this.Text = "Sửa Môn Học";
                lblTieuDe.Text = "Sửa Môn Học";
                txtHocKy.Text = hocKy;
                txtMaMH.Text = maMH;
                txtTenMH.Text = tenMH;
                txtTinChi.Text = soTC;
                txtMaMH.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHocKy.Text.Equals("") || txtMaMH.Text.Equals("") || txtTenMH.Text.Equals("") || txtTinChi.Text.Equals(""))
            {
                MessageBox.Show("Yêu cầu nhập đủ dữ liệu !!!");
                return;
            }
            MonHoc m = new MonHoc();
            m.Mamh = txtMaMH.Text;
            m.Tenmh = txtTenMH.Text;
            try
            {
                m.Hocky = int.Parse(txtHocKy.Text);
                m.Sotinchi = int.Parse(txtTinChi.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập dữ liệu không đúng !!!");
                return;
            }
            if (maMH != null)
            {
                data.SuaMH(m);
                this.Close();
            }   
            else
            {
                data.nhapMH(m);
                MessageBox.Show("Nhập dữ liệu thành công !!!");
                txtMaMH.Text = "";
                txtHocKy.Text = "";
                txtTenMH.Text = "";
                txtTinChi.Text = "";
            }    
        }
    }
}
