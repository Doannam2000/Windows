using FontAwesome.Sharp;
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
    public partial class DanhSach : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentForm;
        public string welcome { get; set; }
        DataUtil data = new DataUtil();
        public DanhSach()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 50);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 177, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(75, 111, 231);
        }

        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(64, 92, 219);
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;


                iconformCon.IconChar = currentBtn.IconChar;
                iconformCon.IconColor = currentBtn.IconColor;
                lblTittle.Text = currentBtn.Text;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(58, 120, 242);
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;

            }
        }

        private void OpenFormCon(Form formcon)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = formcon;
            formcon.TopLevel = false;
            formcon.FormBorderStyle = FormBorderStyle.None;
            panelDisplay.Controls.Add(formcon);
            panelDisplay.Tag = formcon;
            formcon.BringToFront();
            formcon.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (panelSearch.Visible == true)
            {
                panelMenucon.Visible = true;
                panelSearch.Visible = false;
            }
            else
            {
                panelMenucon.Visible = false;
                panelSearch.Visible = true;
                ActiveButton(sender, RGBcolors.color1);
            }
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

        private void btnDiem_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color2);
            lblLoc.Text = "Tìm kiếm điểm sinh viên";
            OpenFormCon(new Diem());
            btnSearch.Visible = true;
            lbMa.Text = "Mã sinh viên";
            lblMHorT.Text = "Mã môn học";
            lbHocKy.Text = "Kỳ học";
            txtTenMH.Visible = false;
            txtTenLop.Visible = false;
            comboBoxMH.Visible = true;
            comboBoxKH.Visible = true;
            AnbtnLop();

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

        private void btnMonhoc_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color3);
            OpenFormCon(new Mon());
            lblLoc.Text = "Tìm kiếm môn học";
            btnSearch.Visible = true;
            lbMa.Text = "Mã môn học";
            lblMHorT.Text = "Tên môn học";
            lbHocKy.Text = "Kỳ học";
            txtTenMH.Visible = true;
            txtTenLop.Visible = false;
            comboBoxMH.Visible = false;
            comboBoxKH.Visible = true;
            AnbtnLop();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color4);
            OpenFormCon(new LopHoc());
            btnSearch.Visible = true;

            lblLoc.Text = "Tìm kiếm lớp";
            lbMa.Text = "Mã lớp";
            lblMHorT.Text = "Mã khoa";
            lbHocKy.Text = "Tên lớp";


            List<string> x = new List<string>();
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
                    if (dd == 0)
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
                    if (ddd == 000)
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
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color5);
            OpenFormCon(new Khoa());
            btnSearch.Visible = true;
            lbMa.Text = "Mã Khoa";
            lblMHorT.Text = "Tên khoa";
            lbHocKy.Text = "Số điện thoại";
            txtTenMH.Visible = true;
            comboBoxMH.Visible = false;
            txtTenLop.Visible = true;
            comboBoxKH.Visible = false;
            AnbtnLop();
            lblLoc.Text = "Tìm kiếm khoa";
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color6);
            OpenFormCon(new TaiKhoan());
            btnSearch.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Reset();
                currentForm.Close();
                panelSearch.Visible = false;
                panelMenucon.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconformCon.IconChar = IconChar.Home;
            iconformCon.IconColor = Color.White;
            lblTittle.Text = "Home";

        }

        private void DanhSach_Load(object sender, EventArgs e)
        {
            btnSearch.Visible = false;
            panelSearch.Visible = false;
            lblWelcome.Text = "Xin chào " + welcome.ToUpper();
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = false;
            panelMenucon.Visible = true;
            if (lblLoc.Text.Contains("điểm"))
            {
                OpenFormCon(new Diem());
            }
            else if (lblLoc.Text.Contains("môn học"))
            {
                OpenFormCon(new Mon());
            }
            else if (lblLoc.Text.Contains("khoa"))
            {
                OpenFormCon(new Khoa());
            }
            else
            {
                OpenFormCon(new LopHoc());
            }
        }

        private void btnHuongdan_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color7);
            OpenFormCon(new HuongDan());
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (lblLoc.Text.Contains("điểm"))
            {
                DataTable datatable = data.timkiem(txtTimkiem.Text, Convert.ToString(comboBoxMH.SelectedItem), Convert.ToString(comboBoxKH.SelectedItem));
                TimKiem tk = new TimKiem();
                tk.dataTable = datatable;
                tk.user = welcome;
                tk.title = "điểm sinh viên";
                OpenFormCon(tk);
            }
            else if (lblLoc.Text.Contains("môn học"))
            {
                DataTable datatable = data.timkiemMH(txtTimkiem.Text, txtTenMH.Text, Convert.ToString(comboBoxKH.SelectedItem));
                TimKiem tk = new TimKiem();
                tk.dataTable = datatable;
                tk.user = welcome;
                tk.title = "môn học";
                OpenFormCon(tk);
            }
            else if (lblLoc.Text.Contains("khoa"))
            {
                DataTable datatable = data.timkiemKhoa(txtTimkiem.Text, txtTenMH.Text, txtTenLop.Text);
                TimKiem tk = new TimKiem();
                tk.dataTable = datatable;
                tk.user = welcome;
                tk.title = "khoa";
                OpenFormCon(tk);
            }
            else
            {
             
                DataTable datatable = data.timkiemLop(txtTimkiem.Text, txtTenMH.Text, txtTenLop.Text, Convert.ToString(cbKhoa.SelectedItem), Convert.ToString(cbHeDT.SelectedItem), Convert.ToString(cbNam.SelectedItem));
                TimKiem tk = new TimKiem();
                tk.dataTable = datatable;
                tk.user = welcome;
                tk.title = "lớp";
                OpenFormCon(tk);
            }
        }
    }
}
