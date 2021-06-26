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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void form1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void form2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2 ();
            f.ShowDialog();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đoàn Duy Nam", "Thông Báo");
        }

        private void forn3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }
        int x;
        private void timer1_Tick(object sender, EventArgs e)
        {
            x = label2.Location.X;
            x--;
            label2.Location = new Point(x, label2.Location.Y);

            if (x == -697)
            {
                Menu m = new Menu();
                x = m.Size.Width;
                label2.Location = new Point(x, label2.Location.Y);
            }
        }
    }
}
