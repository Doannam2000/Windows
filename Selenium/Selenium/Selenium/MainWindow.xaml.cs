
using AutoItX3Lib;
using KAutoHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Selenium
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ChromeDriver chromeDriver;
        public MainWindow()
        {
          
            InitializeComponent();
        }
        public ChromeOptions OpenProfile()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            String ProfileFolderPath = "Profile";
            if (chromeDriver != null)
            {
                try
                {
                    chromeDriver.Close();
                    chromeDriver.Quit();

                }
                catch (Exception ex)
                {

                }
            }
            if (!Directory.Exists(ProfileFolderPath))
            {
                Directory.CreateDirectory(ProfileFolderPath);
            }
            else
            {
                int number = 0;
                chromeOptions.AddArguments("user-data-dir=" + ProfileFolderPath + "\\" + number);
            }
            return chromeOptions;
        }
        public void SkipAD()
        {
            while(true)
            {
                var Screen = CaptureHelper.CaptureScreen();
                Screen.Save("Screen.PNG");
                var bitmap = ImageScanOpenCV.GetImage("tim1.PNG");
                var fin = ImageScanOpenCV.FindOutPoint((Bitmap)Screen, bitmap);
                if (fin != null)
                {
                    AutoControl.MouseClick(fin.Value.X + 15, fin.Value.Y + 10, EMouseKey.LEFT);
                }
                Thread.Sleep(TimeSpan.FromSeconds(20));
            }    
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            ChromeDriver chromeDriver = new ChromeDriver(OpenProfile());
            chromeDriver.Url = "https://youtube.com";
            chromeDriver.Navigate();
            var searchBar = chromeDriver.FindElementByName("search_query");
            searchBar.SendKeys("Có chắc yêu là đây");
            var searchl = chromeDriver.FindElementById("search-icon-legacy");
            searchl.Click();
            Thread.Sleep(5000);
            var play = chromeDriver.FindElementByCssSelector("#contents > ytd-video-renderer:nth-child(1)");
            play.Click();
            Thread.Sleep(11000);
            SkipAD();
        }
       private void button_Click1(object sender, RoutedEventArgs e)
        {
            ChromeDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.howkteam.vn/course/khoa-hoc-selenium-co-ban-den-nang-cao/excute-javascript-voi-selenium-trong-wpf-2577";
            chrome.Navigate();

            IJavaScriptExecutor js = chrome as IJavaScriptExecutor;
            var dataFromJS = (string)js.ExecuteScript("var content = document.getElementsByClassName('w-100')[0].children[0].innerHTML;return content;");
            MessageBox.Show(dataFromJS.ToString());
        }

        private void button_Click2(object sender, RoutedEventArgs e)
        {
            chromeDriver = new ChromeDriver(OpenProfile());
        }

        private void button_Click3(object sender, RoutedEventArgs e)
        {
            chromeDriver = new ChromeDriver(OpenProfile());

            String ip = "8.210.249.129:3128";
            String username = "username";
            String pass = "password";
            String ExtentionFolderPath = "Extention";
            // thoát driver đang có
            if (chromeDriver != null)
            {
                try
                {
                    chromeDriver.Close();
                    chromeDriver.Quit();
                }
                catch (Exception ex)
                {
                }
            }

            ChromeOptions options = new ChromeOptions();
   
            if (!string.IsNullOrEmpty(ip))
            {
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(pass))
                {
                    options.AddExtension(ExtentionFolderPath + "\\Proxy Auto Auth.crx");
                }
                options.AddArgument(string.Format("--proxy-server={0}", ip));
            }

            chromeDriver = new ChromeDriver(options);

            if (!string.IsNullOrEmpty(ip))
            {
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(username))
                {
                    chromeDriver.Url = "chrome-extension://ggmdpepbjljkkkdaklfihhngmmgmpggp/options.html";
                    chromeDriver.Navigate();

                    chromeDriver.FindElementById("login").SendKeys(username);
                    chromeDriver.FindElementById("password").SendKeys(pass);
                    chromeDriver.FindElementById("retry").Clear();
                    chromeDriver.FindElementById("retry").SendKeys("2");

                    chromeDriver.FindElementById("save").Click();
                }
            }
            chromeDriver.Navigate().GoToUrl("https://whoer.net/");
        }

        private void button_Click4(object sender, RoutedEventArgs e)
        {
            chromeDriver = new ChromeDriver(OpenProfile());
            chromeDriver.Url = "https://www.howkteam.vn/course/khoa-hoc-selenium-co-ban-den-nang-cao/change-frame-voi-selenium-trong-wpf-2590";
            Thread.Sleep(3000);
            var play = chromeDriver.FindElementById("ytplayer");
            play.Click();

            chromeDriver.SwitchTo().Frame("ytplayer");

            var gotoYtb = chromeDriver.FindElementByCssSelector(".ytp-youtube-button");

            gotoYtb.Click();
        }

        private void button_Click5(object sender, RoutedEventArgs e)
        {
            chromeDriver = new ChromeDriver(OpenProfile());
            chromeDriver.Url = "https://secufiles.com/";
            Thread.Sleep(TimeSpan.FromSeconds(3));

            var btnUpload = chromeDriver.FindElementByXPath("/html/body/section[1]/div/div/ul/li/div[4]/a");
            btnUpload.Click();

            Thread.Sleep(TimeSpan.FromSeconds(3));

            var btnUpload2 = chromeDriver.FindElementByCssSelector("#initialUploadSection > div.initialUploadText > div");
            btnUpload2.Click();

            Thread.Sleep(TimeSpan.FromSeconds(3));
            
            AutoItX3 autoIT = new AutoItX3();
            autoIT.Send("F:\\Code\\" + "Hi.txt");

            Thread.Sleep(TimeSpan.FromSeconds(4));
            autoIT.Send("{ENTER}");

            Thread.Sleep(TimeSpan.FromSeconds(4));

            var up = chromeDriver.FindElementByXPath("//*[@id=\"processQueueSection\"]/div[1]/button");
            up.Click();

        }
    }
}
