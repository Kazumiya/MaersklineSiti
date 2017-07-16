using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DDAC
{
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["DDACConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string InsertQuery = "insert into LoginCustomer (Name, Company, Username, Password) values (@name, @company, @username, @password)";
                SqlCommand userdetail = new SqlCommand(InsertQuery, connect);
                userdetail.Parameters.AddWithValue("@name", TextBox3.Text);
                userdetail.Parameters.AddWithValue("@company", TextBox4.Text);
                userdetail.Parameters.AddWithValue("@username", TextBox1.Text);
                userdetail.Parameters.AddWithValue("@password", TextBox2.Text);
                 
                userdetail.ExecuteNonQuery();
                connect.Close();
                Response.Redirect("SubmitShipment.aspx");

            }
            catch
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Failed to register')</script>");
            }
            
        }
    }
}