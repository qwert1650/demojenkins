using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _1061154.DTO;
using _1061154.BLL;

namespace _1061154
{
    public partial class QuanLyGiangVien : Form
    {
        public QuanLyGiangVien()
        {
            InitializeComponent();
        }
        GiangVien gv = new GiangVien();
        xuliGiangVien xlgv = new xuliGiangVien();
        public string maquanly;
        private void btnthem_Click(object sender, EventArgs e)
        {
            gv.ma = txtmssv.Text;
            gv.Hoten = txttensv.Text;
            gv.Namsinh = dtpngaysinh.Value.ToString();
            gv.maKhoa = cbxkhoa.Text;
            gv.Diachi = txtdiachi.Text;
            gv.Tendangnhap = txtmssv.Text;
            gv.Matkhau = dtpngaysinh.Value.ToString("dd/mm/yy");
            if (rbnnam.Checked)
                gv.Gioitinh = rbnnam.Text;
            else
                gv.Gioitinh = rbnnu.Text;
            gv.Dantoc = cbxdantoc.Text;
            gv.Quyentruycap = "2";
            gv.Dienthoai = txtdienthoai.Text;
            gv.TrangThai = "1";
            gv.maQuanLy = maquanly;
            gv.maBoPhan = cbxbophan.Text;
            xlgv.insertGiangVien(gv);
            dgvdanhsach.DataSource = xlgv.loadgv();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            rbnnam.Checked = true;
            dgvdanhsach.DataSource = xlgv.loadgv();
            cbxbophan.Items.Add("Giang Vien");
            cbxkhoa.Items.Add("CNTT");
            cbxkhoa.Items.Add("VL");
            cbxkhoa.Items.Add("SH");
            cbxkhoa.Items.Add("DC");
            cbxdantoc.Items.Add("Kinh");
            cbxdantoc.Items.Add("Hoa");
            cbxdantoc.Items.Add("Thai");
            cbxdantoc.Items.Add("Kho-Me");
            cbxdantoc.SelectedIndex = 0;
            cbxkhoa.SelectedIndex = 0;
            cbxbophan.SelectedIndex = 0;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            gv.ma = txtmssv.Text;
            gv.Hoten = txttensv.Text;
            gv.Namsinh = dtpngaysinh.Value.ToString();
            gv.maKhoa = cbxkhoa.Text;
            gv.Diachi = txtdiachi.Text;
            gv.Tendangnhap = txtmssv.Text;
            gv.Matkhau = dtpngaysinh.Value.ToString("dd/mm/yy");
            if (rbnnam.Checked)
                gv.Gioitinh = rbnnam.Text;
            else
                gv.Gioitinh = rbnnu.Text;
            gv.Dantoc = cbxdantoc.Text;
            gv.Quyentruycap = "1";
            gv.Dienthoai = txtdienthoai.Text;
            gv.TrangThai = "1";
            gv.maQuanLy = "2";
            gv.maBoPhan = cbxbophan.Text;
            xlgv.update_sv(gv);
            dgvdanhsach.DataSource = xlgv.loadgv();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            xlgv.delete_gv(txtmssv.Text);
            dgvdanhsach.DataSource = xlgv.loadgv();
        }

        private void btnkhoa_Click(object sender, EventArgs e)
        {
            xlgv.khoa_gv(txtmssv.Text);
            dgvdanhsach.DataSource = xlgv.loadgv();
        }

        private void btnmokhoa_Click(object sender, EventArgs e)
        {
            xlgv.mokhoa_gv(txtmssv.Text);
            dgvdanhsach.DataSource = xlgv.loadgv();
        }
    }
}
