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
    public partial class PhanCongGiangVien : Form
    {
        public PhanCongGiangVien()
        {
            InitializeComponent();
        }
        string temp;
        public string maql;
        public string loaiquanly;
        public string masv;
        MonHoc dk = new MonHoc();
        xuliSuKien sk = new xuliSuKien();
        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                 temp=dgvdanhsach.SelectedRows[0].Cells[0].Value.ToString();
                 dgvphancong.DataSource = sk.loadphanconggiaovien(temp);
            }
            catch{}
        }

        private void PhanCongGiangVien_Load(object sender, EventArgs e)
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
            cbxlop.SelectedIndex = 0;
            cbxtemonhoc.SelectedIndex = 0;
            cbxKhoaHoc.SelectedIndex = 0;
            dgvdanhsach.DataSource =sk.loadphancong();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            dk.ma = txtmagv.Text;
            dk.malop = cbxlop.Text;
            if (cbxtemonhoc.Text == "Hoa Hoc")
                dk.maMonHoc = "H001";
            else if (cbxtemonhoc.Text == "Toan Roi Rac")
                dk.maMonHoc = "TH01";
            else
                dk.maMonHoc = "VL001";
            dk.maKhoaHoc = cbxKhoaHoc.Text;
            sk.PhanCongPhuTrachMon(dk);
            dgvdanhsach.DataSource = sk.loadphancong();
            dgvphancong.DataSource = sk.loadphanconggiaovien(temp);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
             dk.ma = txtmagv.Text;
            dk.malop = cbxlop.Text;
            if (cbxtemonhoc.Text == "Hoa Hoc")
                dk.maMonHoc = "H001";
            else if (cbxtemonhoc.Text == "Toan Roi Rac")
                dk.maMonHoc = "TH01";
            else
                dk.maMonHoc = "VL001";
            dk.maKhoaHoc = cbxKhoaHoc.Text;
            sk.CapNhatPhanCongMon(dk);
            dgvdanhsach.DataSource = sk.loadphancong();
            dgvphancong.DataSource = sk.loadphanconggiaovien(temp);
        }

        private void btnhuydangky_Click(object sender, EventArgs e)
        {
            dk.ma = txtmagv.Text;
            dk.malop = cbxlop.Text;
            if (cbxtemonhoc.Text == "Hoa Hoc")
                dk.maMonHoc = "H001";
            else if (cbxtemonhoc.Text == "Toan Roi Rac")
                dk.maMonHoc = "TH01";
            else
                dk.maMonHoc = "VL001";
            dk.maKhoaHoc = cbxKhoaHoc.Text;
            sk.HuyPhanCongMon(dk);
            dgvdanhsach.DataSource = sk.loadphancong();
            dgvphancong.DataSource = sk.loadphanconggiaovien(temp);
        }
    }
}
