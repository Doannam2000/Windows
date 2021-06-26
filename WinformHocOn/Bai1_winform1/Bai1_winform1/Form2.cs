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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            lblTenhang.Text = txtTenHang.Text;
            try
            {
                lblTongTien.Text = (int.Parse(txtSL.Text) * int.Parse(txtDongai.Text)).ToString("C0");

            }
            catch (Exception)
            {
                MessageBox.Show("Có vẻ như bạn nhập sai số lượng hoặc đơn giá", "Thông Báo");
                
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Đừng mà", "Oh No", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(d.Equals(DialogResult.Yes))
            {
                Close();
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDongai.Clear();
            txtSL.Clear();
            txtTenHang.Clear();
            lblTenhang.Text = String.Empty;
            lblTongTien.Text = "";
        }
    }
}
