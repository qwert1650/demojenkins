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
    public partial class btnthemdoan : Form
    {
        public btnthemdoan()
        {
            InitializeComponent();
        }
        public string loainguoidung;
        public string username;

        private void btndangky_Click(object sender, EventArgs e)
        {
            DangKyPhuTrach frm = new DangKyPhuTrach();
            frm.magv = username;
            frm.Show();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            CapNhatTaiKhoanGiaoVien frm = new CapNhatTaiKhoanGiaoVien();
            frm.username = username;
            frm.loainguoidung = loainguoidung;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemDoAn  frm = new ThemDoAn ();
            frm.username = username;
            frm.loainguoidung = loainguoidung;
            frm.Show();
        }
    }
}
