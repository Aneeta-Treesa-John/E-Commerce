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
    public partial class Login : System.Web.UI.Page
    {
        Connectioncls obj = new Connectioncls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(Reg_Id) from Login_Tab where Username='" + TextBox4.Text + "' and Password='" + TextBox5.Text + "'";
            string c = obj.Fn_Scalar(str);
            int cid = Convert.ToInt32(c);
            if (cid == 1)
            {
                string sel = "select Reg_Id from Login_Tab where Username='" + TextBox4.Text + "' and Password='" + TextBox5.Text + "'";
                string regid = obj.Fn_Scalar(sel);
                Session["uid"] = regid;
                string sel2 = "select Log_Status from Login_Tab where Username='" + TextBox4.Text + "' and Password='" + TextBox5.Text + "'";
                string d = obj.Fn_Scalar(sel2);
                if (d == "Active")
                {
                    string type = "select Log_Type from Login_Tab where Username='" + TextBox4.Text + "' and Password='" + TextBox5.Text + "'";
                    string logtype = obj.Fn_Scalar(type);
                    if (logtype == "Admin")
                    {
                        Label3.Visible = true;
                        Label3.Text = "Welcome";
                        Response.Redirect("AdminHomePage.aspx");
                    }
                    else if (logtype == "User")
                    {
                        Label3.Visible = true;
                        Label3.Text = "Welcome";
                        Response.Redirect("UserHomePage.aspx");
                    }
                }
                else
                {
                    Label3.Visible = true;
                    Label3.Text = "You are currently been blocked.";
                }
            }
            else
            {
                Label3.Visible = true;
                Label3.Text = "Invalid Username or Password! Try again.";
            }
        }
    }
}