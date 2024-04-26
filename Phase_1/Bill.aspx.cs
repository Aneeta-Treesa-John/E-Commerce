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
    public partial class Bill : System.Web.UI.Page
    {
        Connectioncls obj = new Connectioncls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sel1 = "select User_Reg_Tab.User_Address,User_Reg_Tab.User_State,User_Reg_Tab.User_Pincode,User_Reg_Tab.User_Phone,Bill_Tab.Bill_Id,Bill_Tab.Bill_Date,Bill_Tab.Grand_Total,Bill_Tab.User_Id from User_Reg_Tab join Bill_Tab on User_Reg_Tab.User_Id=Bill_Tab.User_Id where User_Reg_Tab.User_Id=" + Session["uid"] + "";
                SqlDataReader dr = obj.Fn_Reader(sel1);
                while (dr.Read())
                {
                    User_Address.Text = dr["User_Address"].ToString();
                    User_State.Text = dr["User_State"].ToString();
                    User_Pin.Text = dr["User_Pincode"].ToString();
                    User_Ph.Text = dr["User_Phone"].ToString();
                    Label19.Text = dr["Grand_Total"].ToString();
                    Bill_date.Text = dr["Bill_Date"].ToString();
                    Bill_No.Text = dr["Bill_Id"].ToString();
                }
                Grid_bind();
            }
        }
        public void Grid_bind()
        {
            string s = "select Order_Tab.Cart_Id,Product_Tab.Pro_Name,Order_Tab.Cart_Quantity,Product_Tab.Pro_Price,Order_Tab.Total_Price from Product_Tab join Order_Tab on Product_Tab.Pro_Id=Order_Tab.Pro_Id where User_Id=" + Session["uid"] + " and where Order_Status='Order confirmed'";
            DataSet ds = obj.Fn_Adapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select * from Acc_Tab where User_Id=" + Session["uid"] + "";
            string b = obj.Fn_Scalar(sel);
            if (b != "")
            {
                Response.Redirect("Payment.aspx");
            }
            else
            {
                Label20.Visible = true;
                Label20.Text = "You doesn't have a valid account. Please enter the Account details.";
            }
        }
    }
}

