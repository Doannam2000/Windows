using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsScoreManagement
{
    public partial class DanhSachDiemSV : Form
    {
        private DataUtil data = new DataUtil();
        private readonly DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
        private readonly DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
        private readonly DataGridViewButtonColumn btn3 = new DataGridViewButtonColumn();
        Encoding encoding = Encoding.UTF8;
        private SinhVien sv = new SinhVien();
        public string welcome { get; set; }

        public DanhSachDiemSV()
        {
            InitializeComponent();
        }

        private void DanhSachDiemSV_Load(object sender, EventArgs e)
        {
            if(!welcome.ToUpper().Equals("ADMIN"))
            {
                btnTaiKhoan.Text = "Hướng dẫn";
                hdMenu.Text = "Hướng dẫn";
            }    
            lblUser.Text =  "User : "+welcome.ToUpper();
            DateTime now = DateTime.Now;
            CultureInfo viVn = new CultureInfo("vi-VN");
            lblDay.Text ="Day : "+ now.ToString("d",viVn);
            hienThiDiemSV();


            foreach (DataRow dr in data.dsMonHoc().Rows)
                comboBoxMH.Items.Add(dr["MaMH"].ToString());


            comboBoxKH.Items.Add("1");
            comboBoxKH.Items.Add("2");
            comboBoxKH.Items.Add("3");
            comboBoxKH.Items.Add("4");
            comboBoxKH.Items.Add("5");
            comboBoxKH.Items.Add("6");
            comboBoxKH.Items.Add("7");
            comboBoxKH.Items.Add("8");

        }
        private void hienThiDiemSV()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data.dsDiemSV();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            xoaBtnColumn(btn1);
            suaBtnColumn(btn2);
            xemChiTiet();
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

        private void xemChiTiet()
        {
            btn3.HeaderText = "Xem chi tiết";
            btn3.Name = "btnXem";
            btn3.Text = "Xem thông tin";
            btn3.UseColumnTextForButtonValue = true;
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
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
            if(e.ColumnIndex == 5)
            {
                string kyhoc = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string diem = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                NhapSuaDiem sua = new NhapSuaDiem();
                sua.masv = masv;
                sua.mamh = mamh;
                sua.kyhoc = kyhoc;
                sua.diem = diem;
                sua.ShowDialog();
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = null;
                hienThiDiemSV();
            }
            if (e.ColumnIndex == 4)
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa điểm của sinh viên này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialog.Equals(DialogResult.Yes))
                {
                    data.DeleteDiem(mamh, masv);
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = null;
                    hienThiDiemSV();
                }
            }
        }



        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("            BẢN QUYỀN THUỘC VỀ           \n\nNHÓM 5:\nĐỖ VINH HÀ\nNguyễn Anh Linh\nĐoàn Duy Nam\nLê Hồng Phong");

        }

        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string masv = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            if (!masv.Equals(""))
            {
                XemChiTiet xem = new XemChiTiet(data.thongTinChiTiet(masv));
                xem.ShowDialog();
            }
            else
                MessageBox.Show("Lựa chọn một sinh viên !!!");
   
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            string masv = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            string mamh = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            string kyhoc = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            string diem = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            if (!masv.Equals(""))
                {
                    NhapSuaDiem sua = new NhapSuaDiem();
                    sua.masv = masv;
                    sua.mamh = mamh;
                    sua.kyhoc = kyhoc;
                    sua.diem = diem;
                    sua.ShowDialog();
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = null;
                    hienThiDiemSV();
            }    
                else
                    MessageBox.Show("Lựa chọn một sinh viên !!!");

            
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa điểm của sinh viên này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog.Equals(DialogResult.Yes))
            {
                string masv = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                string mamh = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                if (!masv.Equals(""))
                {
                    data.DeleteDiem(mamh, masv);
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = null;
                    hienThiDiemSV();
                }
                else
                    MessageBox.Show("Lựa chọn một sinh viên !!!");
            }

        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                DataGridViewCell c = ((DataGridView)sender)[e.ColumnIndex, e.RowIndex];
                if(e.RowIndex < dataGridView1.RowCount && e.ColumnIndex < dataGridView1.ColumnCount)
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

        private void btnQuayLai()
        {
            if (lbLoc.Text.Contains("sinh viên"))
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = null;
                hienThiDiemSV();
            }
            else if (lbLoc.Text.Contains("môn học"))
            {
                dataGridViewMH.Columns.Clear();
                dataGridViewMH.DataSource = null;
                dataGridViewMH.DataSource = data.dsMonHoc();
                dataGridViewMH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (welcome.ToUpper().Equals("ADMIN"))
                {
                    hienMH();
                }
            }
            else if (lbLoc.Text.Contains("Khoa"))
            {
                dataGridViewKhoa.Columns.Clear();
                dataGridViewKhoa.DataSource = null;
                dataGridViewKhoa.DataSource = data.dsKhoa();
                dataGridViewKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (welcome.ToUpper().Equals("ADMIN"))
                {
                    hienKhoa();
                }

            }
            else
            {
                dataGridViewLop.Columns.Clear();
                dataGridViewLop.DataSource = null;
                dataGridViewLop.DataSource = data.dsLop();
                dataGridViewLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (welcome.ToUpper().Equals("ADMIN"))
                {
                    hienLop();
                }

            }
        }
        private void button2_Click(object sender, EventArgs e) /// btn Tìm Kiếm
        {
            if(lbLoc.Text.Contains("sinh viên"))
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data.timkiem(txtTimkiem.Text, Convert.ToString(comboBoxMH.SelectedItem), Convert.ToString(comboBoxKH.SelectedItem));
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                xoaBtnColumn(btn1);
                suaBtnColumn(btn2);
                xemChiTiet();
                dataGridView1.Columns.Add(btn1);
                dataGridView1.Columns.Add(btn2);
                dataGridView1.Columns.Add(btn3);
            }    
            else if(lbLoc.Text.Contains("môn học"))
            {
                dataGridViewMH.Columns.Clear();
                dataGridViewMH.DataSource = null;
                dataGridViewMH.DataSource = data.timkiemMH(txtTimkiem.Text, txtTenMH.Text, Convert.ToString(comboBoxKH.SelectedItem));
                dataGridViewMH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (welcome.ToUpper().Equals("ADMIN"))
                {
                    hienMH();
                }
            }  
            else if(lbLoc.Text.Contains("Khoa"))
            {
                dataGridViewKhoa.Columns.Clear();
                dataGridViewKhoa.DataSource = null;
                dataGridViewKhoa.DataSource = data.timkiemKhoa(txtTimkiem.Text, txtTenMH.Text, txtTenLop.Text);
                dataGridViewKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (welcome.ToUpper().Equals("ADMIN"))
                {
                    hienKhoa();
                }
            }  
            else
            {
                dataGridViewLop.Columns.Clear();
                dataGridViewLop.DataSource = null;
                dataGridViewLop.DataSource = data.timkiemLop(txtTimkiem.Text, txtTenMH.Text, txtTenLop.Text,Convert.ToString(cbKhoa.SelectedItem), Convert.ToString(cbHeDT.SelectedItem), Convert.ToString(cbNam.SelectedItem));
                dataGridViewLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (welcome.ToUpper().Equals("ADMIN"))
                {
                    hienLop();
                }
            }    
        }

        private void button4_Click(object sender, EventArgs e)  /// btnQuayLai
        {
            btnQuayLai();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhapSuaDiem nhap = new NhapSuaDiem();
            nhap.ShowDialog();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            hienThiDiemSV();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
       
                tabControl1.SelectedIndex = 1;
 
        }

        private void hienMH()
        {

            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            xoaBtnColumn(btn1);
            suaBtnColumn(btn2);
            dataGridViewMH.Columns.Add(btn1);
            dataGridViewMH.Columns.Add(btn2);
        }
        private void hienLop()
        {
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            xoaBtnColumn(btn1);
            suaBtnColumn(btn2);
            dataGridViewLop.Columns.Add(btn1);
            dataGridViewLop.Columns.Add(btn2);
        }

        private void hienKhoa()
        {
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            xoaBtnColumn(btn1);
            suaBtnColumn(btn2);
            dataGridViewKhoa.Columns.Add(btn1);
            dataGridViewKhoa.Columns.Add(btn2);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    lbLoc.Text = "Lọc sinh viên";
                    lbMa.Text = "Mã sinh viên";
                    lblMHorT.Text = "Mã môn học";
                    lbHocKy.Text = "Kỳ học";
                    txtTenMH.Visible = false;
                    txtTenLop.Visible = false;
                    comboBoxMH.Visible = true;
                    comboBoxKH.Visible = true;
                    dataGridView1.Columns.Clear();
               
                    hienThiDiemSV();
                    AnbtnLop();
                    break;
                case 1:
                    dataGridViewMH.Columns.Clear();
                    dataGridViewMH.DataSource = data.dsMonHoc();
                    dataGridViewMH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    btnNhapMH.Visible = false;
                    if (welcome.ToUpper().Equals("ADMIN"))
                    {
                        hienMH();
                        btnNhapMH.Visible = true;
                    }

                    lbLoc.Text = "Tìm môn học";
                    lbMa.Text = "Mã môn học";
                    lblMHorT.Text = "Tên môn học";
                    lbHocKy.Text = "Kỳ học";
                    txtTenMH.Visible = true;
                    txtTenLop.Visible = false;
                    comboBoxMH.Visible = false;
                    comboBoxKH.Visible = true;
                    AnbtnLop();
                    break;
                case 2:
                    dataGridViewLop.Columns.Clear();
                    dataGridViewLop.DataSource = data.dsLop();
                    dataGridViewLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    btnNhapLop.Visible = false;
                    if (welcome.ToUpper().Equals("ADMIN"))
                    {
                        hienLop();
                        btnNhapLop.Visible = true;
                    }
                    lbLoc.Text = "Tìm Lớp";
                    lbMa.Text = "Mã lớp";
                    lblMHorT.Text = "Mã khoa";
                    lbHocKy.Text = "Tên lớp";
                    List<string> x =new List<string>();
                    List<string> y = new List<string>();
                    List<string> z = new List<string>();

                    cbKhoa.Items.Clear();
                    cbHeDT.Items.Clear();
                    cbNam.Items.Clear();

                    foreach (DataRow dr in data.dsLop().Rows)
                    {
                        if (x.Count != 0)
                        {
                            int d = 0;
                            foreach (string item in x)
                            {
                                if (dr["Khoa"].ToString().Equals(item))
                                {
                                    d = 1;
                                    break;
                                }
                            }
                            if (d == 0)
                            {
                                cbKhoa.Items.Add(dr["Khoa"].ToString());
                                x.Add(dr["Khoa"].ToString());
                            }    
                            
                        }
                        else
                        {
                            cbKhoa.Items.Add(dr["Khoa"].ToString());
                            x.Add(dr["Khoa"].ToString());
                        }


                        //----------------------------------------
                        if (y.Count != 0)
                        {
                            int dd = 0;
                            foreach (string item in y)
                            {
                                if (dr["HeDaoTao"].ToString().Equals(item))
                                {
                                    dd = 1;
                                    break;
                                }
                            }
                            if(dd==0)
                            {
                                cbHeDT.Items.Add(dr["HeDaoTao"].ToString());
                                y.Add(dr["HeDaoTao"].ToString());
                            }    
                        }
                        else
                        {
                            cbHeDT.Items.Add(dr["HeDaoTao"].ToString());
                            y.Add(dr["HeDaoTao"].ToString());
                        }


                        //----------------------------------------

                        if (z.Count != 0)
                        {
                            int ddd = 0;
                            foreach (string item in z)
                            {
                                if (dr["NamNhapHoc"].ToString().Equals(item))
                                {
                                    ddd = 1;
                                    break;
                                }
                            }
                            if(ddd==000)
                            {
                                cbNam.Items.Add(dr["NamNhapHoc"].ToString());
                                z.Add(dr["NamNhapHoc"].ToString());
                            }    
                            
                        }
                        else
                        {
                            cbNam.Items.Add(dr["NamNhapHoc"].ToString());
                            z.Add(dr["NamNhapHoc"].ToString());
                        }

                        
                    }    
                    txtTenMH.Visible = true;
                    comboBoxMH.Visible = false;
                    txtTenLop.Visible = true;
                    comboBoxKH.Visible = false;
                    HienBtnLop();
                    break;
                case 3:
                    AnbtnLop();
                    dataGridViewKhoa.Columns.Clear();
                    dataGridViewKhoa.DataSource = data.dsKhoa();
                    dataGridViewKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    btnNhapKhoa.Visible = false;
                    if (welcome.ToUpper().Equals("ADMIN"))
                    {
                        hienKhoa();
                        btnNhapKhoa.Visible = true;
                    }
                    lbLoc.Text = "Tìm Khoa";
                    lbMa.Text = "Mã Khoa";
                    lblMHorT.Text = "Tên khoa";
                    lbHocKy.Text = "Số điện thoại";
                    txtTenMH.Visible = true;
                    comboBoxMH.Visible = false;
                    txtTenLop.Visible = true;
                    comboBoxKH.Visible = false;
            
                    break;
                default:
                    break;
            }
            
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
           
                tabControl1.SelectedIndex = 2;

        }
        private void AnbtnLop()
        {
            lblKhoa.Visible = false;
            cbKhoa.Visible = false;
            lblHeDD.Visible = false;
            lblNam.Visible = false;
            cbKhoa.Visible = false;
            cbNam.Visible = false;
            cbHeDT.Visible = false;
        }

        private void HienBtnLop()
        {

            lblKhoa.Visible = true;
            cbKhoa.Visible = true;
            lblHeDD.Visible = true;
            lblNam.Visible = true;
            cbKhoa.Visible = true;
            cbNam.Visible = true;
            cbHeDT.Visible = true;
        }
        private void btnKhoa_Click(object sender, EventArgs e)
        {
   
                tabControl1.SelectedIndex = 3;
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
             tabControl1.SelectedIndex = 0;
        }

   

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            if(welcome.ToUpper().Equals("ADMIN"))
            {
                TaiKhoan ta = new TaiKhoan();
                ta.ShowDialog();
            }    
            else
            {
                HuongDan huong = new HuongDan();
                huong.Show();
            }    
        }

        private void btnNhapMH_Click(object sender, EventArgs e)
        {
            NhapMH mh = new NhapMH();
            mh.ShowDialog();
            btnQuayLai();
        }

        private void dataGridViewMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaMH = dataGridViewMH.Rows[dataGridViewMH.CurrentRow.Index].Cells[0].Value.ToString();
            if(e.ColumnIndex == 4)
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa môn học này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog.Equals(DialogResult.Yes))
                {
                    if (!MaMH.Equals(""))
                    {
                        if(!data.XoaMH(MaMH))
                        {
                            MessageBox.Show("Không thể xóa môn học do hãn còn học sinh học môn này !!!");
                        }    
                        else
                        {
                            btnQuayLai();
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
                nhapMH.tenMH = dataGridViewMH.Rows[dataGridViewMH.CurrentRow.Index].Cells[1].Value.ToString();
                nhapMH.soTC = dataGridViewMH.Rows[dataGridViewMH.CurrentRow.Index].Cells[2].Value.ToString();
                nhapMH.hocKy = dataGridViewMH.Rows[dataGridViewMH.CurrentRow.Index].Cells[3].Value.ToString();
                nhapMH.ShowDialog();
                btnQuayLai();
            }
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
                            btnQuayLai();
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
                btnQuayLai();
            }
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
                            btnQuayLai();
                        }
                    }
                    else
                        MessageBox.Show("Lựa chọn một lớp để xóa !!!");
                }
            }
            if(e.ColumnIndex == 4)
            {
                NhapSuaKhoa nhap = new NhapSuaKhoa();
                nhap.maKhoa = MaKhoa;
                nhap.tenKhoa = dataGridViewKhoa.Rows[dataGridViewKhoa.CurrentRow.Index].Cells[1].Value.ToString();
                nhap.dienThoai = dataGridViewKhoa.Rows[dataGridViewKhoa.CurrentRow.Index].Cells[2].Value.ToString();
                nhap.ShowDialog();
                btnQuayLai();
            }    

        }

        private void btnNhapLop_Click(object sender, EventArgs e)
        {
            NhapSuaLop nhapSua = new NhapSuaLop();
            nhapSua.ShowDialog();
            btnQuayLai();
        }

        private void btnNhapKhoa_Click(object sender, EventArgs e)
        {
            NhapSuaKhoa nhapSuaKhoa = new NhapSuaKhoa();
            nhapSuaKhoa.ShowDialog();
            btnQuayLai();
        }


        private void danhSáchĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void dataGridViewMH_DoubleClick(object sender, EventArgs e)
        {
            SVMon formSV = new SVMon();
            formSV.maMon = dataGridViewMH.CurrentRow.Cells[0].Value.ToString();
            formSV.tenMon = dataGridViewMH.CurrentRow.Cells[1].Value.ToString();
            formSV.ShowDialog();
        }

        private void exportFile(DataTable x)
        {
            if (x.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            string TimeNewR = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "TIMES.TTF"); // chọn font chữ
                            BaseFont bf = BaseFont.CreateFont(TimeNewR, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED); 
                            iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

                            PdfPTable pdfTable = new PdfPTable(x.Columns.Count);
                            pdfTable.DefaultCell.Padding = 10; 
                            pdfTable.WidthPercentage = 100;  // chia %

                            List<string> name = new List<string>();

                            foreach (DataColumn column in x.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                                pdfTable.AddCell(cell);
                                name.Add(column.ColumnName);
                            }


                            foreach (DataRow row in x.Rows)
                            {
                                for (int i = 0; i < name.Count; i++)
                                {
                                    PdfPCell pdfCell = new PdfPCell(new Phrase(row[name[i]].ToString(),f));
                                    pdfTable.AddCell(pdfCell);
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(new Phrase("Nhóm 5", f));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Dữ liệu Export thành công!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào được Export!!!", "Info");
            }

        }

        private void dsDiemSVToolStripMenuItem_Click(object sender, EventArgs e)
        {

            exportFile(data.dsDiemSV());
        }

        private void dsMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportFile(data.dsMonHoc());
        }

        private void dsLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportFile(data.dsLop());
        }

        private void dsKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportFile(data.dsKhoa());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTT_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Khoa_Click(object sender, EventArgs e)
        {

        }
    }
}
