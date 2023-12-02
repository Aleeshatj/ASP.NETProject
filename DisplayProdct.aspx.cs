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
    public partial class DisplayProdct : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string s = "select * from Product where Cat_Id=" + Session["id"] + "";
                DataTable dt = obj.Fn_DataTable(s);
                DataList1.DataSource = dt;
                DataList1.DataBind();
            }
        }


        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {

        int Id = Convert.ToInt32(e.CommandArgument);
        Session["pid"] = Id;
        Response.Redirect("ProducttoCart.aspx");
         }
    }
}