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
    public partial class ProducttoCart : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string str = "select Pro_Id,Pro_Name,Pro_Price,Pro_Image,Pro_Descr,Pro_Status,Pro_Stock from Product where Pro_Id=" + Session["pid"] + "";
                SqlDataReader dr = obj.Fn_Reader(str);
                while (dr.Read())
                {
                    Session["Pid"] = dr["Pro_Id"].ToString();
                    Label1.Text = dr["Pro_Name"].ToString();
                    Image1.ImageUrl = dr["Pro_Image"].ToString();
                    Label2.Text = dr["Pro_Price"].ToString();
                    Label3.Text = dr["Pro_Descr"].ToString();
                    Label4.Text = dr["Pro_Status"].ToString();
                    Label5.Text = dr["Pro_Stock"].ToString();
                    Session["Price"] = Label2.Text;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select max(Cart_Id) from Cart2";
            string regid = obj.Fn_Scalar(str);
            int Reg_Id = 0;
            if (regid == "")
            {
                Reg_Id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                Reg_Id = newregid + 1;
            }
            string ins = "insert into Cart2 values(" + Reg_Id + "," + Session["Pid"] + "," + Session["userid"] + ",'" + TextBox1.Text + "'," + Session["Price"] + ")";
            int i = obj.Fn_NonQuery(ins);
            Response.Redirect("UserCart.aspx");
        }
    }
}