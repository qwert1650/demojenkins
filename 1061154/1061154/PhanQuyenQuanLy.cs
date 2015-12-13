using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1061154
{
    public partial class PhanQuyenQuanLy : Form
    {
        public PhanQuyenQuanLy()
        {
            InitializeComponent();
        }
        public string loainguoidung;
        public string username;

        private void btnquanlysinhvien_Click(object sender, EventArgs e)
        {
            QuanLySinhVien frm = new QuanLySinhVien();
            frm.maquanly = this.username;
            frm.Show();
        }

        private void btnquanlygiangvien_Click(object sender, EventArgs e)
        {
            QuanLyGiangVien frm = new QuanLyGiangVien();
            frm.maquanly = this.username;
            frm.Show();
        }

        private void btnquanlymonhoc_Click(object sender, EventArgs e)
        {
            QuanLyMonHoc frm = new QuanLyMonHoc();
            frm.Show();
        }

        private void btnphancong_Click(object sender, EventArgs e)
        {
            PhanCongGiangVien frm = new PhanCongGiangVien();
            frm.maql = username;
            frm.loaiquanly = loainguoidung;
            frm.Show();
        }

    }
}
