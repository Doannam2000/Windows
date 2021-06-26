namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.coordinatesX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.coordinatesY = new System.Windows.Forms.NumericUpDown();
            this.Dclick = new System.Windows.Forms.CheckBox();
            this.Rightmouse = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.App = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.TextSend = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.textclick = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatesX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatesY)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open CMD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Command from CMD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tọa Độ X :";
            // 
            // coordinatesX
            // 
            this.coordinatesX.Location = new System.Drawing.Point(204, 24);
            this.coordinatesX.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.coordinatesX.Name = "coordinatesX";
            this.coordinatesX.Size = new System.Drawing.Size(120, 20);
            this.coordinatesX.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tọa Độ Y :";
            // 
            // coordinatesY
            // 
            this.coordinatesY.Location = new System.Drawing.Point(395, 26);
            this.coordinatesY.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.coordinatesY.Name = "coordinatesY";
            this.coordinatesY.Size = new System.Drawing.Size(120, 20);
            this.coordinatesY.TabIndex = 5;
            // 
            // Dclick
            // 
            this.Dclick.AutoSize = true;
            this.Dclick.Location = new System.Drawing.Point(521, 28);
            this.Dclick.Name = "Dclick";
            this.Dclick.Size = new System.Drawing.Size(86, 17);
            this.Dclick.TabIndex = 6;
            this.Dclick.Text = "Double Click";
            this.Dclick.UseVisualStyleBackColor = true;
            // 
            // Rightmouse
            // 
            this.Rightmouse.AutoSize = true;
            this.Rightmouse.Location = new System.Drawing.Point(613, 27);
            this.Rightmouse.Name = "Rightmouse";
            this.Rightmouse.Size = new System.Drawing.Size(86, 17);
            this.Rightmouse.TabIndex = 7;
            this.Rightmouse.Text = "Right Mouse";
            this.Rightmouse.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(705, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Click";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(613, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Click to coordinate app";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // App
            // 
            this.App.Location = new System.Drawing.Point(395, 53);
            this.App.Name = "App";
            this.App.Size = new System.Drawing.Size(194, 20);
            this.App.TabIndex = 10;
            this.App.Text = "Remote Desktop Connection";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(613, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "click control";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "ToolbarWindow32";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 95);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Enter";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(153, 95);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(171, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Ctrl + V";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "-------------------------------- Hi -------------------------------";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(249, 160);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "Send";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // TextSend
            // 
            this.TextSend.Location = new System.Drawing.Point(32, 163);
            this.TextSend.Name = "TextSend";
            this.TextSend.Size = new System.Drawing.Size(194, 20);
            this.TextSend.TabIndex = 17;
            this.TextSend.Text = "Text";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(477, 163);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 18;
            this.button9.Text = "Click Ngầm";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textclick
            // 
            this.textclick.Location = new System.Drawing.Point(333, 160);
            this.textclick.Name = "textclick";
            this.textclick.Size = new System.Drawing.Size(138, 20);
            this.textclick.TabIndex = 19;
            this.textclick.Text = "&Help";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(558, 163);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(117, 23);
            this.button10.TabIndex = 20;
            this.button10.Text = "Click ngầm tọa độ";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(683, 163);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(101, 23);
            this.button11.TabIndex = 21;
            this.button11.Text = "ENTER Ngầm";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(32, 207);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 22;
            this.button12.Text = "Tìm Ảnh";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(123, 207);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 23;
            this.button13.Text = "Click vô ảnh";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 506);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.textclick);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.TextSend);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.App);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Rightmouse);
            this.Controls.Add(this.Dclick);
            this.Controls.Add(this.coordinatesY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coordinatesX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.coordinatesX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatesY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown coordinatesX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown coordinatesY;
        private System.Windows.Forms.CheckBox Dclick;
        private System.Windows.Forms.CheckBox Rightmouse;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox App;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox TextSend;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textclick;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
    }
}

