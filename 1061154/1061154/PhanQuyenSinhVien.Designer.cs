namespace _1061154
{
    partial class PhanQuyenSinhVien
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
            this.btndangky = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndangky
            // 
            this.btndangky.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndangky.Location = new System.Drawing.Point(12, 12);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(141, 41);
            this.btndangky.TabIndex = 4;
            this.btndangky.Text = "Dang Ky Mon Hoc";
            this.btndangky.UseVisualStyleBackColor = false;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncapnhat.Location = new System.Drawing.Point(169, 12);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(141, 41);
            this.btncapnhat.TabIndex = 3;
            this.btncapnhat.Text = "Cap Nhat Thong Tin";
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // PhanQuyenSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(323, 65);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.btncapnhat);
            this.Name = "PhanQuyenSinhVien";
            this.Text = "PhanQuyenSinhVien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.Button btncapnhat;
    }
}