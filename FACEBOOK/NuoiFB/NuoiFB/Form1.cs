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
        IWebDriver webDriver;
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFile;


        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                listView1.SelectedItems[i].BackColor = Color.LightBlue;
                string cookie = listView1.SelectedItems[i].SubItems[3].Text;
                Thread t = new Thread(() => {
                    logincookie(cookie);
                });
                t.Start();
            }

        }

        private void logincookie(string cookie)
        {

            ChromeOptions chrome = new ChromeOptions();
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            string uid = Regex.Match(cookie, "[0-9]{5,}").ToString();
            chrome.AddArgument("--window-size=160,700");
            chrome.AddArgument("--disable-notification");

            string prof = "Profiles\\" + uid;

            if (!Directory.Exists("Profiles"))
            {
                Directory.CreateDirectory("Profiles");
            }
            else
            {
                chrome.AddArguments("user-data-dir=" + prof);
            }
            try
            {
                webDriver = new ChromeDriver(chromeDriverService, chrome, TimeSpan.FromSeconds(80));
                webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5.0);
            }
            catch (Exception)
            {
                webDriver.Close();
                webDriver.Quit();
                webDriver = new ChromeDriver(chromeDriverService, chrome, TimeSpan.FromSeconds(80));
                webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5.0);
            }


            webDriver.Navigate().GoToUrl("https://facebook.com");
            Thread.Sleep(1000);


            string[] arrData = cookie.Split(';');

            for (int i = 0; i < arrData.Length; i++)
            {
                string item = arrData[i];
                try
                {
                    string[] pars = item.Split('=');
                    Cookie cooki = new Cookie(pars[0].Trim(), pars[1].Trim(), ".facebook.com", "/", new DateTime?(DateTime.Now.AddDays(10.0)));
                    webDriver.Manage().Cookies.AddCookie(cooki);
                }
                catch (Exception ex)
                {

                }
            }
            try
            {
                webDriver.Navigate().GoToUrl("https://facebook.com/DoanNamVBHP");
            }
            catch (Exception ex)
            {

            }
        
    }





        private void login(string uid, string passw, bool a)
        {
            ChromeOptions chrome = new ChromeOptions();

            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;

            chrome.AddArgument("--window-size=160,700");
            chrome.AddArgument("--disable-notification");
            //chrome.AddArgument("--disable-images");
            string prof = "Profiles\\" + uid;
            if (!Directory.Exists("Profiles"))
            {
                Directory.CreateDirectory("Profiles");
            }
            else
            {
                chrome.AddArguments("user-data-dir=" + prof);
            }
            

            if (webDriver != null)
            {
                webDriver.Close();
                webDriver.Quit();
            }

            try
            {
                webDriver = new ChromeDriver(chromeDriverService, chrome, TimeSpan.FromSeconds(80));

                webDriver.Url = "https://facebook.com";
                webDriver.Navigate();
            }catch(Exception ex)
            {

            }

            Thread.Sleep(5000);

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
                Thread.Sleep(5000);
            }
            catch (Exception ex)
            {

            }
            if (a)
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
                File.WriteAllText("Profiles\\" + uid + "\\Cookie.txt", c_uid + ";" + wd + ";" + datr + ";" + fr + ";" + xs);
            }

        }




        private void btnLogin_Click(object sender, EventArgs e)
        {

            DialogResult x = MessageBox.Show("Bạn có muốn lấy cookie không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                if (webDriver != null)
                {
                    webDriver.Close();
                    webDriver.Quit();
                }
                
                string id = listView1.SelectedItems[i].SubItems[1].Text;
                string pa = listView1.SelectedItems[i].SubItems[2].Text;
                if (id.Equals(""))
                {
                    id = listView1.SelectedItems[i].SubItems[7].Text;
                }    
                Thread t = new Thread(() => {
                    login(id, pa, x.Equals(DialogResult.Yes));
                });
                t.Start();
            }
        }





        private void Load()
        {
            listView1.Items.Clear();
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] x = File.ReadAllLines(openFileDialog.FileName);
                    for (int i = 0; i < x.Length; i++)
                    {
                        string user1 = Regex.Match(x[i], "[0-9]{12,}").ToString();
                        string fa = Regex.Match(x[i], "[A-Z0-9]{25,}").ToString();
                        string ns = Regex.Match(x[i], "[0-9 ]{0,3}-[0-9 ]{0,3}-[0-9]{4}").ToString();
                        string[] coo = x[i].Split('|');
                        string cooki = "";
                        string token = Regex.Match(x[i], "[a-zA-Z0-9]{50,}").ToString();
                        for (int j =0;j<coo.Length;j++)
                        {
                            if(coo[j].IndexOf("c_user")!=-1)
                            {
                                cooki = coo[j];
                            }    
                        }
                      
                        ListViewItem item = new ListViewItem(i.ToString());
                        item.SubItems.Add(user1.ToString());
                        try
                        {
                            
                            string[] pw = x[i].Split('|');
                            item.SubItems.Add(pw[1]);
                        }
                        catch (Exception)
                        {
                            item.SubItems.Add("");
                        }
                        item.SubItems.Add(cooki);
                        item.SubItems.Add(token);
                        item.SubItems.Add(fa);
                        item.SubItems.Add(ns);
                        try
                        {
                            string[] mail = x[i].Split('|');
                            foreach (string iem in mail)
                            {
                                if (iem.Contains("@"))
                                {
                                    item.SubItems.Add(iem);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            item.SubItems.Add("");
                        }
                        listView1.Items.Add(item);
                    }
                }
                catch(Exception ex)
                {

                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Load();
        }



        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BẢN QUYỀN THUỘC VỀ ĐOÀN DUY NAM", "HI", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }





        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string x = "";
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    x += listView1.Items[i].SubItems[1].Text + "|" + listView1.Items[i].SubItems[2].Text + listView1.Items[i].SubItems[3].Text + "|" + listView1.Items[i].SubItems[4].Text + "|" + listView1.Items[i].SubItems[5].Text + "|" + listView1.Items[i].SubItems[7].Text + "|" + listView1.Items[i].SubItems[6].Text + "\n";
                }
                if (openFileDialog != null)
                {
                    File.AppendAllText(openFileDialog.FileName,x);
                }
                else
                {
                    saveFile = new SaveFileDialog();
                    saveFile.Filter = "Text File (*.txt)|*.txt";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        
                            File.AppendAllText(saveFile.FileName,x);
                        
                    }
                }
                MessageBox.Show("Lưu thành công", "Thông Báo");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thể lưu file", "Thông Báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dia.Equals(DialogResult.Yes))
            {
                try
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    string filename = openFileDialog.FileName;
                    File.Delete(openFileDialog.FileName);
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        File.AppendAllText(filename, listView1.Items[i].SubItems[2].Text + "\n");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Phải lựa chọn một nick", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
              
            }
        }

   


        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(listView1.Items.Count.ToString());
            string user1 = Regex.Match(txtImport.Text, "[0-9]{12,}").ToString();
            string fa = Regex.Match(txtImport.Text, "[A-Z0-9]{25,}").ToString();
            string ns = Regex.Match(txtImport.Text, "[0-9 ]{0,3}-[0-9 ]{0,3}-[0-9]{4}").ToString();

            string[] coo = txtImport.Text.Split('|');
            string cooki = "";
            string token = Regex.Match(txtImport.Text, "[a-zA-Z0-9]{50,}").ToString();
            for (int j = 0; j < coo.Length; j++)
            {
                if (coo[j].IndexOf("c_user") != -1)
                {
                    cooki = coo[j];
                }
            }
            item.SubItems.Add(user1.ToString());
            try
            {
                string[] pw = txtImport.Text.Split('|');
                item.SubItems.Add(pw[1]);

            }
            catch (Exception)
            {

                item.SubItems.Add("");

            }
            item.SubItems.Add(cooki);
            item.SubItems.Add(token);
            item.SubItems.Add(fa);
            item.SubItems.Add(ns);
            try
            {
                string[] mail = txtImport.Text.Split('|');
                foreach (string iem in mail)
                {
                    if (iem.Contains("@"))
                    {
                        item.SubItems.Add(iem);
                    }
                }
            }
            catch (Exception)
            {
                item.SubItems.Add("");
            }
            listView1.Items.Add(item);
        }

        private void copyUIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string x = "";
            for(int i=0;i<listView1.SelectedItems.Count;i++)
            {
                x += listView1.SelectedItems[i].SubItems[1].Text +"\n";
            }
            Clipboard.SetText(x);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(webDriver!=null)
            {
                webDriver.Close();
                webDriver.Quit();
            }    
            Application.Exit();
        }




        // ---------------------------------- Chạy nuôi ----------------------------
        public void Nuoi(string cookie,string id,string passw)
        {
            ChromeOptions chrome = new ChromeOptions();

            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            string uid;
            if (!cookie.Equals(""))
                 uid = Regex.Match(cookie, "[0-9]{10,}").ToString();
            else
                uid = id;
            chrome.AddArgument("--window-size=160,700");
            chrome.AddArgument("--disable-notification");
            //chrome.AddArgument("--disable-images");
            string prof = "Profiles\\" + uid;

            if (!Directory.Exists("Profiles"))
            {
                Directory.CreateDirectory("Profiles");
            }
            else
            {
                chrome.AddArguments("user-data-dir=" + prof);
            }

            try
            {
                webDriver = new ChromeDriver(chromeDriverService, chrome, TimeSpan.FromSeconds(80));
                webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5.0);
            }
            catch (Exception)
            {
                webDriver.Close();
                webDriver.Quit();
   
                Thread.Sleep(3000);
                webDriver = new ChromeDriver(chromeDriverService, chrome, TimeSpan.FromSeconds(80));
                webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5.0);
            }


            webDriver.Navigate().GoToUrl("https://facebook.com");
            Thread.Sleep(5000);
            try
            {
                if(cookie.Equals(""))
                {
                    try
                    {
                        var user = webDriver.FindElement(By.Id("email"));
                        user.SendKeys(id);
                        Thread.Sleep(500);
                        var passwords = webDriver.FindElement(By.Id("pass"));
                        passwords.SendKeys(passw);
                        Thread.Sleep(500);
                        var login = webDriver.FindElement(By.Name("login"));
                        login.Click();
                        Thread.Sleep(15000);
                    }
                    catch (Exception ex)
                    {

                    }

                    string line = "";

                    var cookie1 = webDriver.Manage().Cookies.AllCookies;

                    for (int i = 0; i < cookie1.Count; i++)
                    {
                        line = cookie[i].ToString() + ";" + line;
                    }
                    string c_uid = Regex.Match(line, "c_user=[0-9]{5,}").ToString();
                    string wd = Regex.Match(line, "wd=[0-9a-zA-Z_.%-]{0,}").ToString();
                    string datr = Regex.Match(line, "datr=[a-zA-Z0-]{0,}").ToString();
                    string fr = Regex.Match(line, "fr=[0-9a-zA-Z.-]{0,}").ToString();
                    string xs = Regex.Match(line, "xs=[0-9a-z-A-Z%]{0,}").ToString();
                    File.WriteAllText("Profiles\\" + uid + "\\Cookie.txt", c_uid + ";" + wd + ";" + datr + ";" + fr + ";" + xs);
                    try
                    {
                        webDriver.Navigate().GoToUrl("https://facebook.com/DoanNamVBHP");
                    }
                    catch (Exception ex)
                    {

                    }
                }    
                else
                {
                    string[] arrData = cookie.Split(';');

                    for (int i = 0; i < arrData.Length; i++)
                    {
                        string item = arrData[i];
                        try
                        {
                            string[] pars = item.Split('=');
                            Cookie cooki = new Cookie(pars[0].Trim(), pars[1].Trim(), ".facebook.com", "/", new DateTime?(DateTime.Now.AddDays(10.0)));
                            webDriver.Manage().Cookies.AddCookie(cooki);
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    try
                    {
                        webDriver.Navigate().GoToUrl("https://facebook.com/DoanNamVBHP");
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            catch (Exception)
            {
                
            }
            if (cbKB.Checked)
            {

                try
                {
                    int kb = int.Parse(txtKB.Text);
                }
                catch (Exception)
                {
                    //https://mbasic.facebook.com/friends/center/requests/#friends_center_main đồng ý kb
                    //https://mbasic.facebook.com/friends kb gợi ý
                }
                /*webDriver.Navigate().GoToUrl("https://mbasic.facebook.com/friends/center/requests/#friends_center_main");
                Thread.Sleep(5000);
                try
                {
                    int i = 1;
                    while (i <= 3)
                    {
                        string path = "//*[@id=\"friends_center_main\"]/div[1]/div[1]/table/tbody/tr/td[2]/div[2]/a[" + i + "]";
                        var accept = webDriver.FindElement(By.XPath(path));
                        accept.Click();
                        i = i + 2;
                        Thread.Sleep(6000);
                    }
                }
                catch (Exception ex)
                {

                }*/

                webDriver.Navigate().GoToUrl("https://mbasic.facebook.com/friends");
                Thread.Sleep(5000);
                try
                {
                    int i = 0;
                    while (i < int.Parse(txtKB.Text))
                    {
                        string path = "//*[@id=\"friends_center_main\"]/div[2]/div[1]/table/tbody/tr/td[2]/div[2]/table/tbody/tr/td/div['"+i+"']/a";
                        var accept = webDriver.FindElement(By.XPath(path));
                        accept.Click();
                        i = i + 1;
                        Thread.Sleep(6000);
                    }
                }
                catch (Exception ex)
                {

                }

            }
            webDriver.Close();
            webDriver.Quit();
        }


        private void btnNuoi_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                if(webDriver != null)
                {
                    webDriver.Close();
                    webDriver.Quit();
                }    
                string cokk = listView1.SelectedItems[i].SubItems[3].Text;
                string id = listView1.SelectedItems[i].SubItems[1].Text;
                string pa = listView1.SelectedItems[i].SubItems[2].Text;
                if (id.Equals(""))
                    id = listView1.SelectedItems[i].SubItems[7].Text;
                MessageBox.Show(id);
                Thread t = new Thread(() => {Nuoi(cokk, id, pa);
                });
                t.Start();
            }
        }
    }
}
