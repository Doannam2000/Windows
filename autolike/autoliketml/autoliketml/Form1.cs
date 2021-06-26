using KAutoHelper;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoliketml
{
    public partial class Form1 : Form
    {
        ChromeDriver chrome;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ChromeOptions chromeOptions = new ChromeOptions();
            //String ProfileFolderPath = "Profile";
        /*    if (chrome != null)
            {
                chrome.Close();
                chrome.Quit();
            }
            if (!Directory.Exists(ProfileFolderPath))
            {
                Directory.CreateDirectory(ProfileFolderPath);
            }
            int number = 0;
            if (Directory.Exists(ProfileFolderPath))
            {
                chromeOptions.AddArguments("user-data-dir=" + ProfileFolderPath + "\\" + number);
            }*/
            chromeOptions.AddArguments("--window-size=180,800");
            chromeOptions.AddArguments("--disable-notifications");
            chrome = new ChromeDriver(chromeOptions);
            chrome.Url = "https://www.messenger.com/t/doanvu2000";
            Thread.Sleep(TimeSpan.FromSeconds(3));

            var email = chrome.FindElementById("email");
            email.SendKeys("0397482016");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            var matkhau = chrome.FindElementById("pass");
            matkhau.SendKeys("Hoacute4321");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            var click = chrome.FindElementById("loginbutton");
            click.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            while(true)
            {
               
                var Screen = CaptureHelper.CaptureScreen();
                Screen.Save("Screen.PNG");

                var anhcantim = ImageScanOpenCV.GetImage("Capture.PNG");

                var tim = ImageScanOpenCV.FindOutPoint((Bitmap)Screen, anhcantim);
                if (tim == null)
                {
                    continue;

                }
                var like = chrome.FindElementByXPath("/html/body/div[1]/div/div/div[2]/span/div[2]/div[2]/div[2]/div/a");
                like.Click();
            }    
        }
    }
}
