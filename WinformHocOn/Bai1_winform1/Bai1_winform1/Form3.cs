using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_winform1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private double tien;
        private float  giamgia = 0;
        const int TRANG_DIEM = 125, LAM_TOC = 60, LAM_MONG = 35, MAT_XA = 200;

        private void cbM_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTD.Checked)
                tien += LAM_MONG;
            else
                tien -= LAM_MONG;
            lblTT.Text = tien.ToString("C0");
            lblGG.Text = (tien * giamgia / 100).ToString("C0");
        }

        private void cbMx_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTD.Checked)
                tien += MAT_XA;
            else
                tien -= MAT_XA;
            lblTT.Text = tien.ToString("C0");
            lblGG.Text = (tien * giamgia / 100).ToString("C0");
        }

        private void rad0_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTD.Checked)
            {
                lblGG.Text = "$0";
                giamgia = 0;
            }
        }

        private void rad10_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTD.Checked)
            {
                lblGG.Text = (tien * 0.1).ToString();
                giamgia = 10;
            }
        }

        private void rad20_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTD.Checked)
            {
                lblGG.Text = (tien * 0.2).ToString();
                giamgia = 20;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cbLamtoc.Checked = false;
            cbM.Checked = false;
            cbMx.Checked = false;
            cbTD.Checked = false;
            rad0.Checked = true;
            lblGG.Text = "";
            lblkq.Text = "";
            lblTT.Text = "";
                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbLamtoc_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTD.Checked)
                tien += LAM_TOC;
            else
                tien -= LAM_TOC;
            lblTT.Text = tien.ToString("C0");
            lblGG.Text = (tien * giamgia / 100).ToString("C0");
        }

        private void cbTD_CheckedChanged(object sender, EventArgs e)
        {
            if(cbTD.Checked)
                tien += TRANG_DIEM; 
            else
                tien -= TRANG_DIEM;
            lblTT.Text = tien.ToString("C0");
            lblGG.Text = (tien * giamgia / 100).ToString("C0");
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            lblkq.Text = (tien - tien * giamgia / 100).ToString("C0");
        }
    }
}
