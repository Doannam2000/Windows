
namespace Bai1_winform1
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMx = new System.Windows.Forms.CheckBox();
            this.cbM = new System.Windows.Forms.CheckBox();
            this.cbLamtoc = new System.Windows.Forms.CheckBox();
            this.cbTD = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad20 = new System.Windows.Forms.RadioButton();
            this.rad10 = new System.Windows.Forms.RadioButton();
            this.rad0 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTT = new System.Windows.Forms.Label();
            this.lblGG = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMx);
            this.groupBox1.Controls.Add(this.cbM);
            this.groupBox1.Controls.Add(this.cbLamtoc);
            this.groupBox1.Controls.Add(this.cbTD);
            this.groupBox1.Location = new System.Drawing.Point(24, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch Vụ";
            // 
            // cbMx
            // 
            this.cbMx.AutoSize = true;
            this.cbMx.Location = new System.Drawing.Point(36, 170);
            this.cbMx.Name = "cbMx";
            this.cbMx.Size = new System.Drawing.Size(151, 28);
            this.cbMx.TabIndex = 3;
            this.cbMx.Text = "Mát xa ( $200 )";
            this.cbMx.UseVisualStyleBackColor = true;
            this.cbMx.CheckedChanged += new System.EventHandler(this.cbMx_CheckedChanged);
            // 
            // cbM
            // 
            this.cbM.AutoSize = true;
            this.cbM.Location = new System.Drawing.Point(36, 126);
            this.cbM.Name = "cbM";
            this.cbM.Size = new System.Drawing.Size(176, 28);
            this.cbM.TabIndex = 2;
            this.cbM.Text = "Làm móng ( $35 )";
            this.cbM.UseVisualStyleBackColor = true;
            this.cbM.CheckedChanged += new System.EventHandler(this.cbM_CheckedChanged);
            // 
            // cbLamtoc
            // 
            this.cbLamtoc.AutoSize = true;
            this.cbLamtoc.Location = new System.Drawing.Point(36, 82);
            this.cbLamtoc.Name = "cbLamtoc";
            this.cbLamtoc.Size = new System.Drawing.Size(152, 28);
            this.cbLamtoc.TabIndex = 1;
            this.cbLamtoc.Text = "Làm tóc ( $60 )";
            this.cbLamtoc.UseVisualStyleBackColor = true;
            this.cbLamtoc.CheckedChanged += new System.EventHandler(this.cbLamtoc_CheckedChanged);
            // 
            // cbTD
            // 
            this.cbTD.AutoSize = true;
            this.cbTD.Location = new System.Drawing.Point(36, 38);
            this.cbTD.Name = "cbTD";
            this.cbTD.Size = new System.Drawing.Size(195, 28);
            this.cbTD.TabIndex = 0;
            this.cbTD.Text = "Trang Điểm ( $125 )";
            this.cbTD.UseVisualStyleBackColor = true;
            this.cbTD.CheckedChanged += new System.EventHandler(this.cbTD_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad20);
            this.groupBox2.Controls.Add(this.rad10);
            this.groupBox2.Controls.Add(this.rad0);
            this.groupBox2.Location = new System.Drawing.Point(458, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 211);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giảm giá";
            // 
            // rad20
            // 
            this.rad20.AutoSize = true;
            this.rad20.Location = new System.Drawing.Point(22, 168);
            this.rad20.Name = "rad20";
            this.rad20.Size = new System.Drawing.Size(63, 28);
            this.rad20.TabIndex = 6;
            this.rad20.TabStop = true;
            this.rad20.Text = "20%";
            this.rad20.UseVisualStyleBackColor = true;
            this.rad20.CheckedChanged += new System.EventHandler(this.rad20_CheckedChanged);
            // 
            // rad10
            // 
            this.rad10.AutoSize = true;
            this.rad10.Location = new System.Drawing.Point(22, 103);
            this.rad10.Name = "rad10";
            this.rad10.Size = new System.Drawing.Size(63, 28);
            this.rad10.TabIndex = 5;
            this.rad10.TabStop = true;
            this.rad10.Text = "10%";
            this.rad10.UseVisualStyleBackColor = true;
            this.rad10.CheckedChanged += new System.EventHandler(this.rad10_CheckedChanged);
            // 
            // rad0
            // 
            this.rad0.AutoSize = true;
            this.rad0.Location = new System.Drawing.Point(22, 38);
            this.rad0.Name = "rad0";
            this.rad0.Size = new System.Drawing.Size(53, 28);
            this.rad0.TabIndex = 4;
            this.rad0.TabStop = true;
            this.rad0.Text = "0%";
            this.rad0.UseVisualStyleBackColor = true;
            this.rad0.CheckedChanged += new System.EventHandler(this.rad0_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giảm giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng phải trả";
            // 
            // lblTT
            // 
            this.lblTT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTT.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTT.Location = new System.Drawing.Point(349, 255);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(127, 24);
            this.lblTT.TabIndex = 1;
            // 
            // lblGG
            // 
            this.lblGG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGG.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblGG.Location = new System.Drawing.Point(349, 292);
            this.lblGG.Name = "lblGG";
            this.lblGG.Size = new System.Drawing.Size(127, 24);
            this.lblGG.TabIndex = 1;
            // 
            // lblkq
            // 
            this.lblkq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblkq.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblkq.Location = new System.Drawing.Point(349, 330);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(127, 24);
            this.lblkq.TabIndex = 1;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(114, 390);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(104, 33);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(276, 390);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 33);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(438, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 33);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(662, 455);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thẩm mỹ viện";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbMx;
        private System.Windows.Forms.CheckBox cbM;
        private System.Windows.Forms.CheckBox cbLamtoc;
        private System.Windows.Forms.CheckBox cbTD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad20;
        private System.Windows.Forms.RadioButton rad10;
        private System.Windows.Forms.RadioButton rad0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Label lblGG;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCancel;
    }
}