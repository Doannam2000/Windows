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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            float x = float.Parse(txtCanNang.Text)*10000 / (float.Parse(txtC.Text) * float.Parse(txtC.Text));
            if (x >= 40)
                MessageBox.Show("Chỉ số BMI của bạn là "+x + "\nBéo phì độ 3", "Chỉ số BMI");
            else if(x >= 35)
                MessageBox.Show("Chỉ số BMI của bạn là " + x + "\nBéo phì độ 2", "Chỉ số BMI");
            else if (x >= 30)
                MessageBox.Show("Chỉ số BMI của bạn là " + x + "\nBéo phì độ 1", "Chỉ số BMI");
            else if (x >= 25)
                MessageBox.Show("Chỉ số BMI của bạn là " + x + "\nThừa cân", "Chỉ số BMI");
            else if (x >= 18.5)
                MessageBox.Show("Chỉ số BMI của bạn là " + x + "\nBình thường", "Chỉ số BMI");
            else if (x >= 17)
                MessageBox.Show("Chỉ số BMI của bạn là " + x + "\nGầy độ 1", "Chỉ số BMI");
            else if (x >= 16)
                MessageBox.Show("Chỉ số BMI của bạn là " + x + "\nGầy độ 2", "Chỉ số BMI");
            else
                MessageBox.Show("Chỉ số BMI của bạn là " + x + "\nGầy độ 3", "Chỉ số BMI");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
