using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapKTra2
{
    public partial class FormSua : Form
    {
        DataUtils data = new DataUtils();
        public FormSua()
        {
            InitializeComponent();
        }

 
        private void LoadForm()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data.readFile();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormSua_Load(object sender, EventArgs e)
        {
            LoadForm();
            txtMaSV.Enabled = false;
            txtMaSV.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Student> list = new List<Student>();
            list = data.readFile();
            if (txtDiaChi.Text.Equals("") || txtMaSV.Text.Equals("") || txtQue.Text.Equals("") || txtTenSV.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu ");
            }
            else
            {
                Student x = new Student();
                x.diaChi = txtDiaChi.Text;
                try
                {
                    x.maSV = int.Parse(txtMaSV.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhập sai dữ liệu ");
                    return;
                }
                x.queQuan = txtQue.Text;
                x.tenSV = txtTenSV.Text;
                list[list.IndexOf(x)] = x;
                data.writeFile(list);
                if(!MessageBox.Show("Bạn có muốn sửa tiếp không ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question).Equals(DialogResult.Yes))
                {
                    Close();
                }
                LoadForm();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Student x = (Student)dataGridView1.CurrentRow.DataBoundItem;
            txtDiaChi.Text = x.diaChi;
            txtMaSV.Text = x.maSV + "";
            txtQue.Text = x.queQuan;
            txtTenSV.Text = x.tenSV;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
