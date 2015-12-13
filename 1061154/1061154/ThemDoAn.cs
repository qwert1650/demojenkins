using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _1061154.DTO;
using _1061154.BLL ; 
namespace _1061154
{
    public partial class ThemDoAn : Form
    {
        public string username;
        public string loainguoidung;
        public ThemDoAn()
        {
            InitializeComponent();
        }
        DoAn  da= new DoAn() ;
        xulidoan xl = new xulidoan();
        private void btndangky_Click(object sender, EventArgs e)
        {
            da.maMonHoc = cbxmamonhoc.Text;
            da.maDoAn = txtmadoan.Text;
            da.TenDoAn = txtmadoan.Text;
            da.dealine = dtpdeadline.Value.ToString();
            da.ChiTiet = txtchitiet.Text;
            da.SoThanhVien = txtsosinhvien.Text;
            da.maGV = username;
            xl.ThemDoAn(da);
            dgvdanhsach.DataSource = xl.loaddoan(username);
        }

        private void ThemDoAn_Load(object sender, EventArgs e)
        {
            dgvdanhsach.DataSource = xl.loaddoan(username);
        }

        private void btnhuydangky_Click(object sender, EventArgs e)
        {
            da.maMonHoc = cbxmamonhoc.Text;
            da.maDoAn = txtmadoan.Text;
            da.maGV = username;
            xl.HuyDoAn(da);
            dgvdanhsach.DataSource = xl.loaddoan(username);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            da.maMonHoc = cbxmamonhoc.Text;
            da.maDoAn = txtmadoan.Text;
            da.TenDoAn = txtmadoan.Text;
            da.dealine = dtpdeadline.Value.ToString();
            da.ChiTiet = txtchitiet.Text;
            da.SoThanhVien = txtsosinhvien.Text;
            da.maGV = username;
            xl.CapNhatDoAn(da);
            dgvdanhsach.DataSource = xl.loaddoan(username);
        }
    }
}
