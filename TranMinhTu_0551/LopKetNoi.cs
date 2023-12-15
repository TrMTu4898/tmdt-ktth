using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace TranMinhTu_0551
{
    public class LopKetNoi : System.Web.UI.Page
    {
        SqlConnection con;
        private void ketnoi()
        {
            string sqlcn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\TMDT\TranMinhTu_0551\TranMinhTu_0551\App_Data\KTRATHUCHANH.mdf;Integrated Security=True";
            con = new SqlConnection(sqlcn);
            con.Open();
        }
        private void dongketnoi()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public DataTable laydulieu(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                ketnoi();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch
            {
                dt = null;
            }
            finally
            {
                dongketnoi();
            }
            return dt;
        }

        public int CapNhat(string sql)
        {
            int kq = 0;
            try
            {
                ketnoi();
                SqlCommand cmd = new SqlCommand(sql, con);
                kq = cmd.ExecuteNonQuery();
            }
            catch
            {
                kq = 0;
            }
            finally
            {
                dongketnoi();
            }
            return kq;
        }
    }
}