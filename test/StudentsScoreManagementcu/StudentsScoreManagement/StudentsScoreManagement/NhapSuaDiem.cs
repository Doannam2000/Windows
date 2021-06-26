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
    public partial class NhapSuaDiem : Form
    {
        public string masv { get; set; }
        public string mamh { get; set; }
        public string kyhoc { get; set; }
        public string diem { get; set; }

        DataUtil data = new DataUtil();
        public NhapSuaDiem()
        {
            InitializeComponent();
        }

        private void NhapSuaDiem_Load(object sender, EventArgs e)
        {
            if (masv != null)
            {
                lblHeader.Text = "Sửa điểm sinh viên";
                txtMaSV.Text = masv;
                txtMaSV.Enabled = false;
                cbMonHoc.Text = mamh;
                cbMonHoc.Enabled = false;
                cbKyHoc.Text = kyhoc;
                cbKyHoc.Enabled = false;
                txtDiemThi.Text = diem;

            }
            else
            {
                foreach (DataRow dr in data.dsMonHoc().Rows)
                {
                    cbMonHoc.Items.Add(dr["MaMH"].ToString());
                }
                for (int i = 0; i < 8; i++)
                {
                    cbKyHoc.Items.Add((i + 1).ToString());
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int diemThi = int.Parse(txtDiemThi.Text);
                int kyHoc = int.Parse(cbKyHoc.Text);
                if (masv != null) // Sửa điểm
                {
                    if (data.SuaDiem(diemThi, mamh, masv))
                    {
                        MessageBox.Show("Sửa điểm thành công.");
                        txtDiemThi.Clear();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Sửa điểm không thành công\n 0<= Điểm <= 10");
                        return;
                    }
                }
                else // Nhập điểm
                {
                    int checkMaSV = 0, checkMaMH = 0;
                    foreach (DataRow dr in data.dsSV().Rows)
                    {
                        if (dr["MaSV"].ToString().Equals(txtMaSV.Text)) // kiểm tra xem mã sinh viên tồn tại hay chưa
                        {
                            checkMaSV = 1;
                            break;
                        }
                    }

                    foreach (DataRow dr in data.dsMonHoc().Rows)
                    {
                        if (dr["MaMH"].ToString().Equals(cbMonHoc.Text)) // kiểm tra mã môn học tồn tại chưa
                        {
                            checkMaMH = 1;
                            break;
                        }
                    }
                    if (checkMaSV == 0)
                    {
                        MessageBox.Show("Mã sinh viên không hợp lệ.");
                        return;
                    }
                    if (checkMaMH == 0)
                    {
                        MessageBox.Show("Mã môn học không hợp lệ.");
                        return;
                    }

                    if (data.NhapDiem(cbMonHoc.Text, txtMaSV.Text, diemThi, kyHoc))
                    {
                        txtMaSV.Clear();
                        txtDiemThi.Clear();
                        cbMonHoc.Text = "";
                        cbKyHoc.Text = "";
                        MessageBox.Show("Nhập điểm thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Nhập điểm không thành công.");
                    }


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Chú ý dữ liệu nhập vào");
                return;
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
