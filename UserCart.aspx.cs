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
    public partial class UserCart : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Grid_Bind();
            }
        }
        public void Grid_Bind()
        {
            string s = "select * from Cart2";
            DataTable dt = obj.Fn_DataTable(s);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            
            TextBox TextQn = (TextBox)GridView1.Rows[i].Cells[7].Controls[0];
            TextBox TextTp = (TextBox)GridView1.Rows[i].Cells[8].Controls[0];

            string s = "update Cart2 set Quantity='" + TextQn.Text + "',Total_Price=" + TextTp.Text + " where Id=" + id + "";

            int j = obj.Fn_NonQuery(s);
            GridView1.EditIndex = -1;
            Grid_Bind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Grid_Bind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;//index of row
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string s = "delete from Cart2 where Id=" + id + "";
            int j = obj.Fn_NonQuery(s);
            Grid_Bind();
            if (j == 1)
            {
                Label1.Visible = true;
                Label1.Text = "Deleted..";
            }
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            
            GridViewRow rw = GridView1.Rows[e.NewSelectedIndex];
            Session["catId"] = rw.Cells[3].Text;
            string str = "select * from Cart2 where Cart_Id=" + Session["catid"] + "";
            SqlDataReader dr = obj.Fn_Reader(str);
            while (dr.Read())
            {
                string s = "Insert into Order_Tab values("+ dr["Cart_Id"] + "," + dr["Pro_Id"] + "," + dr["Reg_Id"] + ",'" + dr["Quantity"] + "','" + dr["Total_Price"] + "')";
                int i = obj.Fn_NonQuery(s);
                Label1.Visible = true;
                Label1.Text = "One Product Added";
                break;
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Grid_Bind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserOrder.aspx");
        }
    }
}