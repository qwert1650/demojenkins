namespace _1061154
{
    partial class PhanQuyenQuanLy
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
            this.btnquanlysinhvien = new System.Windows.Forms.Button();
            this.btnquanlygiangvien = new System.Windows.Forms.Button();
            this.btnquanlymonhoc = new System.Windows.Forms.Button();
            this.btnphancong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnquanlysinhvien
            // 
            this.btnquanlysinhvien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnquanlysinhvien.Location = new System.Drawing.Point(12, 12);
            this.btnquanlysinhvien.Name = "btnquanlysinhvien";
            this.btnquanlysinhvien.Size = new System.Drawing.Size(141, 41);
            this.btnquanlysinhvien.TabIndex = 6;
            this.btnquanlysinhvien.Text = "Quan Ly Sinh Vien";
            this.btnquanlysinhvien.UseVisualStyleBackColor = false;
            this.btnquanlysinhvien.Click += new System.EventHandler(this.btnquanlysinhvien_Click);
            // 
            // btnquanlygiangvien
            // 
            this.btnquanlygiangvien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnquanlygiangvien.Location = new System.Drawing.Point(169, 12);
            this.btnquanlygiangvien.Name = "btnquanlygiangvien";
            this.btnquanlygiangvien.Size = new System.Drawing.Size(141, 41);
            this.btnquanlygiangvien.TabIndex = 5;
            this.btnquanlygiangvien.Text = "Quan Ly Giang Vien";
            this.btnquanlygiangvien.UseVisualStyleBackColor = false;
            this.btnquanlygiangvien.Click += new System.EventHandler(this.btnquanlygiangvien_Click);
            // 
            // btnquanlymonhoc
            // 
            this.btnquanlymonhoc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnquanlymonhoc.Location = new System.Drawing.Point(328, 12);
            this.btnquanlymonhoc.Name = "btnquanlymonhoc";
            this.btnquanlymonhoc.Size = new System.Drawing.Size(141, 41);
            this.btnquanlymonhoc.TabIndex = 7;
            this.btnquanlymonhoc.Text = "Quan Ly Mon Hoc";
            this.btnquanlymonhoc.UseVisualStyleBackColor = false;
            this.btnquanlymonhoc.Click += new System.EventHandler(this.btnquanlymonhoc_Click);
            // 
            // btnphancong
            // 
            this.btnphancong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnphancong.Location = new System.Drawing.Point(492, 12);
            this.btnphancong.Name = "btnphancong";
            this.btnphancong.Size = new System.Drawing.Size(141, 41);
            this.btnphancong.TabIndex = 8;
            this.btnphancong.Text = "Phan Cong Mon Hoc";
            this.btnphancong.UseVisualStyleBackColor = false;
            this.btnphancong.Click += new System.EventHandler(this.btnphancong_Click);
            // 
            // PhanQuyenQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(655, 64);
            this.Controls.Add(this.btnphancong);
            this.Controls.Add(this.btnquanlymonhoc);
            this.Controls.Add(this.btnquanlysinhvien);
            this.Controls.Add(this.btnquanlygiangvien);
            this.Name = "PhanQuyenQuanLy";
            this.Text = "PhanQuyenQuanLy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnquanlysinhvien;
        private System.Windows.Forms.Button btnquanlygiangvien;
        private System.Windows.Forms.Button btnquanlymonhoc;
        private System.Windows.Forms.Button btnphancong;
    }
}