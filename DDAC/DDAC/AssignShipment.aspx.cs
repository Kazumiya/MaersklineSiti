using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DDAC
{
    public partial class AssignShipment : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DDACConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string InsertQuery = "insert into AssignShipment (Depart,Destination,ContainerNumber) values (@dp, @des, @cn)";
                SqlCommand userdetail = new SqlCommand(InsertQuery, con);
                userdetail.Parameters.AddWithValue("@dp", TextBox1.Text);
                userdetail.Parameters.AddWithValue("@des", TextBox2.Text);
                userdetail.Parameters.AddWithValue("@cn", TextBox3.Text);
                userdetail.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Failed to assign')</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage.aspx");
        }
    }
}