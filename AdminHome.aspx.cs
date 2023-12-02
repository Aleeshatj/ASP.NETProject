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
    public partial class AdminHome : System.Web.UI.Page
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
            string s = "select * from Category";
            DataTable dt = obj.Fn_DataTable(s);
            GridView1.DataSource = dt;
            GridView1.DataBind();
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
            TextBox Textna = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
            TextBox Textds = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];
            TextBox Textst = (TextBox)GridView1.Rows[i].Cells[7].Controls[0];

            string s = "update Category set Name='" + Textna.Text + "',Description='" + Textds.Text + "' ,Status='" + Textst.Text + "'where Id=" + id + "";

            int j = obj.Fn_NonQuery(s);
            GridView1.EditIndex = -1;
            Grid_Bind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;//index of row
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string s = "delete from Category where Id=" + id + "";
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
            Label1.Visible = true;
            GridViewRow rw = GridView1.Rows[e.NewSelectedIndex];
            Session["uid"] = rw.Cells[3].Text;
            Response.Redirect("AdminDisProduct.aspx");
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Grid_Bind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Category.aspx");
        }
    }
    }
    
