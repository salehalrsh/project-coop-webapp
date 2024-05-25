using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace pro1
{
    
    public partial class SignupPage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\94344\documents\visual studio 2013\Projects\pro1\pro1\App_Data\Database1.mdf;Integrated Security=True");
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Username"] == null)
            {

                //Response.Redirect("Defualt.aspx");
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            //Session.Abandon();
            //metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=(LocalDB)\v11.0;attachdbfilename=|DataDirectory|\Database1.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient"
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;                                                          // sesion user name //, 10 , reslbl.text
            cmd.CommandText = "insert into [dbo].[Users] ([Username], [Full Name], [Passwrod]) VALUES ('" + username.Text + "', '" + Name1.Text + "', '" + password.Text + "')";
            // cmd.CommandText = "insert into CreateUsers values('ali111','hamad11111','jubail111')";
            
            con.Open();
            try
            {
                int rows = cmd.ExecuteNonQuery();
                Response.Redirect("Defualt.aspx");

            }
            catch (Exception)
            {
                username.Text = "Error: username already taken";
                
            }
            con.Close();

            //username.Text = "";
            //Name1.Text = "";
            //password.Text = "";

        }
    }
}