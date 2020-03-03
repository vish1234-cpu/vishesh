using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration; 

namespace ADO_DOT_NET_ASSIGNMENT 
{
    public partial class ques3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);

            //ExecuteReader(): it is used to return the whole row values or a full table. 
            try
            {
                SqlCommand cmd1 = new SqlCommand("select * from products", con);
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

            // ExecuteScalar() method 

            try
            {
                SqlCommand cmd2 = new SqlCommand("select count(product_id) from products", con);
                con.Open();
                int tot_rows = (int)cmd2.ExecuteScalar();
                Response.Write("Total Ids are:" + tot_rows + "<br/>");
            }
            catch
            {
                throw new Exception("handle the exception");
            }
            finally
            {
                con.Close();
            }

            //ExecuteNonQuery() method 
            try
            {
                SqlCommand cmd3 = new SqlCommand("insert into products(product_name,quantity) values('Bat',8)", con);
                con.Open(); 
                int rr = cmd3.ExecuteNonQuery();
                Response.Write("Total rows updated:"+ rr); 
            }
            catch
            {
                throw new Exception("handle the exception");
            }
            finally
            {
                con.Close();
            }
        }
    }
}