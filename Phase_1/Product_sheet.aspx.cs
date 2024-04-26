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
    public partial class Product_sheet : System.Web.UI.Page
    {
        Connectioncls obj = new Connectioncls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sel = "select * from Product_Tab where Cate_Id="+ Session["cid"] + " and Pro_Status='Available'";
                DataSet ds = obj.Fn_Adapter(sel);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }

        }
        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            Session["pid"] = id;
            Response.Redirect("View_Product.aspx");
        }
    }
}