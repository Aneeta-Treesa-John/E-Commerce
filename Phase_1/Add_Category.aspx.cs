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
    public partial class Add : System.Web.UI.Page
    {
        Connectioncls obj = new Connectioncls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Add Category
        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string ins = "insert into Category_Tab values('"+TextBox1.Text+ "','"+p+ "','"+TextBox2.Text+ "','Available')";
            int d = obj.Fn_NonQuery(ins);
            if (d == 1)
            {
                Label13.Visible = true;
                Label13.Text = "Item added.";
            }
        }
    }
}