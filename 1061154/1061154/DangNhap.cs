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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        LoaiNguoiDung temp;
        xuliSuKien sk = new xuliSuKien();
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            TaiKhoan tk= new TaiKhoan();
            tk.TenDangNhap=txttendangnhap.Text;
            tk.MatKhau=txtmatkhau.Text;
            if (sk.DangNhap_sv(tk).username != "0" && sk.DangNhap_sv(tk).TrangThai=="1")
            {
                temp = sk.DangNhap_sv(tk);
                PhanQuyenSinhVien frm = new PhanQuyenSinhVien();
                frm.loainguoidung = temp.loainguoidung;
                frm.username = temp.username;
                frm.Show();
            }
            else if (sk.DangNhap_gv(tk).username != "0" && sk.DangNhap_gv(tk).TrangThai == "1")
            {
                temp = sk.DangNhap_gv(tk);
                btnthemdoan frm = new btnthemdoan();
                frm.loainguoidung = temp.loainguoidung;
                frm.username = temp.username;
                frm.Show();
            }
            else if (sk.DangNhap_ql(tk).username != "0" && sk.DangNhap_ql(tk).TrangThai == "1")
            {
                temp = sk.DangNhap_ql(tk);
                PhanQuyenQuanLy frm = new PhanQuyenQuanLy();
                frm.loainguoidung = temp.loainguoidung;
                frm.username = temp.username;
                frm.ShowDialog();
            }
            else
            {
               lblloi.Text = "Tai Khoan Cua Ban Khong Dung";
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
