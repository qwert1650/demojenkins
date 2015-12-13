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
    public partial class DangKyMonHoc : Form
    {
        public DangKyMonHoc()
        {
            InitializeComponent();
        }
        public string masv;
        MonHoc dk = new MonHoc();
        xuliSuKien sk = new xuliSuKien();
        private void btndangky_Click(object sender, EventArgs e)
        {
            dk.ma = masv;
            dk.malop = cbxlop.Text;
            if (cbxtemonhoc.Text == "Hoa Hoc")
                dk.maMonHoc = "H001";
            else if (cbxtemonhoc.Text == "Toan Roi Rac")
                dk.maMonHoc = "TH01";
            else
                dk.maMonHoc = "VL001";
            dk.maKhoaHoc = cbxKhoaHoc.Text;
            sk.DangKyMonHoc(dk);
            dgvdanhsach.DataSource = sk.loadsinhvien(masv);
        }

        private void DangKyMonHoc_Load(object sender, EventArgs e)
        {
            cbxlop.Items.Add("10CK1");
            cbxlop.Items.Add("10CK2");
            cbxlop.Items.Add("10CK3");
            cbxlop.Items.Add("10CK4");
            cbxlop.Items.Add("10CK5");
            cbxtemonhoc.Items.Add("Hoa Hoc");
            cbxtemonhoc.Items.Add("Toan Roi Rac");
            cbxtemonhoc.Items.Add("Vat Ly");
            cbxKhoaHoc.Items.Add("2011-2012");
            dgvdanhsach.DataSource = sk.loadsinhvien(masv);
            cbxlop.SelectedIndex = 0;
            cbxtemonhoc.SelectedIndex = 0;
            cbxKhoaHoc.SelectedIndex = 0;
        }

        private void btnhuydangky_Click(object sender, EventArgs e)
        {
            dk.ma = masv;
            dk.malop = cbxlop.Text;
            if (cbxtemonhoc.Text == "Hoa Hoc")
                dk.maMonHoc = "H001";
            else if (cbxtemonhoc.Text == "Toan Roi Rac")
                dk.maMonHoc = "TH01";
            else
                dk.maMonHoc = "VL001";
            dk.maKhoaHoc = cbxKhoaHoc.Text;
            sk.HuyDangKyMonHoc(dk);
            dgvdanhsach.DataSource = sk.loadsinhvien(masv);
        }
    }
}
