using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Data
    {
        public SqlConnection getConnection()
        {

            return new SqlConnection(@"Data Source=DESKTOP-O7RSLLI\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True");

        }
        public DataTable Getdatatable(string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return (dt);
        }
        public void ExcuteNoneQuery(string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }
    }
}
