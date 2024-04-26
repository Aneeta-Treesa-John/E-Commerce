using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;

namespace Phase_1
{
    public partial class Feedback : System.Web.UI.Page
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
            string sel = "select * from Fb_Tab where Fb_Status='Admin Review Pending'";
            DataSet ds = obj.Fn_Adapter(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            string se = "select * from Fb_Tab where Fb_Id=" + id + "";
            string sele = obj.Fn_Scalar(se);
            Session["id"] = id;
            string sel = "select User_Reg_Tab.User_Name,User_Reg_Tab.User_Email,Fb_Tab.Fb_Replay from Fb_Tab join User_Reg_Tab on Fb_Tab.User_Id=User_Reg_Tab.User_Id";
            SqlDataReader dr = obj.Fn_Reader(sel);
            while (dr.Read())
            {
                Label2.Text = dr["User_Name"].ToString();
                Label8.Text = dr["User_Email"].ToString();
            }
            Panel1.Visible = true;
            Panel2.Visible = false;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string up = "update Fb_Tab set Fb_Replay='" + TextBox1.Text + "' where Fb_Id=" + Session["id"] + "";
            int upd = obj.Fn_NonQuery(up);
            if (upd != 0)
            {
                string st = "update Fb_Tab set Fb_Status='Reviewed by Admin' where Fb_Id=" + Session["id"] + "";
                int sta = obj.Fn_NonQuery(st);
            }
            Grid_bind();
            SendEmail2("JOAN", "joanenterprisespvt@gmail.com", "owxrlgzfyllhdpri", Label2.Text, Label8.Text, Label4.Text, TextBox1.Text);
        }
        public static void SendEmail2(string yourName, string yourGmailUserName, string yourGmailPassword, string toName, string toEmail, string subject, string body)
        {
            string to = toEmail; //To address    
            string from = yourGmailUserName; //From address    
            MailMessage message = new MailMessage(from, to);
            string mailbody = body;
            message.Subject = subject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential(yourGmailUserName, yourGmailPassword);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}