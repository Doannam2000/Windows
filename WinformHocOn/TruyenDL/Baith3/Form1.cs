using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baith3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFile;
        private FontDialog fontDialog;
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            this.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog.FileName);
                this.Text = openFileDialog.FileName;
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFile = new SaveFileDialog();
            saveFile.Filter = "Text File (*.txt)|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName,textBox1.Text);
                this.Text = saveFile.FileName;    
            }                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            this.Text = "New Text";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(!this.Text.Equals("New Text"))
            {
                File.WriteAllText(openFileDialog.FileName, textBox1.Text);
            }    
            else
            {
                saveFile = new SaveFileDialog();
                saveFile.Filter = "Text File (*.txt)|*.txt";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFile.FileName, textBox1.Text);
                    this.Text = saveFile.FileName;
                }
            }    
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font;
            }    
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDia = new ColorDialog();
            if (colorDia.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDia.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f= new Form2();
            f.ShowDialog();
        }
    }
}
