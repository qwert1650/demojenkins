using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using _1061154.DTO;

namespace _1061154.DAO
{
    class DataProvider
    {
        string connectionstring = "Data Source=(local);Initial Catalog=QLHP;Integrated Security=True";
        SqlConnection conn = null;
        public bool openconnection()
        {
            bool isopen = false;
            if (conn == null)
            {
                conn = new SqlConnection(connectionstring);
            }
            conn.Open();
            if (conn.State == ConnectionState.Open)
                isopen = true;
            return isopen;
        }
        public void CloseConnection()
        {
            if (conn != null)
                conn.Close();
        }
        public bool ExecuteNonquery(string procname, params SqlParameter[] sqlparameters)
        {
            if (openconnection() == true)
            {
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procname;
                if (sqlparameters != null)
                {
                    command.Parameters.AddRange(sqlparameters);
                }
                command.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
            return false;
        }

        public DataTable ExecuteQuery(string sql)
        {
            DataTable dt = new DataTable();
            if (openconnection() == true)
            {
                SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
                adap.Fill(dt);
                CloseConnection();
            }
            return dt;
        }

        public LoaiNguoiDung ExecuteReader(string sql)
        {
            LoaiNguoiDung nd= new LoaiNguoiDung();
            nd.loainguoidung = "0";
            nd.username = "0";
            nd.TrangThai="0";
            if (openconnection() == true)
            {
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader read= command.ExecuteReader();
                while (read.Read())
                {
                    if (read.GetString(0) != null)
                    {
                        nd.username = read.GetString(0);
                        nd.loainguoidung = read.GetString(1);
                        nd.TrangThai = read.GetString(2);
                        return nd;
                    }
                }
            }
            return nd;
        }

        public int ExecuteNonquery_Update(string procname, params SqlParameter[] sqlparameters)
        {
            int i = 0;
            if (openconnection() == true)
            {
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procname;
                if (sqlparameters != null)
                {
                    command.Parameters.AddRange(sqlparameters);
                }
               i=command.ExecuteNonQuery();
                CloseConnection();
                return i;
            }
            return i;
        }
    }
}
