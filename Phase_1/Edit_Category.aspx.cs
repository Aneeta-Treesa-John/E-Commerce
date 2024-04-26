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
    public partial class Edit_Category : System.Web.UI.Page
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
            string sel = "select * from Category_Tab";
            DataSet ds = obj.Fn_Adapter(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            Panel1.Visible = true;
            int id = Convert.ToInt32(e.CommandArgument);
            Session["cid"] = id;
            string sel = "select * from Category_Tab where Cate_Id="+id+"";
            SqlDataReader dr = obj.Fn_Reader(sel);
            while (dr.Read())
            {
                TextBox1.Text = dr["Cate_Name"].ToString();
                Image1.ImageUrl = dr["Cate_Image"].ToString();
                TextBox2.Text = dr["Cate_Description"].ToString();
            }
        }       //Edit Category
        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {
            int id1 = Convert.ToInt32(e.CommandArgument);
            string sel = "select Cate_Status from Category_Tab where Cate_Id=" + id1+"";
            string s = obj.Fn_Scalar(sel);
            if (s == "Available")
            {
                string d = "update Category_Tab set Cate_Status='Unavailable' where Cate_Id=" + id1 + "";
                int h = obj.Fn_NonQuery(d);
                Grid_bind();
            }
            else
            {
                string c = "update Category_Tab set Cate_Status='Available' where Cate_Id=" + id1 + "";
                int j = obj.Fn_NonQuery(c);
                Grid_bind();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string u = "update Category_Tab set Cate_Name='" + TextBox1.Text + "',Cate_Image='" + p + "',Cate_Description='" + TextBox2.Text + "' where Cate_Id=" + Session["cid"] + "";
            int upd = obj.Fn_NonQuery(u);
            Panel1.Visible = false;
            Grid_bind();
        }
    }
}