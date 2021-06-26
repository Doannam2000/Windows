using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataXML dataXml = new DataXML();
        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SanPham x = (SanPham)dataGridView1.CurrentRow.DataBoundItem;
            txtHang.Text = x.hangsx;
            txtMa.Text = x.masp;
            txtMoney.Text = x.giatien + "";
            txtSL.Text = x.sl+"";
            txtTen.Text = x.tensp;
        }

        private void load()
        {
            dataXml = new DataXML();
            dataGridView1.DataSource = dataXml.returnList();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lblslsp.Text = dataXml.returnList().Count.ToString();
        }
        private void clear()
        {
            txtHang.Clear();
            txtMa.Clear();
            txtMoney.Clear();
            txtSL.Clear();
            txtTen.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(CheckId())
            {
                try
                {
                    SanPham x = new SanPham();
                    x.masp = txtMa.Text;
                    x.hangsx = txtHang.Text;
                    x.giatien = int.Parse(txtMoney.Text);
                    x.sl = int.Parse(txtSL.Text);
                    x.tensp = txtTen.Text;
                    dataXml.AddSp(x);
                    load();
                    clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Dữ liệu bạn nhập không đúng", "Error");
                }
                
            }    
            else
            {
                MessageBox.Show("Đã có sản phẩm này trong danh sách", "Thông Báo");
            }    
        }
        private Boolean CheckId()
        {
            foreach (SanPham item in dataXml.returnList())
            {
                if(txtMa.Text.Equals(item.masp))
                {
                    return false;
                }    
            }
            return true;
        }


        int xx;

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            xx = chay.Location.X;
            xx--;
            chay.Location = new Point(xx, chay.Location.Y);
            if(xx == -631)
            {
                Form1 f = new Form1();
                xx = f.Width;
                chay.Location = new Point(xx, chay.Location.Y);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
