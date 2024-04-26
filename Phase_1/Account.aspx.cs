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
    public partial class Account : System.Web.UI.Page
    {
        Connectioncls obj = new Connectioncls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ins1 = "insert into Acc_Tab values(" + TextBox2.Text + ",'" + TextBox1.Text + "'," + Session["uid"] + ",'" + TextBox3.Text + "')";
            int h = obj.Fn_NonQuery(ins1);
            if (h != 0)
            {
                Label24.Visible=true;
                Label24.Text = "Account details entered Successfully";
            }
        }
    }
}