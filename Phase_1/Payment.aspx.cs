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
    public partial class Payment : System.Web.UI.Page
    {
        Connectioncls obj = new Connectioncls();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int acc_bal = 0;
            Service_AccBal_Check.ServiceClient obj1 = new Service_AccBal_Check.ServiceClient();
            int bal = obj1.BalanceCheck(Convert.ToInt32(TextBox1.Text));
            Session["accno"] = TextBox1.Text;

            string sel = "select Grand_Total from Bill_Tab where User_Id=" + Session["uid"] + "";
            string re = obj.Fn_Scalar(sel);
            int amt = Convert.ToInt32(re);

            if (bal > amt)
                {
                string up = "select max(Order_Id) from Order_Tab where User_Id=" + Session["uid"] + "";
                string c = obj.Fn_Scalar(up);
                int count = Convert.ToInt32(c);
                if (count != 0)
                {
                    int pro_id = 0;
                    for (int i = 1; i <= count; i++)
                    {
                        int pro_qty = 0, cart_qty = 0, qty = 0;
                        string stup = "select Order_Tab.Pro_Id,Product_Tab.Pro_Id,Order_Tab.Cart_Quantity,Product_Tab.Pro_Stock from Product_Tab join Order_Tab on Product_Tab.Pro_Id=Order_Tab.Pro_Id where User_Id=" + Session["uid"] + "and Order_Id=" + i + "";
                        SqlDataReader dr = obj.Fn_Reader(stup);
                        while (dr.Read())
                        {
                            pro_qty = Convert.ToInt32(dr["Pro_Stock"]);
                            cart_qty = Convert.ToInt32(dr["Cart_Quantity"]);
                            pro_id = Convert.ToInt32(dr["Pro_Id"]);
                            break;
                        }
                        qty = pro_qty - cart_qty;
                        string stock = "update Product_Tab set Pro_Stock=" + qty + " where Pro_Id=" + pro_id + "";
                        int stockup = obj.Fn_NonQuery(stock);
                        if (qty == 0)
                        {
                            string no = "update Product_Tab set Pro_Status='Unavailable' where Pro_Id=" + pro_id + "";
                            int st = obj.Fn_NonQuery(no);
                        }
                    }
                }
                string cst = "update Order_Tab set Order_Status='Out for delivery' where User_Id=" + Session["uid"] + "";
                int up_cst = obj.Fn_NonQuery(cst);

                string bst = "update Bill_Tab set Status='Payment Completed' where User_Id=" + Session["uid"] + "";
                int up_bst = obj.Fn_NonQuery(bst);
                acc_bal = bal - amt;
                string bankst = "update Bank_Tab set Acc_Balance=" + acc_bal + " where Acc_No=" + Session["accno"] + "";
                int up_bankst = obj.Fn_NonQuery(bankst);
                Label2.Visible = true;
                Label2.Text = "Order placed successfully";
                }
            else
            {
                Label2.Visible = true;
                Label2.Text = "Insufficient Balance";
            }
        }
    }
}