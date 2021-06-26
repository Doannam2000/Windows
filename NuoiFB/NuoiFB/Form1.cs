using OpenQA.Selenium;
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

namespace NuoiFB
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void login(string uid, string passw,bool a)
        {
            ChromeOptions chrome = new ChromeOptions();
            
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;

            chrome.AddArgument("--window-size=160,700");
            chrome.AddArgument("--disable-notification");
            //chrome.AddArgument("--disable-images");
            string prof = "Profiles\\" + uid;
            if(!Directory.Exists("Profiles"))
            {
                Directory.CreateDirectory("Profiles");
            }
            else
            {
                chrome.AddArguments("user-data-dir="+ prof);
            }

            IWebDriver webDriver = new ChromeDriver(chromeDriverService, chrome, TimeSpan.FromSeconds(80)); 

            webDriver.Url = "https://facebook.com";
            webDriver.Navigate();

            try
            {
                var user = webDriver.FindElement(By.Id("email"));
                user.SendKeys(uid);
                Thread.Sleep(500);
                var passwords = webDriver.FindElement(By.Id("pass"));
                passwords.SendKeys(passw);
                Thread.Sleep(500);

                var login = webDriver.FindElement(By.Name("login"));
                login.Click();
                Thread.Sleep(15000);
            }
            catch(Exception ex)
            {

            }
            if(a)
            {
                string line = "";

                var cookie = webDriver.Manage().Cookies.AllCookies;

                for (int i = 0; i < cookie.Count; i++)
                {
                    line = cookie[i].ToString() + ";" + line;
                }
                string c_uid = Regex.Match(line, "c_user=[0-9]{5,}").ToString();
                string wd = Regex.Match(line, "wd=[0-9a-zA-Z_.%-]{0,}").ToString();
                string datr = Regex.Match(line, "datr=[a-zA-Z0-]{0,}").ToString();
                string fr = Regex.Match(line, "fr=[0-9a-zA-Z.-]{0,}").ToString();
                string xs = Regex.Match(line, "xs=[0-9a-z-A-Z%]{0,}").ToString();
                System.IO.File.WriteAllText("Profiles\\"+uid+"\\Cookie.txt", c_uid + ";" + wd + ";" + datr + ";" + fr + ";" + xs);
            }    
          
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Bạn có muốn lấy cookie không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            login("100017831418987", "khongbiet", x.Equals(DialogResult.Yes));

        }
    }
}
