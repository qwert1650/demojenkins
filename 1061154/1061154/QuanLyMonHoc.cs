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
    public partial class QuanLyMonHoc : Form
    {
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }
        DangMonHoc mh= new DangMonHoc();
        xuliSuKien sk = new xuliSuKien();
        private void btnthem_Click(object sender, EventArgs e)
        {
            mh.maMonHoc=txtmamh.Text;
            mh.maKhoa=cbxkhoa.Text;
            mh.temMonHoc = txttenmh.Text;
            sk.DangMonHoc(mh);
            dgvdanhsach.DataSource = sk.loadmonhoc();
        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            cbxkhoa.Items.Add("CNTT");
            cbxkhoa.Items.Add("VL");
            cbxkhoa.Items.Add("SH");
            cbxkhoa.Items.Add("DC");
            dgvdanhsach.DataSource= sk.loadmonhoc();
            cbxkhoa.SelectedIndex = 0;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            mh.maMonHoc = txtmamh.Text;
            mh.maKhoa = cbxkhoa.Text;
            mh.temMonHoc = txttenmh.Text;
            sk.UpdateMonHoc(mh);
            dgvdanhsach.DataSource = sk.loadmonhoc();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            mh.maMonHoc = txtmamh.Text;
            mh.maKhoa = cbxkhoa.Text;
            mh.temMonHoc = txttenmh.Text;
            sk.XoaMonHoc(mh);
            dgvdanhsach.DataSource = sk.loadmonhoc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text != "") 
                dgvdanhsach.DataSource = sk.loadgiaovien1(txttimkiem.Text);
            else if(txttimkiem.Text=="")
                 dgvdanhsach.DataSource = sk.loadgiaovien2();
            else
                MessageBox.Show("Loi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text != "")
                dgvdanhsach.DataSource = sk.loaddangkimonhoc1(txttimkiem.Text);
            else if (txttimkiem.Text =="")
                dgvdanhsach.DataSource = sk.loaddangkimonhoc2();
            else
                MessageBox.Show("Loi");
        }
    }
}
