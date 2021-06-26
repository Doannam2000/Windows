
namespace Bai1_winform1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radred = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radY = new System.Windows.Forms.RadioButton();
            this.radG = new System.Windows.Forms.RadioButton();
            this.checkhienthi = new System.Windows.Forms.CheckBox();
            this.picSmall = new System.Windows.Forms.PictureBox();
            this.picBig = new System.Windows.Forms.PictureBox();
            this.lblhienthi = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTB);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(583, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông Báo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radG);
            this.groupBox2.Controls.Add(this.radY);
            this.groupBox2.Controls.Add(this.radBlack);
            this.groupBox2.Controls.Add(this.radred);
            this.groupBox2.Location = new System.Drawing.Point(50, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Màu";
            // 
            // radred
            // 
            this.radred.AutoSize = true;
            this.radred.Location = new System.Drawing.Point(26, 44);
            this.radred.Name = "radred";
            this.radred.Size = new System.Drawing.Size(52, 28);
            this.radred.TabIndex = 3;
            this.radred.TabStop = true;
            this.radred.Text = "Đỏ";
            this.radred.UseVisualStyleBackColor = true;
            this.radred.CheckedChanged += new System.EventHandler(this.radred_CheckedChanged);
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Location = new System.Drawing.Point(26, 80);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(63, 28);
            this.radBlack.TabIndex = 4;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Đen";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // radY
            // 
            this.radY.AutoSize = true;
            this.radY.Location = new System.Drawing.Point(26, 116);
            this.radY.Name = "radY";
            this.radY.Size = new System.Drawing.Size(73, 28);
            this.radY.TabIndex = 5;
            this.radY.TabStop = true;
            this.radY.Text = "Vàng";
            this.radY.UseVisualStyleBackColor = true;
            this.radY.CheckedChanged += new System.EventHandler(this.radY_CheckedChanged);
            // 
            // radG
            // 
            this.radG.AutoSize = true;
            this.radG.Location = new System.Drawing.Point(26, 152);
            this.radG.Name = "radG";
            this.radG.Size = new System.Drawing.Size(74, 28);
            this.radG.TabIndex = 6;
            this.radG.TabStop = true;
            this.radG.Text = "Xanh";
            this.radG.UseVisualStyleBackColor = true;
            this.radG.CheckedChanged += new System.EventHandler(this.radG_CheckedChanged);
            // 
            // checkhienthi
            // 
            this.checkhienthi.AutoSize = true;
            this.checkhienthi.Location = new System.Drawing.Point(258, 191);
            this.checkhienthi.Name = "checkhienthi";
            this.checkhienthi.Size = new System.Drawing.Size(183, 28);
            this.checkhienthi.TabIndex = 7;
            this.checkhienthi.Text = "Hiển thị thông báo";
            this.checkhienthi.UseVisualStyleBackColor = true;
            this.checkhienthi.CheckedChanged += new System.EventHandler(this.checkhienthi_CheckedChanged);
            // 
            // picSmall
            // 
            this.picSmall.Image = ((System.Drawing.Image)(resources.GetObject("picSmall.Image")));
            this.picSmall.Location = new System.Drawing.Point(497, 195);
            this.picSmall.Name = "picSmall";
            this.picSmall.Size = new System.Drawing.Size(101, 104);
            this.picSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSmall.TabIndex = 3;
            this.picSmall.TabStop = false;
            this.picSmall.Click += new System.EventHandler(this.picSmall_Click);
            // 
            // picBig
            // 
            this.picBig.Image = ((System.Drawing.Image)(resources.GetObject("picBig.Image")));
            this.picBig.Location = new System.Drawing.Point(497, 186);
            this.picBig.Name = "picBig";
            this.picBig.Size = new System.Drawing.Size(136, 167);
            this.picBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBig.TabIndex = 4;
            this.picBig.TabStop = false;
            this.picBig.Click += new System.EventHandler(this.picBig_Click);
            // 
            // lblhienthi
            // 
            this.lblhienthi.AutoSize = true;
            this.lblhienthi.Location = new System.Drawing.Point(267, 231);
            this.lblhienthi.Name = "lblhienthi";
            this.lblhienthi.Size = new System.Drawing.Size(0, 24);
            this.lblhienthi.TabIndex = 5;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(164, 28);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(391, 29);
            this.txtTen.TabIndex = 1;
            // 
            // txtTB
            // 
            this.txtTB.Location = new System.Drawing.Point(164, 65);
            this.txtTB.Name = "txtTB";
            this.txtTB.Size = new System.Drawing.Size(391, 29);
            this.txtTB.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hiển Thị";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(512, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 36);
            this.button3.TabIndex = 10;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 465);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblhienthi);
            this.Controls.Add(this.picBig);
            this.Controls.Add(this.picSmall);
            this.Controls.Add(this.checkhienthi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messenge Formatter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTB;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radG;
        private System.Windows.Forms.RadioButton radY;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radred;
        private System.Windows.Forms.CheckBox checkhienthi;
        private System.Windows.Forms.PictureBox picSmall;
        private System.Windows.Forms.PictureBox picBig;
        private System.Windows.Forms.Label lblhienthi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

