using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool press = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtKQ.Text = "";
            lblHienThi.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                
            Button b = (Button)sender;
            if(b.Text.Equals("."))
            {
                if(!lblHienThi.Text.Contains(".") || lblHienThi.Text.Equals("0"))
                {
                    lblHienThi.Text += b.Text;
                }    
            }
            else
            {

                if (lblHienThi.Text == "0")
                    lblHienThi.Text = "";    
                lblHienThi.Text += b.Text;
            }

            press = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (press)
            {
                if (lblHienThi.Text == "" && txtKQ.Text !="")
                {
                    lblHienThi.Text = txtKQ.Text + b.Text;
                    press = false;
                   

                }
                else
                {
                    lblHienThi.Text += b.Text;
                    press = false;
                }
            }

            else
            {

                try
                {
                    string chec = lblHienThi.Text;
                    chec = chec.Replace(chec[chec.Length - 1].ToString(), b.Text.ToString());
                    lblHienThi.Text = chec;
                }
                catch (Exception ex)
                {

                }

            }
           
        }

        private void KQ()
        {
            
            List<double> x = new List<double>();
            List<string> dau = new List<string>();
            double kq = 0;
            int bien = Regex.Matches(lblHienThi.Text, "[0-9]{0,}").Count;
            for(int i = 0;i<bien;i++)
            {
                if(!Regex.Matches(lblHienThi.Text, "[0-9]{0,}")[i].ToString().Equals(""))
                {
                    x.Add(double.Parse(Regex.Matches(lblHienThi.Text, "[0-9]{0,}")[i].ToString()));
                }    
            }
            bien = Regex.Matches(lblHienThi.Text, "[+/*-]{1}").Count;
            for (int i = 0; i < bien; i++)
            {
                if (!Regex.Matches(lblHienThi.Text, "[+/*-]{1}")[i].ToString().Equals(""))
                {
                    dau.Add(Regex.Matches(lblHienThi.Text, "[+/*-]{1}")[i].ToString());
                }
            }
            if(dau.Count==0)
            {
                txtKQ.Text = lblHienThi.Text;
                lblHienThi.Text = ""; 
            }
            else
            {
                string m = "";
                for (int i = 0; i < dau.Count; i++)
                {
                    if (dau[i].Equals("*"))
                    {
                        kq = x[i] * x[i + 1];
                        x.RemoveAt(i + 1);
                        x[i] = kq;
                        dau.RemoveAt(i);
                        i--;
                    }
                    else if (dau[i].Equals("/"))
                    {
                        kq = x[i] / x[i + 1];
                        x.RemoveAt(i + 1);
                        x[i] = kq;
                        dau.RemoveAt(i);
                        i--;
                    }
                }
                if (dau.Count == 0)
                {
                    txtKQ.Text = x[0].ToString();
                }
                else
                {
                    kq = 0;
                    for (int i = 0; i < dau.Count; i++)
                    {
                        if (dau[i].Equals("+"))
                        {
                            kq = x[i] + x[i + 1];
                        }
                        if (dau[i].Equals("-"))
                        {
                            kq = x[i] - x[i + 1];
                        }
                    }
                    txtKQ.Text = kq.ToString();
                    lblHienThi.Text = "";
                }
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if(lblHienThi.Text!="")
            {
                KQ();
                lblHienThi.Text = "";
            }
        }
        int vt;
        private void timer1_Tick(object sender, EventArgs e)
        {
            vt = nam.Location.X;
            vt--;
            nam.Location = new Point(vt, nam.Location.Y);
            if(vt==-437)
            {
                Form1 f = new Form1();
                vt = f.Width;
                nam.Location = new Point(vt, nam.Location.Y);
            }    
        }
    }
}
