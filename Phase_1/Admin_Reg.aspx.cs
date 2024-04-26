using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Phase_1
{
    public partial class Admin_Reg : System.Web.UI.Page
    {
        Connectioncls obj = new Connectioncls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_Id) from Login_Tab";
            string id = obj.Fn_Scalar(sel);
            int reg_id = 0;
            if (id == "")
            {
                reg_id = 1;
            }
            else
            {
                int new_regid = Convert.ToInt32(id);
                reg_id = new_regid + 1;
            }
            string ins = "insert into Admin_Reg_Tab values(" + reg_id + ",'" + TextBox1.Text+ "','"+TextBox2.Text+ "',"+TextBox3.Text+ ")";
            int i = obj.Fn_NonQuery(ins);
            if (i != 0)
            {
                string log = "insert into Login_Tab values(" + reg_id + ",'" + TextBox4.Text + "','" + TextBox5.Text + "','Admin','Active')";
                int j = obj.Fn_NonQuery(log);
                Label4.Visible = true;
                Label4.Text = "Registration Successfull";
            }
        }
        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            string ch = "select Count(Reg_Id) from Login_Tab where Username='"+TextBox4.Text+"'";
            string c = obj.Fn_Scalar(ch);
            if (c == "1")
            {
                Label8.Visible = true;
                Label8.Text = "Already Exists";
            }
        }
    }
}