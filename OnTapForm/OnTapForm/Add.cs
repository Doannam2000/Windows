using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapForm
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if( txtAddress.Text.Equals("")|| txtName.Text.Equals("")|| txtPhone.Text.Equals("")|| txtSalary.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin");
            }    
            else
            {
                try
                {
                    Company cp = new Company();
                    cp.name = txtName.Text;
                    cp.phone = txtPhone.Text;
                    cp.salary = float.Parse(txtSalary.Text);
                    cp.addrid = int.Parse(txtAddress.Text);
                    if (new DataUlit().add(cp))
                    {
                        txtAddress.Text = "";
                        txtName.Text = "";
                        txtPhone.Text = "";
                        txtSalary.Text = "";
                        ActiveControl = txtID;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Nhập sai dữ liệu");
                    return;
                }
            }    
        }

        private void Add_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
        }
    }
}
