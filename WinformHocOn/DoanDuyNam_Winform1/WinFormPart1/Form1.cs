using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormPart1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtKq.Text = (int.Parse(txtSo1.Text) * int.Parse(txtSo2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính toán", "Thông báo");
            }
        }

        private void btnCong_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtKq.Text = (int.Parse(txtSo1.Text) + int.Parse(txtSo2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính toán", "Thông báo");
            }
        }

        private void btnTru_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtKq.Text = (int.Parse(txtSo1.Text) - int.Parse(txtSo2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính toán", "Thông báo");
            }
        }

        private void btnChia_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtKq.Text = (int.Parse(txtSo1.Text)/ int.Parse(txtSo2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính toán", "Thông báo");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
