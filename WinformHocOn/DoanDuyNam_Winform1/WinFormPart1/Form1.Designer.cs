
namespace WinFormPart1
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
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.RadioButton();
            this.btnTru = new System.Windows.Forms.RadioButton();
            this.btnNhan = new System.Windows.Forms.RadioButton();
            this.btnChia = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(117, 33);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(62, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Số thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(512, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(221, 33);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(260, 20);
            this.txtSo1.TabIndex = 1;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(221, 78);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(260, 20);
            this.txtSo2.TabIndex = 2;
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(221, 170);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(260, 20);
            this.txtKq.TabIndex = 7;
            // 
            // btnCong
            // 
            this.btnCong.AutoSize = true;
            this.btnCong.Location = new System.Drawing.Point(120, 125);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(50, 17);
            this.btnCong.TabIndex = 3;
            this.btnCong.TabStop = true;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.CheckedChanged += new System.EventHandler(this.btnCong_CheckedChanged);
            // 
            // btnTru
            // 
            this.btnTru.AutoSize = true;
            this.btnTru.Location = new System.Drawing.Point(221, 125);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(41, 17);
            this.btnTru.TabIndex = 4;
            this.btnTru.TabStop = true;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.CheckedChanged += new System.EventHandler(this.btnTru_CheckedChanged);
            // 
            // btnNhan
            // 
            this.btnNhan.AutoSize = true;
            this.btnNhan.Location = new System.Drawing.Point(328, 125);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(51, 17);
            this.btnNhan.TabIndex = 5;
            this.btnNhan.TabStop = true;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btnChia
            // 
            this.btnChia.AutoSize = true;
            this.btnChia.Location = new System.Drawing.Point(435, 125);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(46, 17);
            this.btnChia.TabIndex = 6;
            this.btnChia.TabStop = true;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.CheckedChanged += new System.EventHandler(this.btnChia_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 272);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.RadioButton btnCong;
        private System.Windows.Forms.RadioButton btnTru;
        private System.Windows.Forms.RadioButton btnNhan;
        private System.Windows.Forms.RadioButton btnChia;
    }
}

