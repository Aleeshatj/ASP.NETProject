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
    public partial class AdminDisProduct : System.Web.UI.Page
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
            string s = "select * from Product where Cat_Id=" + Session["uid"] + "";
            DataTable dt = obj.Fn_DataTable(s);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx");
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;//index of row
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string s = "delete from Product where Id=" + id + "";
            int j = obj.Fn_NonQuery(s);
            Grid_Bind();
            if (j == 1)
            {
                Label6.Visible = true;
                Label6.Text = "Deleted..";
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Grid_Bind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Grid_Bind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox Textna = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];
            TextBox Textpr = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
            TextBox Textds = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];
            TextBox Textst = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];
            TextBox Textsto = (TextBox)GridView1.Rows[i].Cells[7].Controls[0];

            string s = "update Product set Pro_Name='" + Textna.Text + "',Pro_Price='" + Textpr.Text+ "',Pro_Descr='" + Textds.Text + "' ,Pro_Status='" + Textst.Text + "',Pro_Stock='" + Textsto.Text + "'where Id=" + id + "";

            int j = obj.Fn_NonQuery(s);
            GridView1.EditIndex = -1;
            Grid_Bind();
        }
    }
}