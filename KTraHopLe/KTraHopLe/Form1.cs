using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTraHopLe
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

        private void CheckName(object sender, CancelEventArgs e)
        {
            if(txtName.Text.Equals(""))
            {
                txtName.Focus();
                errorProvider1.SetError(txtName, "Không thể để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, "");
            }
        }

        private void checkAge(object sender, CancelEventArgs e)
        {
            int k;
            if(txtAge.Text=="")
            {
                txtAge.Focus();
                errorProvider1.SetError(txtAge, "Không thể để trống");

            }
            else if (!int.TryParse(txtAge.Text, out k))
            {
                txtAge.Focus();
                errorProvider1.SetError(txtAge, "Không đúng dữ liệu");
            }    
            else if(int.Parse(txtAge.Text)>130 || int.Parse(txtAge.Text)<0)
            {
                txtAge.Focus();
                errorProvider1.SetError(txtAge, "Không đúng");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAge, "");
            }
        }

        private void checkPhone(object sender, CancelEventArgs e)
        {
            int k;
            if (txtPhone.Text == "")
            {
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "Không thể để trống");

            }
            else if(!Regex.IsMatch(txtPhone.Text,"[0-9]{3}-[0-9]{3}-[0-9]{4}"))
            {
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "sai định dạng");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private void checkMail(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Không thể để trống");

            }
            else if (!Regex.IsMatch(txtEmail.Text, "[a-zA-Z0-9._]@gmail.com"))
            {
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "sai định dạng");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void checkAddress(object sender, CancelEventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.Focus();
                errorProvider1.SetError(txtAddress, "Không thể để trống");

            }
            else if (!Regex.IsMatch(txtAddress.Text, "[a-zA-Z0-9, ]"))
            {
                txtAddress.Focus();
                errorProvider1.SetError(txtAddress, "sai định dạng");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chúc mừng bạn nhập đúng hết rồi");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
