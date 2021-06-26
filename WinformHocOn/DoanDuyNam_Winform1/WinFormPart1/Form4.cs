using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormPart1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        List<SinhVien> sv = new List<SinhVien>();
        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sv;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 100;
/*            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(check())
            {
                try
                {
                    SinhVien x = new SinhVien();
                    x.masv = txtMaSV.Text;
                    if (checkid(x))
                        MessageBox.Show("Sinh viên này đã có trong danh sách", "Thông Báo");
                    else
                    {
                        x.hoten = txtHoten.Text;
                        x.tuoi = int.Parse(txtTuoi.Text);
                        x.diachi = txtDiaChi.Text;
                        sv.Add(x);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = sv;
                        lblslsv.Text = sv.Count + "";
                        boTT();
                    }    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Nhập sai ở đâu đó rồi\nBạn xem lại một lần nữa", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            }
            
        }
        private Boolean check()
        {
            if (txtMaSV.Text.Equals("") || txtMaSV.Text.Equals("") || txtMaSV.Text.Equals("") || txtMaSV.Text.Equals(""))
                return false;
            return true;
        }
        private Boolean checkid(SinhVien idsv)
        {
            foreach (SinhVien item in sv)
            {
                if (idsv.Equals(item))
                    return true;
            }
            return false;
        }
        private void boTT()
        {
            txtDiaChi.Clear();
            txtHoten.Clear();
            txtMaSV.Clear();
            txtTuoi.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sau khi sửa dữ liệu gốc sẽ mất\nBạn chắc chắn muốn tiếp tục chứ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult.Equals(DialogResult.Yes))
            {
                if (check())
                {
                    try
                    {
                        SinhVien x = new SinhVien();
                        x.masv = txtMaSV.Text;
                        if(checkid(x))
                        {
                            x.hoten = txtHoten.Text;
                            x.tuoi = int.Parse(txtTuoi.Text);
                            x.diachi = txtDiaChi.Text;
                            sv[sv.IndexOf(x)] = x;
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = sv;
                            lblslsv.Text = sv.Count + "";
                            boTT();
                        }    
                        else
                        {
                            DialogResult dialogResult1 = MessageBox.Show("Có vẻ như chưa có mã sinh viên này tồn tại\nBạn có muốn thêm sinh viên mới này chứ ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if(dialogResult1.Equals(DialogResult.Yes))
                            {
                                x.hoten = txtHoten.Text;
                                x.tuoi = int.Parse(txtTuoi.Text);
                                x.diachi = txtDiaChi.Text;
                                sv.Add(x);
                                dataGridView1.DataSource = null;
                                dataGridView1.DataSource = sv;
                                lblslsv.Text = sv.Count + "";
                                boTT();
                            } 
                        }    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nhập sai ở đâu đó rồi\nBạn xem lại một lần nữa", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("SinhVien.bin", FileMode.Open, FileAccess.Read);
            sv = (List<SinhVien>)formatter.Deserialize(stream);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sv;
            lblslsv.Text = sv.Count + "";
            stream.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sau khi ghi file dữ liệu gốc sẽ mất\nBạn chắc chắn muốn tiếp tục chứ","Thông Báo", MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
            if(dialogResult.Equals(DialogResult.Yes))
            {
                try
                {
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("SinhVien.bin", FileMode.Create, FileAccess.Write);
                    formatter.Serialize(stream, sv);
                    MessageBox.Show("Ghi file thành công", "Thông báo");
                    stream.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sau khi xóa dữ liệu gốc sẽ mất\nBạn chắc chắn muốn tiếp tục chứ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult.Equals(DialogResult.Yes))
            {
                SinhVien x = new SinhVien();
                x.masv = txtMaSV.Text;
                if(checkid(x))
                {
                    sv.Remove(x);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = sv;
                    lblslsv.Text = sv.Count+"";
                }  
                else
                {
                    MessageBox.Show("Không có sinh viên nào", "Lỗi");
                }    
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SinhVien x = (SinhVien)dataGridView1.CurrentRow.DataBoundItem;
                txtDiaChi.Text = x.diachi;
                txtHoten.Text = x.hoten;
                txtMaSV.Text = x.masv;
                txtTuoi.Text = x.tuoi.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
