using KAutoHelper;
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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "/C F:\\Code\\Web\\HTML\\index.html";

            Process process = new Process();

            ProcessStartInfo startInfo = new ProcessStartInfo();

            
            startInfo.Arguments = str;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            process.StartInfo = startInfo;
            process.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "/C F:\\Code\\Web\\HTML\\index.html";

            Process process = new Process();

            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.FileName = "cmd";
          //  startInfo.Arguments = str;
            startInfo.UseShellExecute= false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardInput = true;


            process.StartInfo = startInfo;
            process.Start();


            process.StandardInput.WriteLine(str);
            process.StandardInput.Flush();
            process.StandardInput.Close();
            MessageBox.Show(process.StandardOutput.ReadToEnd());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = (int)coordinatesX.Value;
            int y = (int)coordinatesY.Value;
            EMouseKey eMouseKey = EMouseKey.LEFT;
            if(Dclick.Checked)
            {
                if (Rightmouse.Checked)
                    eMouseKey = EMouseKey.DOUBLE_RIGHT;
                else
                    eMouseKey = EMouseKey.DOUBLE_LEFT;
            }    
            else
            {
                if (Rightmouse.Checked)
                    eMouseKey = EMouseKey.RIGHT;
            }
            AutoControl.MouseClick(x, y, eMouseKey);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = (int)coordinatesX.Value;
            int y = (int)coordinatesY.Value;



            /*var hWnd = Process.GetProcessById(11696).MainWindowHandle;
            var hWnd = Process.GetProcessesByName("UnikeyNT")[0].MainWindowHandle;*/


            IntPtr hWnd = IntPtr.Zero;

            hWnd = AutoControl.FindWindowHandle(null/*class name*/ , App.Text);

            var pointToclick = AutoControl.GetGlobalPoint(hWnd, x, y);

            EMouseKey eMouseKey = EMouseKey.LEFT;
            if (Dclick.Checked)
            {
                if (Rightmouse.Checked)
                    eMouseKey = EMouseKey.DOUBLE_RIGHT;
                else
                    eMouseKey = EMouseKey.DOUBLE_LEFT;
            }
            else
            {
                if (Rightmouse.Checked)
                    eMouseKey = EMouseKey.RIGHT;
            }   

            AutoControl.BringToFront(hWnd); //cho nó lên trước màn hình 
            AutoControl.MouseClick(pointToclick, eMouseKey);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = (int)coordinatesX.Value;
            int y = (int)coordinatesY.Value;

            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle(null, App.Text);
            //  (hwnd , class , text )
            IntPtr hWndc = IntPtr.Zero;
            hWndc = AutoControl.FindHandle(hWnd, "ToolbarWindow32",null );
             //  (hwnd , text, class)
          //  var hWndc = AutoControl.FindWindowExFromParent(hWnd, null, "ToolbarWindow32");


            var pointToClick = AutoControl.GetGlobalPoint(hWndc, x, y);

            AutoControl.BringToFront(hWnd);
            AutoControl.MouseClick(pointToClick);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle(null, App.Text);


            AutoControl.BringToFront(hWnd);
            AutoControl.SendKeyFocus(KeyCode.ENTER);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = new IntPtr();

            hWnd = AutoControl.FindWindowHandle(null, App.Text);

            AutoControl.BringToFront(hWnd);
            AutoControl.SendMultiKeysFocus(new KeyCode[] { KeyCode.CONTROL, KeyCode.KEY_V });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = new IntPtr();
            hWnd = AutoControl.FindWindowHandle(null, App.Text);


            AutoControl.BringToFront(hWnd);
            IntPtr childhWnd = new IntPtr();

            childhWnd = AutoControl.FindHandle(hWnd, "ComboBoxEx32", null);


//            AutoControl.SendText(hWnd, "Đổi tên");

            AutoControl.SendText(childhWnd,TextSend.Text);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = new IntPtr();

            hWnd = AutoControl.FindWindowHandle(null, App.Text);

            IntPtr childhWnd = AutoControl.FindHandle(hWnd, textclick.Text, textclick.Text);

            AutoControl.SendClickOnControlByHandle(childhWnd);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = new IntPtr();
            hWnd = AutoControl.FindWindowHandle(null, App.Text);
            IntPtr childhWnd = new IntPtr();
            childhWnd = AutoControl.FindHandle(hWnd, textclick.Text, textclick.Text);
            int x = (int)coordinatesX.Value;
            int y = (int)coordinatesY.Value;
            AutoControl.SendClickOnPosition(childhWnd, x, y);
            // không phải cái nào cung có thể click ẩn
        }

        private void button11_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = new IntPtr();
            hWnd = AutoControl.FindWindowHandle(null, App.Text);

            AutoControl.SendKeyBoardPress(hWnd,VKeys.VK_RETURN);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var Screen = CaptureHelper.CaptureScreen();
            Screen.Save("Screen.PNG");
            var bitmap = ImageScanOpenCV.GetImage("tim.PNG");

            var bientim = ImageScanOpenCV.Find((Bitmap)Screen, bitmap);

            if (bientim != null)
            {
                bientim.Save("KQ.PNG");
            }    
        }

        private void button13_Click(object sender, EventArgs e)
        {

            IntPtr hWnd = new IntPtr();
            hWnd = AutoControl.FindWindowHandle(null, App.Text);
            AutoControl.BringToFront(hWnd);
            var Screen = CaptureHelper.CaptureScreen();
            Screen.Save("Screen.PNG");

            var anhcantim = ImageScanOpenCV.GetImage("tim.PNG");
            var tim = ImageScanOpenCV.FindOutPoint((Bitmap)Screen, anhcantim);
            String x="";
            String y="";
            String str = tim.ToString();
            int i = 0;
            while(i<str.Length-1)
            {
               i++;
               if(str[i-1] == '=')
                {
                    while (str[i]!=',')
                    {
                        x = x + str[i];
                        i++;
                    }
                    break;
                }
            }
            while (i < str.Length - 1)
            {
                i++;
                if (str[i - 1] == '=')
                {
                    while (str[i] != '}')
                    {
                        y = y + str[i];
                        i++;
                    }
                    break;
                } 
            }
            int p = Convert.ToInt32(x);
            int u = Convert.ToInt32(y);

            AutoControl.MouseClick(p + 20, u + 15, EMouseKey.LEFT);
        }
    }
}
