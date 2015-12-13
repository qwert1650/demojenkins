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
    public partial class PhanQuyenSinhVien : Form
    {
        public PhanQuyenSinhVien()
        {
            InitializeComponent();
        }
        public string loainguoidung;
        public string username;
        private void btndangky_Click(object sender, EventArgs e)
        {
            DangKyMonHoc frm = new DangKyMonHoc();
            frm.masv = username;
            frm.Show();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            CapNhatTaiKhoanSinhVien frm = new CapNhatTaiKhoanSinhVien();
            frm.username = username;
            frm.loainguoidung = loainguoidung;
            frm.Show();
        }
    }
}
