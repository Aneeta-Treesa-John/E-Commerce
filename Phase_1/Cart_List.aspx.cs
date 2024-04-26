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
    public partial class Cart_List : System.Web.UI.Page
    {
        Connectioncls obj = new Connectioncls();
        string amt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Grid_bind();
            }
        }
        public void Grid_bind()
        {
            string s = "select Product_Tab.Pro_Name,Product_Tab.Pro_Image,Product_Tab.Pro_Description,Cart_Tab.Cart_Quantity,Cart_Tab.Total_Price,Cart_Tab.Cart_Id from Cart_Tab join Product_Tab on Product_Tab.Pro_Id=Cart_Tab.Pro_Id where User_Id=" + Session["uid"]+"";
            DataSet ds = obj.Fn_Adapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            Panel1.Visible = true;
            int id = Convert.ToInt32(e.CommandArgument);
            string sel = "select Cart_Tab.Cart_Quantity,Cart_Tab.Total_Price,Product_Tab.Pro_Price,Cart_Tab.Cart_Id from Cart_Tab join Product_Tab on Product_Tab.Pro_Id=Cart_Tab.Pro_Id where Cart_Id=" + id + "";
            SqlDataReader dr = obj.Fn_Reader(sel);
            while (dr.Read())
            {
                TextBox1.Text = dr["Cart_Quantity"].ToString();
                Label3.Text = dr["Pro_Price"].ToString();
                Label5.Text = dr["Total_Price"].ToString();
            }
            Session["c_id"] = id;
        }

        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {
            Panel1.Visible = false;
            int id = Convert.ToInt32(e.CommandArgument);
            string se = "delete from Cart_Tab where Cart_Id=" + id + "";
            int g = obj.Fn_NonQuery(se);
            Grid_bind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(Label3.Text);
            string j = "update Cart_Tab set Cart_Quantity=" + TextBox1.Text + ", Total_Price=" + price + " where Cart_Id=" + Session["c_id"] + "";
            int l = obj.Fn_NonQuery(j);
            if(l!=0)
            {
                Label6.Visible = true;
                Label6.Text = "Updated";
            }
            Panel1.Visible = false;
            Grid_bind();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            string sel = "select max(Bill_Id) from Bill_Tab";
            string id = obj.Fn_Scalar(sel);
            int bill_id = 0;
            if (id == "")
            {
                bill_id = 420201;
            }
            else
            {
                int new_billid = Convert.ToInt32(id);
                bill_id = new_billid + 1;
            }
            DateTime today = DateTime.Today;
            string date = today.ToString("yyyy-MM-dd");
            string i = "select max(Cart_Id) from Cart_Tab where User_Id=" + Session["uid"] + "";
            string n = obj.Fn_Scalar(i);
            int num = Convert.ToInt32(n);
                for (int j = 1; j <= num; j++)
                {
                    string ord = "select * from Cart_Tab where User_Id=" + Session["uid"] + "";
                    SqlDataReader dr = obj.Fn_Reader(ord);
                    string cart_id, user_id, pro_id, cart_qty, amount;
                    while (dr.Read())
                    {
                        cart_id = dr["Cart_Id"].ToString();
                        user_id = dr["User_Id"].ToString();
                        pro_id = dr["Pro_Id"].ToString();
                        cart_qty = dr["Cart_Quantity"].ToString();
                        amount = dr["Total_Price"].ToString();
                        string ins = "insert into Order_Tab values(" + cart_id + "," + pro_id + "," + user_id + "," + cart_qty + "," + amount + ",'Order Confirmed')";
                        int k = obj.Fn_NonQuery(ins);
                        Session["pid"] = pro_id;
                        break;
                    }
                    string b = "select sum(Total_Price) from Order_Tab where User_Id=" + Session["uid"] + " and Order_status='Order confirmed'";
                    string sum = obj.Fn_Scalar(b);
                    amt=sum;
                    string del = "delete from Cart_Tab where Pro_Id=" + Session["pid"] + " and User_Id=" + Session["uid"] + "";
                    int d = obj.Fn_NonQuery(del);
                    Grid_bind();
                }

                string bill = "insert into Bill_Tab values(" + bill_id + ",'" + date + "'," + Session["uid"] + ",'" + amt + "','Payment Pending')";
                int m = obj.Fn_NonQuery(bill);
            if (m != 0)
            {
                Response.Redirect("Bill.aspx");
            }    
        }
    }
}