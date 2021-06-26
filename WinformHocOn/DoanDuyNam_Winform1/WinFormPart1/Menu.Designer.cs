
namespace WinFormPart1
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lựaChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.form2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.forn3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lựaChọnToolStripMenuItem
            // 
            this.lựaChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form1ToolStripMenuItem1,
            this.form2ToolStripMenuItem1,
            this.forn3ToolStripMenuItem,
            this.form4ToolStripMenuItem});
            this.lựaChọnToolStripMenuItem.Name = "lựaChọnToolStripMenuItem";
            this.lựaChọnToolStripMenuItem.Size = new System.Drawing.Size(68, 19);
            this.lựaChọnToolStripMenuItem.Text = "Lựa chọn";
            // 
            // form1ToolStripMenuItem1
            // 
            this.form1ToolStripMenuItem1.Name = "form1ToolStripMenuItem1";
            this.form1ToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.form1ToolStripMenuItem1.Text = "Tính 2 số";
            this.form1ToolStripMenuItem1.Click += new System.EventHandler(this.form1ToolStripMenuItem1_Click);
            // 
            // form2ToolStripMenuItem1
            // 
            this.form2ToolStripMenuItem1.Name = "form2ToolStripMenuItem1";
            this.form2ToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.form2ToolStripMenuItem1.Text = "Tính BMI";
            this.form2ToolStripMenuItem1.Click += new System.EventHandler(this.form2ToolStripMenuItem1_Click);
            // 
            // forn3ToolStripMenuItem
            // 
            this.forn3ToolStripMenuItem.Name = "forn3ToolStripMenuItem";
            this.forn3ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.forn3ToolStripMenuItem.Text = "Test ListBox";
            this.forn3ToolStripMenuItem.Click += new System.EventHandler(this.forn3ToolStripMenuItem_Click);
            // 
            // form4ToolStripMenuItem
            // 
            this.form4ToolStripMenuItem.Name = "form4ToolStripMenuItem";
            this.form4ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.form4ToolStripMenuItem.Text = "QLSV";
            this.form4ToolStripMenuItem.Click += new System.EventHandler(this.form4ToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(70, 19);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lựaChọnToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(601, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đoàn Duy Nam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(64, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(858, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phiên bản này được tạo bởi Đoàn Duy Nam. Chúc các bạn có một ngày làm việc và học" +
    " tập hiệu quả.";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 145);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem lựaChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem forn3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form4ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}