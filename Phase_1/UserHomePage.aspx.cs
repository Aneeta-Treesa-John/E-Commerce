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
    public partial class UserHomePage : System.Web.UI.Page
    {
        Connectioncls obj = new Connectioncls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sel = "select * from Category_Tab  where Cate_Status='Available'";
                DataSet ds = obj.Fn_Adapter(sel);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
            //UserHomePage
        }
        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            Session["cid"] = id;
            Response.Redirect("Product_sheet.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ins="insert into Fb_Tab values("+Session["uid"]+",'"+TextBox1.Text+"','Take Action','Admin Review Pending')";
            int se = obj.Fn_NonQuery(ins);
            if (se != 0)
            {
                Label5.Visible = true;
                Label5.Text = "Feedback send successfully.";
            }
        }
    }
}