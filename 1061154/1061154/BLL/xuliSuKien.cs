using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _1061154.DAO;
using _1061154.DTO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace _1061154.BLL
{
    class xuliSuKien
    {
        public LoaiNguoiDung DangNhap_sv(TaiKhoan tk)
        {
            if (tk.TenDangNhap == " " || tk.MatKhau == " ")
            {
                return null;
            }
            else
            {
                string sql = "select TenDangNhap,QuyenTruyCap,TrangThai from SinhVien where TenDangNhap='" + tk.TenDangNhap + "' and MatKhau='" + tk.MatKhau + "'";
                DataProvider kn = new DataProvider();
                return kn.ExecuteReader(sql);
            }
        }
        public LoaiNguoiDung DangNhap_gv(TaiKhoan tk)
        {
            if (tk.TenDangNhap == " " || tk.MatKhau == " ")
            {
                return null;
            }
            else
            {
                string sql = "select TenDangNhap,QuyenTruyCap,TrangThai from GiaoVien where TenDangNhap='" + tk.TenDangNhap + "' and MatKhau='" + tk.MatKhau + "'";
                DataProvider kn = new DataProvider();
                return kn.ExecuteReader(sql);
            }
        }

        public LoaiNguoiDung DangNhap_ql(TaiKhoan tk)
        {
            if (tk.TenDangNhap == " " || tk.MatKhau == " ")
            {
                return null;
            }
            else
            {
                string sql = "select TenDangNhap,QuyenTruyCap,TrangThai from QuanLy where TenDangNhap='" + tk.TenDangNhap + "' and MatKhau='" + tk.MatKhau + "'";
                DataProvider kn = new DataProvider();
                return kn.ExecuteReader(sql);
            }
        }

        public int CapNhat_gv(string username,CapNhatTaiKhoan tk)
        {
            if (tk.Hoten == "" || tk.Matkhau == "" || tk.Dienthoai == "" || tk.Diachi == "")
            {
                return 0;
            }
            else
            {
                SqlParameter[] paras = new SqlParameter[5];
                paras[0] = new SqlParameter("@magv", username);
                paras[1] = new SqlParameter("@Hoten", tk.Hoten);
                paras[2] = new SqlParameter("@Matkhau", tk.Matkhau);
                paras[3] = new SqlParameter("@Diachi", tk.Diachi);
                paras[4] = new SqlParameter("@Dienthoai", tk.Dienthoai);
                string procname = "capnhattaikhoan_gv";
                DataProvider kn = new DataProvider();
                return kn.ExecuteNonquery_Update(procname, paras);
            }
        }

        public void DangKyPhuTrachMon(MonHoc dk)
        {
            SqlParameter[] paras = new SqlParameter[4];
            paras[0] = new SqlParameter("@magv", dk.ma);
            paras[1] = new SqlParameter("@tenmh", dk.maMonHoc);
            paras[2] = new SqlParameter("@khoahoc", dk.maKhoaHoc);
            paras[3] = new SqlParameter("@malop", dk.malop);
            string procname = "insert_phutrachmonhoc";
            DataProvider kn = new DataProvider();
            kn.ExecuteNonquery(procname, paras);
        }
        public void HuyDangKyPhuTrachMon(MonHoc dk)
        {
            SqlParameter[] paras = new SqlParameter[4];
            paras[0] = new SqlParameter("@magv", dk.ma);
            paras[1] = new SqlParameter("@tenmh", dk.maMonHoc);
            paras[2] = new SqlParameter("@malop", dk.malop);
            paras[3] = new SqlParameter("@khoahoc", dk.maKhoaHoc);
            string procname = "delete_phutrachmonhoc";
            DataProvider kn = new DataProvider();
            kn.ExecuteNonquery(procname, paras);
        }
        public void CapNhatTrachMon(MonHoc dk)
        {
            SqlParameter[] paras = new SqlParameter[4];
            paras[0] = new SqlParameter("@magv", dk.ma);
            paras[1] = new SqlParameter("@tenmh", dk.maMonHoc);
            paras[2] = new SqlParameter("@malop", dk.malop);
            paras[3] = new SqlParameter("@khoahoc", dk.maKhoaHoc);
            string procname = "capnhat_phutrachmonhoc";
            DataProvider kn = new DataProvider();
            kn.ExecuteNonquery(procname, paras);
        }
        public DataTable loadphutrach(string magv)
        {
            string sql = "select * from PhuTrach where maGiaoVien='" + magv + "'";
            DataProvider kn = new DataProvider();
            return kn.ExecuteQuery(sql);
        }

        public void DangKyMonHoc(MonHoc dk)
        {
            SqlParameter[] paras = new SqlParameter[4];
            paras[0] = new SqlParameter("@magv", dk.ma);
            paras[1] = new SqlParameter("@tenmh", dk.maMonHoc);
            paras[2] = new SqlParameter("@khoahoc", dk.maKhoaHoc);
            paras[3] = new SqlParameter("@malop", dk.malop);
            string procname = "insert_dangkymonhoc";
            DataProvider kn = new DataProvider();
            kn.ExecuteNonquery(procname, paras);
        }

        public DataTable loadsinhvien(string masv)
        {
            string sql = "select * from DangKiMonHoc where maSinhVien='" + masv + "'";
            DataProvider kn = new DataProvider();
            return kn.ExecuteQuery(sql);
        }
        public void HuyDangKyMonHoc(MonHoc dk)
        {
            SqlParameter[] paras = new SqlParameter[4];
            paras[0] = new SqlParameter("@masv", dk.ma);
            paras[1] = new SqlParameter("@tenmh", dk.maMonHoc);
            paras[2] = new SqlParameter("@khoahoc", dk.maKhoaHoc);
            paras[3] = new SqlParameter("@malop", dk.malop);
            string procname = "delete_dangkyhmonhoc";
            DataProvider kn = new DataProvider();
            kn.ExecuteNonquery(procname, paras);
        }
        public int CapNhat_sv(string username, CapNhatTaiKhoan tk)
        {
            if (tk.Hoten == "" || tk.Matkhau == "" || tk.Dienthoai == "" || tk.Diachi == "")
            {
                return 0;
            }
            else
            {
                SqlParameter[] paras = new SqlParameter[5];
                paras[0] = new SqlParameter("@masv", username);
                paras[1] = new SqlParameter("@Hoten", tk.Hoten);
                paras[2] = new SqlParameter("@Matkhau", tk.Matkhau);
                paras[3] = new SqlParameter("@Diachi", tk.Diachi);
                paras[4] = new SqlParameter("@Dienthoai", tk.Dienthoai);
                string procname = "capnhattaikhoan_sv";
                DataProvider kn = new DataProvider();
                return kn.ExecuteNonquery_Update(procname, paras);
            }
        }
        public void DangMonHoc(DangMonHoc mh)
        {
            if (mh.maMonHoc == "" || mh.temMonHoc == "")
            {
                MessageBox.Show("Insert That Bai", "Canh Bao", MessageBoxButtons.OK);
            }
            else
            {
                SqlParameter[] paras = new SqlParameter[3];
                paras[0] = new SqlParameter("@ma", mh.maMonHoc);
                paras[1] = new SqlParameter("@tenMonHoc", mh.temMonHoc);
                paras[2] = new SqlParameter("@maKhoa", mh.maKhoa);
                string procname = "dangmonhoc";
                DataProvider kn = new DataProvider();
                kn.ExecuteNonquery(procname, paras);
            }
        }
        public void UpdateMonHoc(DangMonHoc mh)
        {
            if (mh.maMonHoc == "" || mh.temMonHoc == "")
            {
                MessageBox.Show("Update That Bai", "Canh Bao", MessageBoxButtons.OK);
            }
            else
            {
                SqlParameter[] paras = new SqlParameter[3];
                paras[0] = new SqlParameter("@ma", mh.maMonHoc);
                paras[1] = new SqlParameter("@tenMonHoc", mh.temMonHoc);
                paras[2] = new SqlParameter("@maKhoa", mh.maKhoa);
                string procname = "updatemonhoc";
                DataProvider kn = new DataProvider();
                kn.ExecuteNonquery(procname, paras);
            }
        }
        public void XoaMonHoc(DangMonHoc mh)
        {
            if (mh.maMonHoc == "" || mh.temMonHoc == "")
            {
                MessageBox.Show("Delete That Bai", "Canh Bao", MessageBoxButtons.OK);
            }
            else
            {
                SqlParameter[] paras = new SqlParameter[3];
                paras[0] = new SqlParameter("@ma", mh.maMonHoc);
                paras[1] = new SqlParameter("@tenMonHoc", mh.temMonHoc);
                paras[2] = new SqlParameter("@maKhoa", mh.maKhoa);
                string procname = "xoamonhoc";
                DataProvider kn = new DataProvider();
                kn.ExecuteNonquery(procname, paras);
            }
        }
        public DataTable loadmonhoc()
        {
            string sql = "select * from MonHoc";
            DataProvider kn = new DataProvider();
            return kn.ExecuteQuery(sql);
        }
        public DataTable loadgiaovien1(string timkiem)
        {
            string sql = "select * from PhuTrach where maGiaoVien='"+timkiem+"'";
            DataProvider kn = new DataProvider();
            return kn.ExecuteQuery(sql);
        }
        public DataTable loaddangkimonhoc1(string timkiem)
        {
            string sql = "select * from DangKiMonHoc where maSinhVien='"+timkiem +"'";
            DataProvider kn = new DataProvider();
            return kn.ExecuteQuery(sql);
        }
        public DataTable loadgiaovien2()
        {
            string sql = "select * from PhuTrach";
            DataProvider kn = new DataProvider();
            return kn.ExecuteQuery(sql);
        }
        public DataTable loaddangkimonhoc2()
        {
            string sql = "select * from DangKiMonHoc";
            DataProvider kn = new DataProvider();
            return kn.ExecuteQuery(sql);
        }

        public DataTable loadphancong()
        {
            string sql = "select * from PhuTrach";
            DataProvider kn = new DataProvider();
            return kn.ExecuteQuery(sql);
        }
        public DataTable loadphanconggiaovien(string magv)
        {
            string sql = "select * from PhuTrach where maGiaoVien='"+magv+"'";
            DataProvider kn = new DataProvider();
            return kn.ExecuteQuery(sql);
        }

        public void PhanCongPhuTrachMon(MonHoc dk)
        {
            SqlParameter[] paras = new SqlParameter[4];
            paras[0] = new SqlParameter("@magv", dk.ma);
            paras[1] = new SqlParameter("@tenmh", dk.maMonHoc);
            paras[2] = new SqlParameter("@khoahoc", dk.maKhoaHoc);
            paras[3] = new SqlParameter("@malop", dk.malop);
            string procname = "PhanCong_phutrachmonhoc";
            DataProvider kn = new DataProvider();
            kn.ExecuteNonquery(procname, paras);
        }
        public void HuyPhanCongMon(MonHoc dk)
        {
            SqlParameter[] paras = new SqlParameter[4];
            paras[0] = new SqlParameter("@magv", dk.ma);
            paras[1] = new SqlParameter("@tenmh", dk.maMonHoc);
            paras[2] = new SqlParameter("@malop", dk.malop);
            paras[3] = new SqlParameter("@khoahoc", dk.maKhoaHoc);
            string procname = "deletePhanCong_phutrachmonhoc";
            DataProvider kn = new DataProvider();
            kn.ExecuteNonquery(procname, paras);
        }
        public void CapNhatPhanCongMon(MonHoc dk)
        {
            SqlParameter[] paras = new SqlParameter[4];
            paras[0] = new SqlParameter("@magv", dk.ma);
            paras[1] = new SqlParameter("@tenmh", dk.maMonHoc);
            paras[2] = new SqlParameter("@malop", dk.malop);
            paras[3] = new SqlParameter("@khoahoc", dk.maKhoaHoc);
            string procname = "capnhatPhanCong_phutrachmonhoc";
            DataProvider kn = new DataProvider();
            kn.ExecuteNonquery(procname, paras);
        }
    }
}
