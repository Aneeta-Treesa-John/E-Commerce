using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Phase_1
{
    public class Connectioncls
    {
        SqlConnection con;
        SqlCommand cmd;
        public Connectioncls()
        {
            con = new SqlConnection(@"server=DESKTOP-BBMKTB2\SQLEXPRESS;database=Project;Integrated Security=true");
        }
        public int Fn_NonQuery(string sql)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sql, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string Fn_Scalar(string sql)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sql, con);
            con.Open();
            string j = cmd.ExecuteScalar().ToString();
            con.Close();
            return j;
        }
        public SqlDataReader Fn_Reader(string sql)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public DataSet Fn_Adapter(string sql)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}