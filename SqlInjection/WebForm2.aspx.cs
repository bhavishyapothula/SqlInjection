using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlInjection
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString))
            {
                var UN = uname.Text;
                var PW = password.Text;
                SqlCommand command;
                // string qry = "select * from Login where UserName= '' or 1=1 ;



                command = new SqlCommand("UserLogin", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("UserName", UN);
                command.Parameters.AddWithValue("Password", PW);
                
                con.Open();
                SqlDataReader sqlDataReader = command.ExecuteReader();

               
                if (sqlDataReader.HasRows)
                {
                    Response.Redirect("WebForm1.aspx");
                }
                else
                {
                    Response.Write("Invalid Credentials.");
                }
            }
        }
    }
}
