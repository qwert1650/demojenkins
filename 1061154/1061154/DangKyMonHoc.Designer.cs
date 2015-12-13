namespace _1061154
{
    partial class DangKyMonHoc
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
            this.label5 = new System.Windows.Forms.Label();
            this.btndangky = new System.Windows.Forms.Button();
            this.btnhuydangky = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxtemonhoc = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdanhsach = new System.Windows.Forms.DataGridView();
            this.cbxKhoaHoc = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxlop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Khoa Hoc";
            // 
            // btndangky
            // 
            this.btndangky.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndangky.Location = new System.Drawing.Point(224, 150);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(102, 37);
            this.btndangky.TabIndex = 29;
            this.btndangky.Text = "Dang Ky";
            this.btndangky.UseVisualStyleBackColor = false;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // btnhuydangky
            // 
            this.btnhuydangky.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhuydangky.Location = new System.Drawing.Point(345, 150);
            this.btnhuydangky.Name = "btnhuydangky";
            this.btnhuydangky.Size = new System.Drawing.Size(102, 37);
            this.btnhuydangky.TabIndex = 28;
            this.btnhuydangky.Text = "Huy Dang Ky";
            this.btnhuydangky.UseVisualStyleBackColor = false;
            this.btnhuydangky.Click += new System.EventHandler(this.btnhuydangky_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(468, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 37);
            this.button2.TabIndex = 27;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cbxtemonhoc
            // 
            this.cbxtemonhoc.FormattingEnabled = true;
            this.cbxtemonhoc.Location = new System.Drawing.Point(108, 72);
            this.cbxtemonhoc.Name = "cbxtemonhoc";
            this.cbxtemonhoc.Size = new System.Drawing.Size(171, 21);
            this.cbxtemonhoc.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 48);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dang Ky Phu Trach Mon Hoc";
            // 
            // dgvdanhsach
            // 
            this.dgvdanhsach.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsach.Location = new System.Drawing.Point(6, 19);
            this.dgvdanhsach.Name = "dgvdanhsach";
            this.dgvdanhsach.Size = new System.Drawing.Size(543, 215);
            this.dgvdanhsach.TabIndex = 0;
            // 
            // cbxKhoaHoc
            // 
            this.cbxKhoaHoc.FormattingEnabled = true;
            this.cbxKhoaHoc.Location = new System.Drawing.Point(368, 109);
            this.cbxKhoaHoc.Name = "cbxKhoaHoc";
            this.cbxKhoaHoc.Size = new System.Drawing.Size(202, 21);
            this.cbxKhoaHoc.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvdanhsach);
            this.groupBox1.Location = new System.Drawing.Point(21, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 240);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sach Dang Ky";
            // 
            // cbxlop
            // 
            this.cbxlop.FormattingEnabled = true;
            this.cbxlop.Location = new System.Drawing.Point(368, 72);
            this.cbxlop.Name = "cbxlop";
            this.cbxlop.Size = new System.Drawing.Size(202, 21);
            this.cbxlop.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Lop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ten Moc";
            // 
            // DangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(599, 445);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.btnhuydangky);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbxtemonhoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxKhoaHoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxlop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "DangKyMonHoc";
            this.Text = "DangKyMonHoc";
            this.Load += new System.EventHandler(this.DangKyMonHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.Button btnhuydangky;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbxtemonhoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdanhsach;
        private System.Windows.Forms.ComboBox cbxKhoaHoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxlop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}