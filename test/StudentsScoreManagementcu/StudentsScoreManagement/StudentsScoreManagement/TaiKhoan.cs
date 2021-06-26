using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsScoreManagement
{
    public partial class TaiKhoan : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-O90RJHC;Initial Catalog=QLDiem;Integrated Security=True");
        public TaiKhoan()
        {
            InitializeComponent();
        }
        DataUtil data = new DataUtil();
        private void TaiKhoan_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = data.dsTK();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //txtName.Enabled = true;
            Random rd = new Random();
            int d = rd.Next(0, 9999);
            if (txtName.Text.Equals("") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống Tên hoặc mật khẩu");
                return;
            }
            else if (txtName.Text.ToUpper().Contains("ADMIN"))
            {
                MessageBox.Show("Tên này không được phép thêm");
                return;
            }

            SqlDataAdapter da = new SqlDataAdapter("select Ten from DangNhap where Ten =N'" + txtName.Text + "' ", sqlConnection);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            sqlConnection.Close();
            for (int i = 0; i < data.dsTK().Rows.Count; i++)
            {
                if (data.dsTK().Rows[i]["UserID"].ToString().Equals(d.ToString()))
                {
                    d = rd.Next(0, 9999);
                    i = -1;
                }
            }
            if (dataTable.Rows.Count >= 1)
            {
                MessageBox.Show("Tên này đã tồn tại");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn đã chắc chắn muốn thêm tài khoản:  " + "\n " + txtName.Text + "\n " + txtPass.Text, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult.Equals(DialogResult.Yes))
                {
                    data.ThemTaiKhoan(d.ToString(), txtName.Text, txtPass.Text);
                    dataGridView1.DataSource = data.dsTK();
                    MessageBox.Show("Thêm thành công");
                    txtName.Clear();
                    txtPass.Clear();
                    return;

                }
                else
                {
                    Close();
                }

            }

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            //txtName.Enabled = false;
            if (txtPass.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                return;
            }
            else if (txtName.Text.ToUpper().Contains("ADMIN"))
            {
                MessageBox.Show("Bạn không thể sửa tài khoản này!!!");
                return;

            }

            foreach (DataRow item in data.dsTK().Rows)
            {
                if (item["Ten"].ToString().Equals(txtName.Text) && item["Password"].ToString().Equals(txtPass.Text))
                {
                    MessageBox.Show("Bạn chưa thay đổi mật khẩu!!!");
                    return;
                }

            }
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Ten from DangNhap where Ten =N'" + txtName.Text + "' ", sqlConnection);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            DialogResult d = MessageBox.Show("Bạn đã chắc chắn thay đổi password thành:  " + "\n " + txtPass.Text, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d.Equals(DialogResult.Yes))
            {
                if (dataTable.Rows.Count != 0)
                {
                    if (!data.SuaTaiKhoan(txtName.Text, txtPass.Text))
                    {
                        MessageBox.Show("Sửa không thành công");
                        sqlConnection.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Sửa thành công");
                        dataGridView1.DataSource = data.dsTK();
                        txtName.Clear();
                        txtPass.Clear();
                        sqlConnection.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Không tồn tại tài khoản này");
                    sqlConnection.Close();
                    return;
                }
            }
            else
            {
                sqlConnection.Close();
                return;
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Ten from DangNhap where Ten =N'" + txtName.Text + "' ", sqlConnection);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            DialogResult d = MessageBox.Show("Bạn đã chắc chắn xóa tài khoản:  " + "\n " + txtName.Text, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d.Equals(DialogResult.Yes))
            {
                if (dataTable.Rows.Count != 0)
                {
                    if (!data.XoaTaiKhoan(txtName.Text))
                    {
                        MessageBox.Show("Xóa không thành công");
                        sqlConnection.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thành công");
                        dataGridView1.DataSource = data.dsTK();
                        txtName.Clear();
                        txtPass.Clear();
                        sqlConnection.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Không tồn tại tài khoản này");
                    sqlConnection.Close();
                    return;
                }
            }
            else
            {
                sqlConnection.Close();
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtPass.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }
    }
}

