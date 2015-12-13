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
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
        }
        HocSinh hs = new HocSinh();
        xuliHocSinh xlhs = new xuliHocSinh();
        public string maquanly;
        private void btnthem_Click(object sender, EventArgs e)
        {
            hs.ma = txtmssv.Text;
            hs.Hoten = txttensv.Text;
            hs.Namsinh = dtpngaysinh.Value.ToString();
            hs.maLop = cbxlop.Text;
            hs.maKhoa = cbxkhoa.Text;
            hs.Diachi = txtdiachi.Text;
            hs.Tendangnhap = txtmssv.Text;
            hs.Matkhau = dtpngaysinh.Value.ToString("dd/mm/yy");
            if (rbnnam.Checked)
                hs.Gioitinh = rbnnam.Text;
            else
                hs.Gioitinh = rbnnu.Text;
            hs.Dantoc = cbxdantoc.Text;
            hs.Quyentruycap = "1";
            hs.Dienthoai = txtdienthoai.Text;
            hs.TrangThai = "1";
            hs.maQuanLy = maquanly;
            xlhs.insertHocSinh(hs);
            dgvdanhsach.DataSource = xlhs.loadhs();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rbnnam.Checked=true;
            dgvdanhsach.DataSource= xlhs.loadhs();
            cbxlop.Items.Add("10CK1");
            cbxlop.Items.Add("10CK2");
            cbxlop.Items.Add("10CK3");
            cbxlop.Items.Add("10CK4");
            cbxlop.Items.Add("10CK5");
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
            cbxlop.SelectedIndex = 0;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            hs.ma = txtmssv.Text;
            hs.Hoten = txttensv.Text;
            hs.Namsinh = dtpngaysinh.Value.ToString();
            hs.maLop = cbxlop.Text;
            hs.maKhoa = cbxkhoa.Text;
            hs.Diachi = txtdiachi.Text;
            hs.Tendangnhap = txtmssv.Text;
            hs.Matkhau = dtpngaysinh.Value.ToString("dd/mm/yy");
            if (rbnnam.Checked)
                hs.Gioitinh = rbnnam.Text;
            else
                hs.Gioitinh = rbnnu.Text;
            hs.Dantoc = cbxdantoc.Text;
            hs.Quyentruycap = "1";
            hs.Dienthoai = txtdienthoai.Text;
            hs.TrangThai = "1";
            hs.maQuanLy = "1";
            xlhs.updateHocSinh(hs);
            dgvdanhsach.DataSource = xlhs.loadhs();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            xlhs.deleteHocSinh(txtmssv.Text);
            dgvdanhsach.DataSource = xlhs.loadhs();
        }

        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtmssv.Text = dgvdanhsach.SelectedCells[0].Value.ToString();
            }
            catch { }
        }

        private void btnkhoa_Click(object sender, EventArgs e)
        {
            xlhs.khoaHocSinh(txtmssv.Text);
            dgvdanhsach.DataSource = xlhs.loadhs();
        }

        private void btnmokhoa_Click(object sender, EventArgs e)
        {
            xlhs.mokhoaHocSinh(txtmssv.Text);
            dgvdanhsach.DataSource = xlhs.loadhs();
        }
    }
}
