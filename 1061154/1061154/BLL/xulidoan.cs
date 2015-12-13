using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _1061154.DTO;
using _1061154.BLL;
using _1061154.DAO;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace _1061154.BLL
{
    class xulidoan
    {
        DataProvider kn = new DataProvider();
        public DataTable loaddoan(string magv)
        {
            string sql = "select * from DoAn where maGiangVien='" + magv + "'";
            return kn.ExecuteQuery(sql);
        }

        public void ThemDoAn(DoAn da)
        {
            if (da.maMonHoc  == "" || da.maDoAn  == "" || da.TenDoAn == "" || da.SoThanhVien  == "")
            {
                MessageBox.Show("Insert That Bai", "ERRO", MessageBoxButtons.OK);
            }
            else
            {
                SqlParameter[] paras = new SqlParameter[7];
                paras[0] = new SqlParameter("@ma", da.maDoAn );
                paras[1] = new SqlParameter("@tenDoAn", da.TenDoAn );
                paras[2] = new SqlParameter("@ChiTiet", da.ChiTiet);
                paras[3] = new SqlParameter("@SoThanhVien", da.SoThanhVien);
                paras[4] = new SqlParameter("@deadline", da.dealine);
                paras[5] = new SqlParameter("@maMonHoc", da.maMonHoc);
                paras[6] = new SqlParameter("@maGiangVien", da.maGV);
                
                string procname = "insert_themmonhoc";
                kn.ExecuteNonquery(procname, paras);
            }
        }
        public void HuyDoAn(DoAn da)
        {
            if (da.maMonHoc == "" || da.maDoAn == "" )
            {
                MessageBox.Show("Delete That Bai", "ERRO", MessageBoxButtons.OK);
            }
            else
            {
                SqlParameter[] paras = new SqlParameter[3];
                paras[0] = new SqlParameter("@ma", da.maDoAn);
                paras[1] = new SqlParameter("@maMonHoc", da.maMonHoc);
                paras[2] = new SqlParameter("@maGiangVien", da.maGV);
                string procname = "delete_themmonhoc";
                kn.ExecuteNonquery(procname, paras);
            }
        }
        public void CapNhatDoAn(DoAn da)
        {
            if (da.maMonHoc == "" || da.maDoAn == "" || da.TenDoAn == "" || da.SoThanhVien == "")
            {
                MessageBox.Show("Cap Nhat That Bai", "ERRO", MessageBoxButtons.OK);
            }
            else
            {
                SqlParameter[] paras = new SqlParameter[7];
                paras[0] = new SqlParameter("@ma", da.maDoAn);
                paras[1] = new SqlParameter("@tenDoAn", da.TenDoAn);
                paras[2] = new SqlParameter("@ChiTiet", da.ChiTiet);
                paras[3] = new SqlParameter("@SoThanhVien", da.SoThanhVien);
                paras[4] = new SqlParameter("@deadline", da.dealine);
                paras[5] = new SqlParameter("@maMonHoc", da.maMonHoc);
                paras[6] = new SqlParameter("@maGiangVien", da.maGV);
                string procname = "capnhat_themmonhoc";
                kn.ExecuteNonquery(procname, paras);
            }
        }
    }
}
