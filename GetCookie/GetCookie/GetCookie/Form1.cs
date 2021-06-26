using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;


namespace GetCookie
{
    public partial class Form1 : Form
    {

       IWebDriver chrome;
        public Form1()
        {
            InitializeComponent();
        }
        public void login()
        {

            ChromeOptions chromeOptions = new ChromeOptions();
            String ProfileFolderPath = "Profile";
            if (chrome != null)
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
            }

            chromeOptions.AddArguments("--window-size=180,600");
            chromeOptions.AddArguments("--disable-notifications");
            chrome = new ChromeDriver(chromeOptions);
            chrome.Url = "https://www.facebook.com";

            Thread.Sleep(TimeSpan.FromSeconds(10));
         
            string line = "";
            for(int i=0;i<10;i++)
            {
                
                try {
                    var cookies = chrome.Manage().Cookies.AllCookies;
                    line = cookies[i].ToString() + ";" + line;
                }
                catch(Exception ex)
                {

                }
            }

            string c_user = Regex.Match(line, "c_user=[0-9]{0,}").ToString();
            string wd = Regex.Match(line, "wd=[0-9a-zA-Z]{0,}").ToString();
            string datr = Regex.Match(line, "datr=[0-9A-Za-z_-]{0,}").ToString();
            string sb = Regex.Match(line, "sb=[0-9a-zA-Z]{0,}").ToString();
            string fr = Regex.Match(line, "fr=[a-zA-Z0-9.]{0,}").ToString();
            string xs = Regex.Match(line, "xs=[0-9a-zA-Z%_-]{0,}").ToString();
            string cook;

            using (StreamWriter sw = new StreamWriter("Cookie.txt",true))
            {
                cook = c_user + ";" + datr + ";" + sb + ";" + fr + ";" + xs + ";" + wd;
                sw.WriteLine(cook.ToString());
                sw.Close();
            }    

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }





        // --------------- Load cookies len listview ---------------
        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string[] line= File.ReadAllLines("Cookie.txt");
            for(int i = 0;i<line.Length;i++)
            {
                ListViewItem item = new ListViewItem(line[i]);
                var a = Regex.Match(line[i], "c_user=[0-9]{0,}").ToString();
                var b = Regex.Match(a, "[0-9]{0,}$").ToString();
                item.SubItems.Add(b);

                listView1.Items.Add(item);
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
