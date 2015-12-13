namespace _1061154
{
    partial class btnthemdoan
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
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btndangky = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncapnhat.Location = new System.Drawing.Point(169, 13);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(141, 41);
            this.btncapnhat.TabIndex = 1;
            this.btncapnhat.Text = "Cap Nhat Thong Tin";
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btndangky
            // 
            this.btndangky.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndangky.Location = new System.Drawing.Point(12, 13);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(141, 41);
            this.btndangky.TabIndex = 2;
            this.btndangky.Text = "Dang Ky Phu Trach Mon";
            this.btndangky.UseVisualStyleBackColor = false;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(331, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Them Do An";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnthemdoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(483, 66);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.btncapnhat);
            this.Name = "btnthemdoan";
            this.Text = "PhanQuyenGiangVien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.Button button1;
    }
}