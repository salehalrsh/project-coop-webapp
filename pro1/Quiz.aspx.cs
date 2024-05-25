using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace pro1
{

    public partial class Quiz : System.Web.UI.Page
    {
        string o = null;
        string op = null;



        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Username"] == null)
                Response.Redirect("Defualt.aspx");

            int cur = countUserRes();
            if (cur == 1)
            {
                ExtSql("update  [dbo].[Users] set Status=2 where Username ='" + HttpContext.Current.Session["Username"] + "'");
                Button1.Visible = false;
                Button2.Visible = true;
                Qdiv.InnerText = "";
                string restext = "";

                using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\94344\documents\visual studio 2013\Projects\pro1\pro1\App_Data\Database1.mdf;Integrated Security=True"))
                {

                    cn.Open();
                    string sql = "select sum(a.score) from Option1 a, UERS_RESULT b where a.Op_Id= CONVERT(int, CONVERT(varchar, b.Op_id)) and b.Username like '" + HttpContext.Current.Session["Username"] + "'";


                    SqlDataAdapter adapter = new SqlDataAdapter(sql, cn);

                    DataSet res = new DataSet();

                    adapter.Fill(res, "UERS_RESULT");

                    foreach (DataRow pRow in res.Tables["UERS_RESULT"].Rows)
                    {
                        if (Convert.ToInt32(pRow[0].ToString()) > 6) {
                            restext = "<div>Congrglaitoin you pass the test</div>";
                            restext += "<div>your score is: </div>";
                            restext += "<div>" + pRow[0].ToString() + "</div>";
                        }
                        else
                        {
                            restext = "<div>You did not pass the test</div>";
                            restext += "<div>your score is: </div>";
                            restext += "<div>" + pRow[0].ToString() + "</div>";
                        }
                    }
                }

                //select sum(a.score) from Option1 a, UERS_RESULT b where a.Op_Id= CONVERT(int, CONVERT(varchar, b.Op_id)) and b.Username like 'abc1234567890'
               

                Qdiv.InnerHtml = restext;
            }

            //for (int x = 0; x < 9; x++)
            //{
            //    xary[x] = 0;
            //}
            

  
        }

        protected void get_Q (int x){

         //   Qdiv.InnerHtml = "";

         

            using(  SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\94344\documents\visual studio 2013\Projects\pro1\pro1\App_Data\Database1.mdf;Integrated Security=True")) {

                Session["pQ_id"] = x;

                cn.Open();
                o = "SELECT Q_Text, imgPath FROM Question where Q_id=" + x;
                op = "SELECT Op_text, op_id FROM Option1 where Q_id=" + x;

               SqlDataAdapter adapter = new SqlDataAdapter(o, cn);
                SqlDataAdapter adapter1 = new SqlDataAdapter(op, cn);

                DataSet res = new DataSet();

                adapter.Fill(res, "Question");

                DataSet resOP = new DataSet();

                adapter1.Fill(resOP, "Option1");
                Qdiv.InnerHtml = "<div class='Question'>";

                foreach (DataRow pRow in res.Tables["Question"].Rows)
                {
                              try
                                  {
                                     Image1.ImageUrl = (string)pRow[1];
                                   }
                                   catch
                                 {

                                   }
                    Qdiv.InnerHtml += "<h1>" + pRow[0] + "</h1><div class='line2'></div>";
                    foreach (DataRow oRow in resOP.Tables["Option1"].Rows)
                    {
                        Qdiv.InnerHtml += "<div class='Option'><span><input type='radio' id='" + oRow[1] + "' name='option' class='radio' onclick='opclick(this.id)'><label  for='" + oRow[1] + "' class='option'>" + oRow[0] + "</label></span></div>";
                    }
                }
                Qdiv.InnerHtml += "</div>";

                Button1.Enabled = false;

                cn.Close();
            }

    }
        public static int countUserRes()
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\94344\documents\visual studio 2013\Projects\pro1\pro1\App_Data\Database1.mdf;Integrated Security=True"))
            {

                cn.Open();
                string sql = "SELECT count(RES_Id) FROM UERS_RESULT where Username like '" + HttpContext.Current.Session["Username"] + "'";


                SqlDataAdapter adapter = new SqlDataAdapter(sql, cn);

                DataSet res = new DataSet();

                adapter.Fill(res, "UERS_RESULT");

                foreach (DataRow pRow in res.Tables["UERS_RESULT"].Rows)
                {
                    if (Convert.ToInt32(pRow[0].ToString()) > 9) {

                        return 1; //test is done
                    }
                    return 0;
                }
                return -1;
            }
                
        }
         public static int checkQid(int x) 
        {

            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\94344\documents\visual studio 2013\Projects\pro1\pro1\App_Data\Database1.mdf;Integrated Security=True"))
            {

                cn.Open();
                string sql = "SELECT count(RES_Id) FROM UERS_RESULT where Q_id like '" + x + "' and Username like '" + HttpContext.Current.Session["Username"] + "'";


                SqlDataAdapter adapter = new SqlDataAdapter(sql, cn);

                DataSet res = new DataSet();

                adapter.Fill(res, "UERS_RESULT");
                
                foreach (DataRow pRow in res.Tables["UERS_RESULT"].Rows)
                {
                    if (Convert.ToInt32(pRow[0].ToString()) == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
                return -1;

            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {




            if (Button1.Text == "Start")
            {
                int rand = randfun();
                get_Q(rand);
                Button1.Text = "Next";
                ExtSql("update  [dbo].[Users] set Status=1 where Username ='" + Session["Username"] + "'");
            }
            else
            {
                
                ExtSql("INSERT INTO [dbo].[UERS_RESULT] ([Username], [Q_id], [Op_id], [date]) VALUES ( '" + Session["Username"] + "', N'" + Session["pQ_id"] + "', N'" + oplbl.Value + "', '" + DateTime.Now.ToString() + "')");
            int cur = countUserRes();
            if (cur == 0)
            {
                get_Q(randfun());
            }
            else
            {
                Response.Redirect(Request.RawUrl);
            }
            }
           // oplbl1.Text = Session["pQ_id"].ToString() ;
            
            
        }
        protected int randfun(){

           Random xrand = new Random();
           int xint;
           int s; // check the random number if it is repeated in the table it will return 1 if not return 0 if error retrun -1

           for (int i=0; i<100; i++ ){
               xint = xrand.Next(1, 13);
               s = checkQid(xint);
               if (s == 0)
               {
                   return xint;
                   
               }
               
           }
           return -1;

        }

        protected void ExtSql(string asd)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\94344\documents\visual studio 2013\Projects\pro1\pro1\App_Data\Database1.mdf;Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;                                                          // sesion user name //, 10 , reslbl.text
                cmd.CommandText = asd;
                    //"insert into [dbo].[Users] ([Username], [Full Name], [Passwrod]) VALUES ('" + username.Text + "', '" + Name1.Text + "', '" + password.Text + "')";


                con.Open();
                try
                {
                    int rows = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    oplbl1.Text = e.Message;
                }
                    

                con.Close();
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //delet all user result and refrsh the page
            ExtSql("delete from UERS_RESULT where Username like '" + Session["Username"] + "'");
            Response.Redirect(Request.RawUrl);
        }
        
    }
}