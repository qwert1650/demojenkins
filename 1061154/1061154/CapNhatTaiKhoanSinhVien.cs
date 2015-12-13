using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _1061154.BLL;
using _1061154.DTO;

namespace _1061154
{
    public partial class CapNhatTaiKhoanSinhVien : Form
    {
        public CapNhatTaiKhoanSinhVien()
        {
            InitializeComponent();
        }
        public string loainguoidung;
        public string username;
        xuliSuKien sk = new xuliSuKien();
        private void btncapnhat_Click(object sender, EventArgs e)
        {
            CapNhatTaiKhoan cn = new CapNhatTaiKhoan();
            cn.Hoten = txthoten.Text;
            cn.Matkhau = txtmatkhau.Text;
            cn.Diachi = txtdiachi.Text;
            cn.Dienthoai = txtdienthoai.Text;
            if (loainguoidung == "1")
            {
                int i = sk.CapNhat_sv(username, cn);
                if (i == 1)
                    MessageBox.Show("Cap nhat thanh cong", "Thong Bao", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Cap nhat khong thanh cong", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtdienthoai.Text = "";
            txtdiachi.Text = "";
            txthoten.Text = "";
            txtmatkhau.Text = "";
        }
    }
}
