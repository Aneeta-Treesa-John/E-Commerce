using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Phase_1
{
    public partial class ViewUser : System.Web.UI.Page
    {
        Connectioncls obj = new Connectioncls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Grid_bind();
            }
        }
        public void Grid_bind()
        {
            string bi = "select * from User_Reg_Tab";
            DataSet ds = obj.Fn_Adapter(bi);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            string sel = "select User_Status from User_Reg_Tab where User_Id=" + id + "";
            string s = obj.Fn_Scalar(sel);
            if (s == "Active")
            {
                string d = "update User_Reg_Tab set User_Status='Block' where User_Id=" + id + "";
                int h = obj.Fn_NonQuery(d);
                Grid_bind();
            }
            else
            {
                string c = "update User_Reg_Tab set User_Status='Active' where User_Id=" + id + "";
                int j = obj.Fn_NonQuery(c);
                Grid_bind();
            }
        }
    }
}