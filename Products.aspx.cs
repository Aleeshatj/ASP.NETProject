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
    public partial class Products : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string P = "~/Photo/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(P));
            string ins = "insert into Product values("+DropDownList1.SelectedItem.Value +",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + P + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            int i = obj.Fn_NonQuery(ins);
            Label7.Visible = true;
            Label7.Text = "Product Added";
        }
    }
}