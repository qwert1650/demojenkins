namespace _1061154
{
    partial class CapNhatTaiKhoanGiaoVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cap Nhat Tai Khoan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 50);
            this.panel1.TabIndex = 77;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(86, 68);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(202, 20);
            this.txthoten.TabIndex = 84;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 85;
            this.label11.Text = "Ho Ten";
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(375, 106);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(185, 20);
            this.txtdienthoai.TabIndex = 83;
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnhuy.Location = new System.Drawing.Point(456, 153);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(104, 35);
            this.btnhuy.TabIndex = 81;
            this.btnhuy.Text = "Huy";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncapnhat.Location = new System.Drawing.Point(328, 153);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(112, 35);
            this.btncapnhat.TabIndex = 80;
            this.btncapnhat.Text = "Cap Nhat";
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 82;
            this.label10.Text = "Dien Thoai";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(375, 65);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(185, 20);
            this.txtdiachi.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "Dia Chi";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(86, 106);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(202, 20);
            this.txtmatkhau.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Mat Khau";
            // 
            // CapNhatTaiKhoanGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(588, 209);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label10);
            this.Name = "CapNhatTaiKhoanGiaoVien";
            this.Text = "Form6";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label label2;
    }
}