using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Project1
{
    public partial class MainUser : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
           //if(!IsPostBack)
           // {

           // }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(Reg_Id) from Login where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            string cid = obj.Fn_Scalar(str);
            int cid1 = Convert.ToInt32(cid);
            if (cid1 == 1)
            {
                string str1 = "select Reg_Id from Login where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string regid = obj.Fn_Scalar(str1);
                Session["userid"] = regid;
                string str2 = "select Login_Type from Login where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string logintype = obj.Fn_Scalar(str2);
                if (logintype == "admin")
                {
                    Label3.Visible = true;
                    Label3.Text = "Admin";
                    Response.Redirect("AdminHome.aspx");
                }
                else if (logintype == "user")
                {
                    Label3.Visible = true;
                    Label3.Text = "User";
                    Response.Redirect("UserHome.aspx");
                }
            }
            else
            {
                Label3.Visible = true;
                Label3.Text = "Invalid";
            }
        }
    }
}