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
    public partial class SVMon : Form
    {
        public SVMon()
        {
            InitializeComponent();
        }
        public string maMon { get; set; }
        public string tenMon{ get; set; }
        DataUtil data = new DataUtil();
        private void SVMon_Load(object sender, EventArgs e)
        {
            lblWel.Text = tenMon;
            loadForm();
        }

        private void loadForm()
        {
            dataSV.DataSource = null;
            dataSV.DataSource = data.dsSVMon(maMon);
            dataSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            xoaBtnColumn(btn2);
            suaBtnColumn(btn1);
            dataSV.Columns.Add(btn1);
            dataSV.Columns.Add(btn2);
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

        private void dataSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string masv = dataSV.Rows[e.RowIndex].Cells[0].Value.ToString();
            string mamh = dataSV.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (e.ColumnIndex == 9)
            {
                string kyhoc = dataSV.Rows[e.RowIndex].Cells[6].Value.ToString();
                string diem = dataSV.Rows[e.RowIndex].Cells[8].Value.ToString();
                NhapSuaDiem sua = new NhapSuaDiem();
                sua.masv = masv;
                sua.mamh = mamh;
                sua.kyhoc = kyhoc;
                sua.diem = diem;
                sua.ShowDialog();
                dataSV.Columns.Clear();
                loadForm();
            }   
            else if(e.ColumnIndex == 10)
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa điểm của sinh viên này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog.Equals(DialogResult.Yes))
                {
                    data.DeleteDiem(mamh, masv);
                    dataSV.Columns.Clear();
                    loadForm();
                }
            }    
        }
    }
}
