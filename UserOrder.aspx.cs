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
    public partial class Order : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Grid_Bind();
            }
        }
        public void Grid_Bind()
        {
            string s = "select * from Order_Tab";
            DataTable dt = obj.Fn_DataTable(s);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string ta = "select Sum(Total_Price) from Cart2";
            string TA = obj.Fn_Scalar(ta);
            string date = DateTime.Today.ToString();
            string s = "Insert into Bill values(" + Session["userid"] + ",'" + date + "','"+TA+"','Payment Cancelled')";
            int i = obj.Fn_NonQuery(s);
            Response.Redirect("UserCart.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ta = "select Sum(Total_Price) from Cart2";
            string TA = obj.Fn_Scalar(ta);
            string date = DateTime.Today.ToString();
            string s = "Insert into Bill values(" + Session["userid"] + ",'" + date + "','" + TA + "','Payment Sucessfull')";
            int i = obj.Fn_NonQuery(s); 
            Label1.Visible = true;
            Label1.Text = "Payment Sucessfull";
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;//index of row
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string s = "delete from Order_Tab where Ord_Id=" + id + "";
            int j = obj.Fn_NonQuery(s);
            Grid_Bind();
            if (j == 1)
            {
                Label1.Visible = true;
                Label1.Text = "Deleted..";
            }
        }
    }
}