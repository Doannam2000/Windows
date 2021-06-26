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
    public partial class Diem : Form
    {
        private DataUtil data = new DataUtil();
        public Diem()
        {
            InitializeComponent();
            hienThiDiemSV();
        }
        private void Diem_Load(object sender, EventArgs e)
        {
            hienThiDiemSV();
        }
        private void hienThiDiemSV()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data.dsDiemSV();
            addButtonData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void addButtonData()
        {
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn3 = new DataGridViewButtonColumn();
            xoaBtnColumn(btn1);
            suaBtnColumn(btn2);
            xemChiTiet(btn3);
            dataGridView1.Columns.Add(btn1);
            dataGridView1.Columns.Add(btn2);
            dataGridView1.Columns.Add(btn3);
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

        private void xemChiTiet(DataGridViewButtonColumn btn3)
        {
            btn3.HeaderText = "Xem chi tiết";
            btn3.Name = "btnXem";
            btn3.Text = "Xem thông tin";
            btn3.UseColumnTextForButtonValue = true;
        }
        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string masv = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string mamh = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (e.ColumnIndex == 6 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    try
                    {
                        XemChiTiet xem = new XemChiTiet(data.thongTinChiTiet(masv));
                        xem.ShowDialog();
                    }
                    catch (Exception)
                    {

                    }
                }
                if (e.ColumnIndex == 5)
                {
                    string kyhoc = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string diem = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    NhapSuaDiem sua = new NhapSuaDiem();
                    sua.masv = masv;
                    sua.mamh = mamh;
                    sua.kyhoc = kyhoc;
                    sua.diem = diem;
                    sua.ShowDialog();
                    hienThiDiemSV();
                }
                if (e.ColumnIndex == 4)
                {
                    DialogResult dialog = MessageBox.Show("Bạn có muốn xóa điểm của sinh viên này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog.Equals(DialogResult.Yes))
                    {
                        data.DeleteDiem(mamh, masv);
                        hienThiDiemSV();
                    }
                }
            }
            catch (Exception)
            {
               
            }
        }
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridViewCell c = ((DataGridView)sender)[e.ColumnIndex, e.RowIndex];
                if (e.RowIndex < dataGridView1.RowCount && e.ColumnIndex < dataGridView1.ColumnCount)
                {
                    if (!c.Selected)
                    {
                        c.DataGridView.ClearSelection();
                        c.DataGridView.CurrentCell = c;
                        c.Selected = true;
                    }
                }

            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            NhapSuaDiem nhap = new NhapSuaDiem();
            nhap.ShowDialog();
            dataGridView1.Columns.Clear();
            hienThiDiemSV();
        }

   

        private void dataGridView1_CellMouseDown_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridViewCell c = ((DataGridView)sender)[e.ColumnIndex, e.RowIndex];
                if (e.RowIndex < dataGridView1.RowCount && e.ColumnIndex < dataGridView1.ColumnCount)
                {
                    if (!c.Selected)
                    {
                        c.DataGridView.ClearSelection();
                        c.DataGridView.CurrentCell = c;
                        c.Selected = true;
                    }
                }

            }
        }


    }
}
