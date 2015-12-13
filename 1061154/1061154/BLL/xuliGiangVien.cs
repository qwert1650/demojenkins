using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using _1061154.DAO;
using _1061154.DTO;
using System.Data;
using System.Windows.Forms;

namespace _1061154.BLL
{
    class xuliGiangVien
    {
        DataProvider kn = new DataProvider();
        public void insertGiangVien(GiangVien gv)
        {
            if (gv.ma == "" || gv.Hoten == "" || gv.Diachi == "" || gv.Dienthoai == "")
            {
                MessageBox.Show("Insert That Bai", "ERRO", MessageBoxButtons.OK);
            }
            else
            {
                SqlParameter[] paras = new SqlParameter[14];
                paras[0] = new SqlParameter("@masv", gv.ma);
                paras[1] = new SqlParameter("@Hoten", gv.Hoten);
                paras[2] = new SqlParameter("@Tendangnhap", gv.Tendangnhap);
                paras[3] = new SqlParameter("@Matkhau", gv.Matkhau);
                paras[4] = new SqlParameter("@Namsinh", gv.Namsinh);
                paras[5] = new SqlParameter("@Gioitinh", gv.Gioitinh);
                paras[6] = new SqlParameter("@Dantoc", gv.Dantoc);
                paras[7] = new SqlParameter("@maBoPhan", gv.maBoPhan);
                paras[8] = new SqlParameter("@Diachi", gv.Diachi);
                paras[9] = new SqlParameter("@Quyentruycap", gv.Quyentruycap);
                paras[10] = new SqlParameter("@Dienthoai", gv.Dienthoai);
                paras[11] = new SqlParameter("@maQuanLy", gv.maQuanLy);
                paras[12] = new SqlParameter("@maKhoa", gv.maKhoa);
                paras[13] = new SqlParameter("@TrangThai", gv.TrangThai);
                string procname = "insert_gv";
                kn.ExecuteNonquery(procname, paras);
            }
        }

        public DataTable loadgv()
        {
            return kn.ExecuteQuery("select ma,Hoten,Namsinh,Dantoc,maBoPhan,Diachi,Dienthoai,maKhoa,TrangThai from GiaoVien");
        }

        public void update_sv(GiangVien gv)
        {
            if (gv.ma == "" || gv.Hoten == "" || gv.Diachi == "" || gv.Dienthoai == "")
            {
                MessageBox.Show("Update That Bai", "ERRO", MessageBoxButtons.OK);
            }
            else
            {
                SqlParameter[] paras = new SqlParameter[9];
                paras[0] = new SqlParameter("@magv", gv.ma);
                paras[1] = new SqlParameter("@Hoten", gv.Hoten);
                paras[2] = new SqlParameter("@Namsinh", gv.Namsinh);
                paras[3] = new SqlParameter("@Gioitinh", gv.Gioitinh);
                paras[4] = new SqlParameter("@Dantoc", gv.Dantoc);
                paras[5] = new SqlParameter("@maBoPhan", gv.maBoPhan);
                paras[6] = new SqlParameter("@Diachi", gv.Diachi);
                paras[7] = new SqlParameter("@Dienthoai", gv.Dienthoai);
                paras[8] = new SqlParameter("@maKhoa", gv.maKhoa);
                string procname = "update_gv";
                kn.ExecuteNonquery(procname, paras);
            }
        }

        public void delete_gv(string masv)
        {
            if (masv == "")
            {
                MessageBox.Show("Delete That Bai", "ERRO", MessageBoxButtons.OK);
            }
            else
            {
                SqlParameter[] paras = new SqlParameter[1];
                paras[0] = new SqlParameter("@magv", masv);
                string procname = "delete_gv";
                kn.ExecuteNonquery(procname, paras);
            }
        }
        public void khoa_gv(string masv)
        {
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@magv", masv);
            string procname = "khoa_gv";
            kn.ExecuteNonquery(procname, paras);
        }
        public void mokhoa_gv(string masv)
        {
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@magv", masv);
            string procname = "mokhoa_gv";
            kn.ExecuteNonquery(procname, paras);
        }
    }
}
