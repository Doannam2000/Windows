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
    public partial class LopHoc : Form
    {
        private DataUtil data = new DataUtil();
        public LopHoc()
        {
            InitializeComponent();
            hienLop();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhapSuaLop nhapSua = new NhapSuaLop();
            nhapSua.ShowDialog();
            hienLop();
        }

        private void LopHoc_Load(object sender, EventArgs e)
        {
            hienLop();
        }
        private void hienLop()
        {
            dataGridViewLop.Columns.Clear();
            dataGridViewLop.DataSource = data.dsLop();
            dataGridViewLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            xoaBtnColumn(btn1);
            suaBtnColumn(btn2);
            dataGridViewLop.Columns.Add(btn1);
            dataGridViewLop.Columns.Add(btn2);
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
        private void dataGridViewLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaLop = dataGridViewLop.Rows[dataGridViewLop.CurrentRow.Index].Cells[0].Value.ToString();
            if (e.ColumnIndex == 7)
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa lớp này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog.Equals(DialogResult.Yes))
                {
                    if (!MaLop.Equals(""))
                    {
                        if (!data.xoaLop(MaLop))
                        {
                            MessageBox.Show("Không thể xóa lớp do hãn còn học sinh trong lớp !!!");
                        }
                        else
                        {
                            hienLop();
                        }
                    }
                    else
                        MessageBox.Show("Lựa chọn một lớp để xóa !!!");
                }
            }
            if (e.ColumnIndex == 8)
            {
                NhapSuaLop nhapSua = new NhapSuaLop();
                nhapSua.maLop = MaLop;
                nhapSua.ShowDialog();
                hienLop();
            }
        }
    }
}
