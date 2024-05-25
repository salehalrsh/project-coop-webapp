using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace pro1
{
    public partial class Defualt : System.Web.UI.Page
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {
                   Label1.Visible = false;
        

       
           }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\94344\documents\visual studio 2013\Projects\pro1\pro1\App_Data\Database1.mdf;Integrated Security=True"))
            {
               
                con.Open();
                string q = "SELECT COUNT(*) FROM Users WHERE Username=@Username AND Passwrod=@Passwrod";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@Username", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@Passwrod", TextBox.Text.Trim());
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    Session["Username"] = TextBox1.Text.Trim();
                    Response.Redirect("HomePage.aspx");
                }
                else { 
                    Label1.Visible = true; 
                }

                con.Close();
            }
         }
       }
    }
