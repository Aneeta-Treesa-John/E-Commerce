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
    public partial class Product : System.Web.UI.Page
    {
        Connectioncls obj = new Connectioncls();
        int qty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sel = "select * from Product_Tab where Pro_Id="+ Session["pid"] + "";
                SqlDataReader dr = obj.Fn_Reader(sel);
                while (dr.Read())
                {
                    Label1.Text = dr["Pro_Name"].ToString();
                    Label2.Text = dr["Pro_Description"].ToString();
                    Label3.Text = dr["Pro_Price"].ToString();
                    Image1.ImageUrl = dr["Pro_Image"].ToString();
                }
                    TextBox1.Text = "0";                
            }
        }
        protected void Addbtn_Click(object sender, ImageClickEventArgs e)
        {
            qty = Convert.ToInt32(TextBox1.Text);
            qty++;
            TextBox1.Text = qty.ToString();
            Session["qty"] = TextBox1.Text;
        }
        protected void Minusbtn_Click(object sender, ImageClickEventArgs e)
        {
            qty = Convert.ToInt32(TextBox1.Text);
            if (qty > 0)
            {
                qty--;
                TextBox1.Text = qty.ToString();
                Session["qty"] = TextBox1.Text;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string qu = "select Pro_Stock from Product_Tab where Pro_Id=" + Session["pid"] + "";
            string qt = obj.Fn_Scalar(qu);
            int q = Convert.ToInt32(qt);
            qty = Convert.ToInt32(Session["qty"]);
            if (q < qty)
            {
                Label10.Visible = true;
                Label10.Text = "Oops! Insufficient Stock";
            }
            else
            {
                string i = "select max(Cart_Id) from Cart_Tab";
                string id = obj.Fn_Scalar(i);
                int cart_id = 0;
                if (id == "")
                {
                    cart_id = 1;
                }
                else
                {
                    int newcart_id = Convert.ToInt32(id);
                    cart_id = newcart_id + 1;
                }
                string rs= "select Pro_Price from Product_Tab where Pro_Id="+Session["pid"]+"";
                string p = obj.Fn_Scalar(rs);
                int t_price = Convert.ToInt32(p) * Convert.ToInt32(TextBox1.Text);
                string ins="insert into Cart_Tab values("+cart_id+ ","+Session["pid"]+ ","+Session["uid"]+ ","+TextBox1.Text+ ","+t_price+ ",'Added to cart')";
                int add = obj.Fn_NonQuery(ins);
                if (add == 1)
                {
                    Label10.Visible = true;
                    Label10.Text = "Item added to wishlist.";
                }
                Response.Redirect("Cart_List.aspx");
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHomePage.aspx");
        }
    }
}