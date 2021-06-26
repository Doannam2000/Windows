using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoControlAppPc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            str = "/C F:\\Code\\Web\\HTML\\index.html";
            Process.Start("cmd",str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            string str = "/C \"python bai32.py\"";

            Process p = new Process();

            // @ Đường dẫn tuyệt đối "" --> "
            // hoặc dùng \"asbhadfgdf\"


            p.StartInfo.FileName = "cmd";   // mở ứng dụng
            p.StartInfo.Arguments = str;        // lệnh trên cmd
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // Chạy ẩn ứng dụng

            p.Start();



            // dừng p.Kill(); để dừng


            /*string strCmdText;
            strCmdText = "/C F:\\Code\\Web\\HTML\\index.html";

            Process p = new Process();

            p.StartInfo.FileName = "CMD.exe";
            p.StartInfo.Arguments = strCmdText;

            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            p.Start();*/

            //p.Kill();

            /*
             
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C ""How Kteam - Free Education.html""";
            process.StartInfo = startInfo;
            process.Start();
             
             */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "/C python bai33.py";


            Process process = new Process();

            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.FileName = "cmd";
            startInfo.Arguments = str;
            startInfo.CreateNoWindow = true;

            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;

            process.StartInfo = startInfo;
            process.Start();

            process.StandardInput.WriteLine(str);
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();

            MessageBox.Show(process.StandardOutput.ReadToEnd());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
