
namespace StudentsScoreManagement
{
    partial class SVMon
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
            this.lblWel = new System.Windows.Forms.Label();
            this.dataSV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWel
            // 
            this.lblWel.AutoSize = true;
            this.lblWel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWel.Location = new System.Drawing.Point(422, 27);
            this.lblWel.Name = "lblWel";
            this.lblWel.Size = new System.Drawing.Size(0, 25);
            this.lblWel.TabIndex = 0;
            // 
            // dataSV
            // 
            this.dataSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataSV.Location = new System.Drawing.Point(0, 101);
            this.dataSV.Name = "dataSV";
            this.dataSV.Size = new System.Drawing.Size(1002, 470);
            this.dataSV.TabIndex = 1;
            this.dataSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSV_CellClick);
            // 
            // SVMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 571);
            this.Controls.Add(this.dataSV);
            this.Controls.Add(this.lblWel);
            this.Name = "SVMon";
            this.Text = "SVMon";
            this.Load += new System.EventHandler(this.SVMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWel;
        private System.Windows.Forms.DataGridView dataSV;
    }
}