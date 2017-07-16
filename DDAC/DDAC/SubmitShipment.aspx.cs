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
    public partial class SubmitShipment : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DDACConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerLogin.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string InsertQuery = "insert into SubmitShipment (Date, CargoType, Quantity) values (@dt, @cr, @qt)";
                SqlCommand userdetail = new SqlCommand(InsertQuery, con);
                userdetail.Parameters.AddWithValue("@dt", TextBox1.Text);
                userdetail.Parameters.AddWithValue("@cr", TextBox2.Text);
                userdetail.Parameters.AddWithValue("@qt", TextBox3.Text);
                userdetail.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Failed to submit')</script>");
            }
        }
    }
}