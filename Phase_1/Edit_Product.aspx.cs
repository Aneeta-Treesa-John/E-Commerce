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
    public partial class Edit_Product : System.Web.UI.Page
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
            string sel = "select * from Product_Tab";
            DataSet ds = obj.Fn_Adapter(sel);
            GridView2.DataSource = ds;
            GridView2.DataBind();
        }
        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            Panel1.Visible = true;
            int id = Convert.ToInt32(e.CommandArgument);
            Session["pid"] = id;
            string sel = "select * from Product_Tab where Pro_Id="+id+"";
            SqlDataReader dr = obj.Fn_Reader(sel);
            while (dr.Read())
            {
                TextBox1.Text = dr["Pro_Name"].ToString();
                Image1.ImageUrl = dr["Pro_Image"].ToString();
                TextBox2.Text = dr["Pro_Description"].ToString();
                TextBox4.Text = dr["Pro_Price"].ToString();
                TextBox5.Text = dr["Pro_Stock"].ToString();
            }
            
        }       //Edit Product
        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {
            int id1 = Convert.ToInt32(e.CommandArgument);
            string sel = "select Pro_Status from Product_Tab where Pro_Id=" + id1 + "";
            string s = obj.Fn_Scalar(sel);
            if (s == "Available")
            {
                string d = "update Product_Tab set Pro_Status='Unavailable' where Pro_Id=" + id1 + "";
                int h = obj.Fn_NonQuery(d);
                Grid_bind();
            }
            else
            {
                string c = "update Product_Tab set Pro_Status='Available' where Pro_Id=" + id1 + "";
                int j = obj.Fn_NonQuery(c);
                Grid_bind();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string u = "update Product_Tab set Pro_Name='" + TextBox1.Text + "',Pro_Image='" + p + "',Pro_Description='" + TextBox2.Text + "',Pro_Price=" + TextBox4.Text + ",Pro_Stock=" + TextBox5.Text + " where Pro_Id=" + Session["pid"] + "";
            int upd = obj.Fn_NonQuery(u);
            Panel1.Visible = false;
            Grid_bind();
        }

        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            Grid_bind();
        }
    }
}