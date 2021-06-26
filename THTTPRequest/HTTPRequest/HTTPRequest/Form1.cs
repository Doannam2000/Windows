using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace HTTPRequest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        // -----------------------------Get Data---------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            var html = GetData("https://howkteam.com");
            TestData(html);

        }

        public String GetData(String url)
        {
            HttpRequest httpRequest = new HttpRequest();
            string html = httpRequest.Get(url).ToString();
            return html;
        }
        public void TestData(String html)
        {
            File.WriteAllText("req.html", html);
            Process.Start("req.html");
        }




        //-----------------------Get Data with Cookies-------------------------




        void AddCookies(HttpRequest http ,String cookie)
        {
            var temp = cookie.Split(';');
            foreach(var item in temp)
            {
                var item2 = item.Split('=');
                if(item2.Count()>1)
                {
                    http.Cookies.Add(item2[0], item2[1]);
                }
            }
        }
        public String GetDataCookies(String url,string cookie = null)
        {
            HttpRequest httpRequest = new HttpRequest();
            httpRequest.Cookies = new CookieDictionary();
            if(!string.IsNullOrEmpty(cookie))
            {
                AddCookies(httpRequest, cookie);

            }
            string html = httpRequest.Get(url).ToString();
            return html;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string cookie = "_ga=GA1.2.1471176152.1597328799; __RequestVerificationToken=COKEH3RFoRiOp_7J7DrFsCIqy1iNFcXZs9DlWGURWelB-YRP_LmJLMUaT9CtcnubboBkJ-3duU9-oUU1xGQxXUc5c3thFO38D-2Ii9N5Bpw1; .AspNet.ApplicationCookie=vEnXxSP1r8QwbuUZSW19ipFBo6R_2g1ilgWGxQN1Z2FxJX-mCLTAsQlQ1AwHGFV0HoyTj2YgphPa_J4ZyvncuTHcVmL91QzB6z1fS5QCgsfqn5kKIy2-6g0DdNUnnvFRsYlpuFQOW2AzZBVVl33sIo5FYYd8inHmbcOjsuQEoDQRG7F_rabIKesgXCCn1OyXXMSAxl3tR9WcWCShQGeyzT-HMHe2nXbhfbTRNsDc8bRYMYQxX2WE0HkoWasrNe5TEnEjNZeys7G5gI3jpQY1sfPOShzwBJ6_T67XG2bwAmy_BqHAwJBJAheWu8CZTT2_6dssfDDNw0lwip-jSY08MJtF9SxLvCg5Xc49ZYZ8ptVIifqwUk9TsRg4v6EuSZMNAYuVrizBkaJf-tIcvKTtkv7BuE8CT1iof6IHRR2GcO-ovhZBPcwolg-hlJ_ZWsW_MofE32bx6LBoPKQiM1LK9g5gn2fCu1zH8f-YlMsl4rO52JVM22BxTml7sWl05NAN; _gid=GA1.2.718968908.1598610814; _gat=1";
            var html = GetDataCookies("https://howkteam.com",cookie);
            TestData(html);
        }




        //---------------------------- Post data---------------------------------------------


        private void button3_Click(object sender, EventArgs e)
        {
            HttpRequest http = new HttpRequest();


            string data = "";
            string html = http.Post("https://www.howkteam.vn/account/login?ReturnUrl=%2F",data, "text/html; charset=utf-8").ToString();
                    
        }

    }
}
