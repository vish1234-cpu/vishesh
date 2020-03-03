using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data; 

namespace ADO_DOT_NET_ASSIGNMENT
{
    public partial class ques10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            // The connection can be handled by two methods:
            // 1) by using "Using method".
            // 2) by keeping the connection in try,catch and finally. (exception handling).



            //by keeping the connection in try,catch and finally. (exception handling).
            SqlConnection con = new SqlConnection(CS);
            try
            {
               
                SqlCommand cmd1 = new SqlCommand("select * from product_inventory", con);
                con.Open();
                GridView1.DataSource = cmd1.ExecuteReader();
                GridView1.DataBind();
            }

            catch
            {
                throw new Exception("handle the exception");
            }

            finally
            {
                con.Close(); 
            }


           // by using "Using method"

            using(SqlCommand cmd2 = new SqlCommand("select * from student where std_name='Sonal'",con))
            {
                con.Open(); 
                GridView2.DataSource = cmd2.ExecuteReader();
                GridView2.DataBind(); 
            }

        }
    }
}