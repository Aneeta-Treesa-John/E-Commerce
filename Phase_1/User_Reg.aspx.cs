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
    public partial class User_Reg : System.Web.UI.Page
    {
        Connectioncls obj = new Connectioncls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string bindst = "select Id,State from St_Tab";
                DataSet ds = obj.Fn_Adapter(bindst);
                State.DataSource = ds;
                State.DataTextField = "State";
                State.DataValueField = "Id";
                State.DataBind();
                State.Items.Insert(0,"-select-");
            }
        }
        protected void State_SelectedIndexChanged(object sender, EventArgs e)
        {
            string binddt = "select D_Id,District from Dt_Tab where Id="+State.SelectedItem.Value+"";
            DataSet ds1 = obj.Fn_Adapter(binddt);
            District.DataSource = ds1;
            District.DataTextField = "District";
            District.DataValueField = "D_Id";
            District.DataBind();
            District.Items.Insert(0, "-select-");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_Id) from Login_Tab";
            string id = obj.Fn_Scalar(sel);
            int reg_id = 0;
            if (id == "")
            {
                reg_id = 1;
            }
            else
            {
                int new_regid = Convert.ToInt32(id);
                reg_id = new_regid + 1;
            }
            string ins = "insert into User_Reg_Tab values(" + reg_id + ",'" + TextBox1.Text + "',"+TextBox7.Text+",'" + TextBox2.Text + "'," + TextBox3.Text + ",'"+TextBox8.Text+ "','"+State.SelectedItem.Text+ "','"+District.SelectedItem.Text+ "',"+TextBox11.Text+ ",'Active')";
            int i = obj.Fn_NonQuery(ins);
            if (i != 0)
            {
                string log = "insert into Login_Tab values(" + reg_id + ",'" + TextBox4.Text + "','" + TextBox5.Text + "','User','Active')";
                int j = obj.Fn_NonQuery(log);
                if (j != 0)
                {
                    Label14.Visible = true;
                    Label14.Text = "Registeration Successfull";
                }
            }
        }
        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            string ch = "select Count(Reg_Id) from Login_Tab where Username='" + TextBox4.Text + "'";
            string c = obj.Fn_Scalar(ch);
            if (c == "1")
            {
                Label13.Visible = true;
                Label13.Text = "Already Exists";
            }
        }
    }
}