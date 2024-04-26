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
    public partial class Add_Product : System.Web.UI.Page
    {
        Connectioncls obj = new Connectioncls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string bindcate = "select Cate_Name,Cate_Id from Category_Tab";
                DataSet ds = obj.Fn_Adapter(bindcate);
                Cate_dd.DataSource = ds;
                Cate_dd.DataTextField = "Cate_Name";
                Cate_dd.DataValueField = "Cate_Id";
                Cate_dd.DataBind();
                Cate_dd.Items.Insert(0, "-select-");
            }
        }
        //Add Product
        protected void Button2_Click(object sender, EventArgs e)
        {
            string m = "~/Photos/" + FileUpload2.FileName;
            FileUpload2.SaveAs(MapPath(m));
            string g = "insert into Product_Tab values(" + Cate_dd.SelectedItem.Value + ",'" + TextBox4.Text + "','" + m + "','" + TextBox5.Text + "'," + TextBox6.Text + "," + TextBox7.Text + ",'Available')";
            int c = obj.Fn_NonQuery(g);
            if (c == 1)
            {
                Label14.Visible = true;
                Label14.Text = "Item added.";
            }
        }
    }
}