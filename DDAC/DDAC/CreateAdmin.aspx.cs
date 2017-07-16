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
    public partial class CreateAdmin : System.Web.UI.Page
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
                string InsertQuery = "insert into LoginAdmin (Username,Password) values (@name, @pass)";
                SqlCommand userdetail = new SqlCommand(InsertQuery, con);
                userdetail.Parameters.AddWithValue("@name", TextBox1.Text);
                userdetail.Parameters.AddWithValue("@pass", TextBox2.Text);
                userdetail.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Failed to add admin')</script>");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage.aspx");
        }
    }
}