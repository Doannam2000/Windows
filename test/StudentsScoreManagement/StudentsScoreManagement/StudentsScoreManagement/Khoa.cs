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
    public partial class Khoa : Form
    {
        private DataUtil data = new DataUtil();
        public Khoa()
        {
            InitializeComponent();
            hienKhoa();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            hienKhoa();
        }
        private void hienKhoa()
        {
            dataGridViewKhoa.Columns.Clear();
            dataGridViewKhoa.DataSource = data.dsKhoa();
            dataGridViewKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            xoaBtnColumn(btn1);
            suaBtnColumn(btn2);
            dataGridViewKhoa.Columns.Add(btn1);
            dataGridViewKhoa.Columns.Add(btn2);
        }
        private void suaBtnColumn(DataGridViewButtonColumn btn2)
        {
            btn2.HeaderText = "Sửa";
            btn2.Name = "btnSua";
            btn2.Text = "Sửa";
            btn2.UseColumnTextForButtonValue = true;
        }
        private void xoaBtnColumn(DataGridViewButtonColumn btn1)
        {
            btn1.HeaderText = @"Xóa";
            btn1.Name = "btnXoa";
            btn1.Text = "Xóa";
            btn1.UseColumnTextForButtonValue = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            NhapSuaKhoa nhapSuaKhoa = new NhapSuaKhoa();
            nhapSuaKhoa.ShowDialog();
            hienKhoa();
        }
        private void dataGridViewKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaKhoa = dataGridViewKhoa.Rows[dataGridViewKhoa.CurrentRow.Index].Cells[0].Value.ToString();
            if (e.ColumnIndex == 3)
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa lớp này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog.Equals(DialogResult.Yes))
                {
                    if (!MaKhoa.Equals(""))
                    {
                        if (!data.xoaKhoa(MaKhoa))
                        {
                            MessageBox.Show("Không thể xóa khoa này do hãn còn lớp tồn tại !!!");
                        }
                        else
                        {
                            hienKhoa();
                        }
                    }
                    else
                        MessageBox.Show("Lựa chọn một lớp để xóa !!!");
                }
            }
            if (e.ColumnIndex == 4)
            {
                NhapSuaKhoa nhap = new NhapSuaKhoa();
                nhap.maKhoa = MaKhoa;
                nhap.tenKhoa = dataGridViewKhoa.Rows[dataGridViewKhoa.CurrentRow.Index].Cells[3].Value.ToString();
                nhap.dienThoai = dataGridViewKhoa.Rows[dataGridViewKhoa.CurrentRow.Index].Cells[4].Value.ToString();
                nhap.ShowDialog();
                hienKhoa();
            }

        }
    }
}
