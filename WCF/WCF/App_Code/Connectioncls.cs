using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Connectioncls
/// </summary>
public class Connectioncls
{
    SqlConnection con;
    SqlCommand cmd;
    public Connectioncls()
    {
        con = new SqlConnection(@"server=ADMINRG-7MEAJU5\SQLEXPRESS;database=Project;Integrated Security=true");
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
}