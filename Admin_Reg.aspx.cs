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
    public partial class Admin_Reg : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select max(Reg_Id) from Login";
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
            string ins = "Insert into Admin values(" + Reg_Id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            int i = obj.Fn_NonQuery(ins);
            string inslog = "Insert into Login values(" + Reg_Id + ",'" + TextBox5.Text + "','" + TextBox6.Text + "','admin','active')";
            int j = obj.Fn_NonQuery(inslog);
            Label7.Visible = true;
            Label7.Text = "Registered";
        }
    }
}