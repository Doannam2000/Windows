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
    public partial class Form1 : Form
    {
        DataUtils dat = new DataUtils();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Loadf();
        }
        private void Loadf()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dat.readFile();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            Loadf();
        }

        private void sửaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSua f = new FormSua();
            f.ShowDialog();
            Loadf();
        }
    }
}
