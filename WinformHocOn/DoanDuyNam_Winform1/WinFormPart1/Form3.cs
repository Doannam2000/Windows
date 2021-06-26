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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lsbTwo.Items.Add(lsbOne.SelectedItem);
                lsbOne.Items.Remove(lsbOne.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn phải lựa chọn trước", "Thông Báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lsbTwo.Items.AddRange(lsbOne.Items);
            lsbOne.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                lsbOne.Items.Add(lsbTwo.SelectedItem);
                lsbTwo.Items.Remove(lsbTwo.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn phải lựa chọn trước", "Thông Báo");
           
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lsbOne.Items.AddRange(lsbTwo.Items);
            lsbTwo.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
