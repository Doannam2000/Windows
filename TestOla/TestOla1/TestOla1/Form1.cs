using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;
using KAutoHelper;
using System.CodeDom;

namespace TestOla1
{
    public partial class Form1 : Form
    {

        ChromeDriver chrome;
        ChromeOptions chromeOptions = new ChromeOptions();
        String ProfieFolderPath = "Profile";
        public Form1()
        {
            InitializeComponent();
        }
        public void SkipAD()
        {
            var Screen = CaptureHelper.CaptureScreen();
            Screen.Save("Screen.PNG");

            var tim = ImageScanOpenCV.GetImage("tim1.PNG");

            var bitmap = ImageScanOpenCV.FindOutPoint((Bitmap)Screen,tim);

            if (bitmap != null)
            {
                AutoControl.MouseClick(bitmap.Value.X + 20, bitmap.Value.Y + 10);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (user1.Text.Length == 0 || password1.Text.Length == 0)
            {
                MessageBox.Show("Có cl địt con bà mày");
                return;
            }
           
            if(!Directory.Exists(ProfieFolderPath))
            {
                Directory.CreateDirectory(ProfieFolderPath);
            }
            else
            {
                int number = 0;
                chromeOptions.AddArguments("user-data-dir=" + ProfieFolderPath + "\\" + number);
            }
            chrome = new ChromeDriver(chromeOptions);
            chrome.Navigate().GoToUrl("https://olacity.com/dashboard/view-ads");

            Thread.Sleep(TimeSpan.FromSeconds(3));
            var User = chrome.FindElementByXPath("/html/body/div[2]/div/div/div[2]/div/div/div/div/div/div[2]/div/form/div[1]/input");
            User.SendKeys(user1.Text);


            var Pass = chrome.FindElementByXPath("/html/body/div[2]/div/div/div[2]/div/div/div/div/div/div[2]/div/form/div[2]/input");
            Pass.SendKeys(password1.Text);
            Thread.Sleep(TimeSpan.FromSeconds(3));

            var Screen = CaptureHelper.CaptureScreen();
            Screen.Save("Screen.png");

            var tim = ImageScanOpenCV.GetImage("Tim.png");

            var bitmap = ImageScanOpenCV.FindOutPoint((Bitmap)Screen, tim);

            if(bitmap!=null)
            {
                AutoControl.MouseClick(bitmap.Value.X + 17, bitmap.Value.Y+20);
            }
             
            Thread.Sleep(TimeSpan.FromSeconds(5));

            var btnDangNhap = chrome.FindElementByXPath("/html/body/div[2]/div/div/div[2]/div/div/div/div/div/div[2]/div/form/button");
            btnDangNhap.Click();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(!Directory.Exists(ProfieFolderPath))
            {
                Directory.CreateDirectory(ProfieFolderPath);
            }    
           else
            {
                int number = 0;
                chromeOptions.AddArguments("user-data-dir=" + ProfieFolderPath + "\\" + number);
            }    
            chrome = new ChromeDriver(chromeOptions);
            chrome.Url = "https://youtube.com";
            chrome.Navigate();

            var text11 = chrome.FindElementByName("search_query");
            Thread.Sleep(3000);
            text11.SendKeys("Bông hoa chẳng thuộc về ta");
            var search = chrome.FindElementById("search-icon-legacy");
            search.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));

            var one = chrome.FindElementByXPath("/html/body/ytd-app/div/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[2]/ytd-item-section-renderer/div[3]/ytd-video-renderer[1]/div[1]");
            one.Click();
            Thread.Sleep(TimeSpan.FromSeconds(8));
            while(true)
            {
                SkipAD();
                Thread.Sleep(TimeSpan.FromSeconds(15));
            }    
        }
    }
}
