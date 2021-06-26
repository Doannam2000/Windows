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
    public partial class Mon : Form
    {
      
        private DataUtil data = new DataUtil();
        public Mon()
        {
            InitializeComponent();
            hienMH();
        }

        private void Mon_Load(object sender, EventArgs e)
        {
            hienMH();
        }
        private void btnNhapMH_Click(object sender, EventArgs e)
        {
            NhapMH mh = new NhapMH();
            mh.ShowDialog();
            dataGridViewMH.Columns.Clear();
            hienMH();
        }
        private void hienMH()
        {
            dataGridViewMH.Columns.Clear();
            dataGridViewMH.DataSource = data.dsMonHoc();
            dataGridViewMH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn1.HeaderText = @"Xóa";
            btn1.Name = "btnXoa";
            btn1.Text = "Xóa";
            btn1.UseColumnTextForButtonValue = true;
            btn2.HeaderText = "Sửa";
            btn2.Name = "btnSua";
            btn2.Text = "Sửa";
            btn2.UseColumnTextForButtonValue = true;
            dataGridViewMH.Columns.Add(btn1);
            dataGridViewMH.Columns.Add(btn2);

        }

        private void dataGridViewMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string MaMH = dataGridViewMH.CurrentRow.Cells[0].Value.ToString();
                if (e.ColumnIndex == 4)
                {
                    DialogResult dialog = MessageBox.Show("Bạn có muốn xóa môn học này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog.Equals(DialogResult.Yes))
                    {
                        if (!MaMH.Equals(""))
                        {
                            if (!data.XoaMH(MaMH))
                            {
                                MessageBox.Show("Không thể xóa môn học do hãn còn học sinh học môn này !!!");
                            }
                            else
                            {
                                dataGridViewMH.Columns.Clear();
                                hienMH();
                            }
                        }
                        else
                            MessageBox.Show("Lựa chọn một môn học !!!");
                    }
                }
                if (e.ColumnIndex == 5)
                {
                    NhapMH nhapMH = new NhapMH();
                    nhapMH.maMH = MaMH;
                    nhapMH.tenMH = dataGridViewMH.CurrentRow.Cells[1].Value.ToString();
                    nhapMH.soTC = dataGridViewMH.CurrentRow.Cells[2].Value.ToString();
                    nhapMH.hocKy = dataGridViewMH.CurrentRow.Cells[3].Value.ToString();
                    nhapMH.ShowDialog();
                    dataGridViewMH.Columns.Clear();
                    hienMH();
                }
            }
            catch (Exception)
            {
            }
        }

        private void dataGridViewMH_DoubleClick(object sender, EventArgs e)
        {
            SVMon formSV = new SVMon();
            formSV.maMon = dataGridViewMH.CurrentRow.Cells[0].Value.ToString();
            formSV.tenMon = dataGridViewMH.CurrentRow.Cells[1].Value.ToString();
            formSV.ShowDialog();
        }
    }
}
