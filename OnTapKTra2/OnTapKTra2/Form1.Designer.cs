
namespace OnTapKTra2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmSinhViênToolStripMenuItem,
            this.sửaSinhViênToolStripMenuItem,
            this.xóaSinhViênToolStripMenuItem,
            this.xemSinhViênToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmSinhViênToolStripMenuItem
            // 
            this.thêmSinhViênToolStripMenuItem.Name = "thêmSinhViênToolStripMenuItem";
            this.thêmSinhViênToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.thêmSinhViênToolStripMenuItem.Text = "Thêm sinh viên";
            this.thêmSinhViênToolStripMenuItem.Click += new System.EventHandler(this.thêmSinhViênToolStripMenuItem_Click);
            // 
            // sửaSinhViênToolStripMenuItem
            // 
            this.sửaSinhViênToolStripMenuItem.Name = "sửaSinhViênToolStripMenuItem";
            this.sửaSinhViênToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.sửaSinhViênToolStripMenuItem.Text = "Sửa sinh viên";
            this.sửaSinhViênToolStripMenuItem.Click += new System.EventHandler(this.sửaSinhViênToolStripMenuItem_Click);
            // 
            // xóaSinhViênToolStripMenuItem
            // 
            this.xóaSinhViênToolStripMenuItem.Name = "xóaSinhViênToolStripMenuItem";
            this.xóaSinhViênToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.xóaSinhViênToolStripMenuItem.Text = "Xóa sinh viên";
            // 
            // xemSinhViênToolStripMenuItem
            // 
            this.xemSinhViênToolStripMenuItem.Name = "xemSinhViênToolStripMenuItem";
            this.xemSinhViênToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.xemSinhViênToolStripMenuItem.Text = "Xem sinh viên";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 175);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 250);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

