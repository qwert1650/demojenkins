using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using _1061154.DTO;
using _1061154.DAO;

namespace _1061154.BLL
{
    class xuliHocSinh
    {
        DataProvider kn = new DataProvider();
        public void insertHocSinh(HocSinh hs)
        {
            if (hs.ma == "" || hs.Hoten == "" || hs.Diachi == "" || hs.Dienthoai == "")
            {
                MessageBox.Show("Insert That Bai", "ERRO", MessageBoxButtons.OK);
            }
            else
            {
                SqlParameter[] paras = new SqlParameter[14];
                paras[0] = new SqlParameter("@masv", hs.ma);
                paras[1] = new SqlParameter("@Hoten", hs.Hoten);
                paras[2] = new SqlParameter("@Tendangnhap", hs.Tendangnhap);
                paras[3] = new SqlParameter("@Matkhau", hs.Matkhau);
                paras[4] = new SqlParameter("@Namsinh", hs.Namsinh);
                paras[5] = new SqlParameter("@Gioitinh", hs.Gioitinh);
                paras[6] = new SqlParameter("@Dantoc", hs.Dantoc);
                paras[7] = new SqlParameter("@maLop", hs.maLop);
                paras[8] = new SqlParameter("@Diachi", hs.Diachi);
                paras[9] = new SqlParameter("@Quyentruycap", hs.Quyentruycap);
                paras[10] = new SqlParameter("@Dienthoai", hs.Dienthoai);
                paras[11] = new SqlParameter("@maQuanLy", hs.maQuanLy);
                paras[12] = new SqlParameter("@maKhoa", hs.maKhoa);
                paras[13] = new SqlParameter("@TrangThai", hs.TrangThai);
                string procname = "insert_sv";
                kn.ExecuteNonquery(procname, paras);
            }
        }
        public DataTable loadhs()
        {
            return kn.ExecuteQuery("select ma,Hoten,Namsinh,Dantoc,maLop,Diachi,Dienthoai,maKhoa,TrangThai from SinhVien");
        }
        public void updateHocSinh(HocSinh hs)
        {
            if (hs.ma == "" || hs.Hoten == "" || hs.Diachi == "" || hs.Dienthoai == "")
            {
                MessageBox.Show("Update That Bai", "ERRO", MessageBoxButtons.OK);
            }
            else
            {
                SqlParameter[] paras = new SqlParameter[9];
                paras[0] = new SqlParameter("@masv", hs.ma);
                paras[1] = new SqlParameter("@Hoten", hs.Hoten);
                paras[2] = new SqlParameter("@Namsinh", hs.Namsinh);
                paras[3] = new SqlParameter("@Gioitinh", hs.Gioitinh);
                paras[4] = new SqlParameter("@Dantoc", hs.Dantoc);
                paras[5] = new SqlParameter("@maLop", hs.maLop);
                paras[6] = new SqlParameter("@Diachi", hs.Diachi);
                paras[7] = new SqlParameter("@Dienthoai", hs.Dienthoai);
                paras[8] = new SqlParameter("@maKhoa", hs.maKhoa);
                string procname = "update_sv";
                kn.ExecuteNonquery(procname, paras);
            }
        }
        public void deleteHocSinh(string masv)
        {
            if (masv == "")
            {
                MessageBox.Show("Delete That Bai", "ERRO", MessageBoxButtons.OK);
            }
            else
            {
                SqlParameter[] paras = new SqlParameter[1];
                paras[0] = new SqlParameter("@masv", masv);
                string procname = "deleteHocSinh";
                kn.ExecuteNonquery(procname, paras);
            }
        }
        public void khoaHocSinh(string masv)
        {
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@masv", masv);
            string procname = "khoa_sv";
            kn.ExecuteNonquery(procname, paras);
        }
        public void mokhoaHocSinh(string masv)
        {
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@masv", masv);
            string procname = "mokhoa_sv";
            kn.ExecuteNonquery(procname, paras);
        }
    }
}
