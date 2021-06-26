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
    public partial class SVLop : Form
    {
        public SVLop()
        {
            InitializeComponent();
        }
        public string maLop { get; set; }
        public string tenLop { get; set; }
        public string user { get; set; }
        DataUtil data = new DataUtil();
        private void SVLop_Load(object sender, EventArgs e)
        {
            loadForm(); // hiển thị dữ liệu lên datagridview
            rdPDF.Checked = true; // khởi tạo mặc định lưu file theo pdf
            lblWel.Text = tenLop;
            
        }
        private void loadForm()
        {
            dataSV.DataSource = null;
            dataSV.DataSource = data.dsSVLop(maLop);
            dataSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //MaSV,HoDem,Ten,NgaySinh,DiaChi,GioiTinh,Email,SoDienThoai
            // sửa headertext cho các cột
            dataSV.Columns[0].HeaderText = "Mã sinh viên";
            dataSV.Columns[1].HeaderText = "Họ đệm";
            dataSV.Columns[2].HeaderText = "Tên";
            dataSV.Columns[3].HeaderText = "Ngày sinh";
            dataSV.Columns[4].HeaderText = "Địa chỉ";
            dataSV.Columns[5].HeaderText = "Giới tính";
            dataSV.Columns[6].HeaderText = "Email";
            dataSV.Columns[7].HeaderText = "Số điện thoại";

            if (user.ToUpper().Equals("ADMIN"))
            {
                btnThem.Visible = true;
                DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
                xoaBtnColumn(btn2);
                suaBtnColumn(btn1);
                dataSV.Columns.Add(btn1);
                dataSV.Columns.Add(btn2);
                
            }
        }
        private void xoaBtnColumn(DataGridViewButtonColumn btn1)
        {
            btn1.HeaderText = @"Xóa";
            btn1.Name = "btnXoa";
            btn1.Text = "Xóa";
            btn1.UseColumnTextForButtonValue = true;
        }

        private void suaBtnColumn(DataGridViewButtonColumn btn2)
        {
            btn2.HeaderText = "Sửa";
            btn2.Name = "btnSua";
            btn2.Text = "Sửa";
            btn2.UseColumnTextForButtonValue = true;
        }

        private void btnSave_Click(object sender, EventArgs e) // button lưu file
        {
            if (rdExcel.Checked)
            {
                new NhapXuat().exportToExcel(data.dsSVLop(maLop));
            }
            else
            {
                new NhapXuat().exportFilePDF(data.dsSVLop(maLop));
            }
        }

        private void dataSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string masv = dataSV.CurrentRow.Cells[dataSV.Columns["MaSV"].Index].Value.ToString();
            if (e.ColumnIndex == dataSV.Columns["btnSua"].Index)
            {
                NhapSuaSV sua = new NhapSuaSV();
                sua.maSV = masv;
                sua.ShowDialog();
                dataSV.Columns.Clear();
                loadForm();
            }
            else if (e.ColumnIndex == dataSV.Columns["btnXoa"].Index)
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa điểm của sinh viên này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog.Equals(DialogResult.Yes))
                {
                    data.XoaSV(masv);
                    dataSV.Columns.Clear();
                    loadForm();
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            NhapSuaSV nhapSv = new NhapSuaSV();
            nhapSv.maLop = maLop; 
            nhapSv.ShowDialog();
            dataSV.Columns.Clear();
            loadForm();
        }
    }
}
