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
    public partial class Category : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string P = "~/Photo/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(P));
            string ins = "insert into Category values('" + TextBox1.Text + "','" + P + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            int i = obj.Fn_NonQuery(ins);
            Label5.Visible = true;
            Label5.Text = "Category Added";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx");
        }      
    }
}
