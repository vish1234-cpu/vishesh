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
    public partial class ques1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            

                // 1) connection object 
                SqlConnection con = new SqlConnection(CS);
            // 2) ExecuteReader() method 
            try
            {
                con.Open();
                // 3) Command object
                    SqlCommand cmd = new SqlCommand("select * from student", con);
                    GridView1.DataSource = cmd.ExecuteReader();
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

            // 4) ExecuteScalar() method 
            try
            {
                SqlCommand cmd1 = new SqlCommand("select count(std_id) from student", con);
                con.Open();
                int total_rows = (int)cmd1.ExecuteScalar();
                Response.Write("TOTAL ROWS ARE :" + total_rows +"<br/>"); 
            }

            catch
            {
                throw new Exception("handle the exception"); 
            }

            finally
            {
                con.Close(); 
            }

            // 5) ExecuteNonQuery() method 
            try
            {
                SqlCommand cmd2 = new SqlCommand("insert into student(std_name,std_class,hobby) values('Shagun',8,'Dancing')", con);
                con.Open();
                int rows = cmd2.ExecuteNonQuery();
                Response.Write("TOTAL ROWS INSERTED:" + rows); 
            }

            catch
            {
                throw new Exception("handle the exception");
            }

            finally
            {
                con.Close(); 
            }

            // 6) DataReader() method 

            try
            {
                SqlCommand cmd4 = new SqlCommand("select * from products", con);
                con.Open();
                SqlDataReader rdr = cmd4.ExecuteReader();
                GridView2.DataSource = rdr;
                GridView2.DataBind(); 

            }
             catch
            {
                throw new Exception("handle the exception"); 
            }

            finally
            {
                con.Close(); 
            }

            //6) DataAdapter() method 
            try
            {
                con.Open(); 
                SqlDataAdapter sda = new SqlDataAdapter("select * from productprice", con);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                GridView3.DataSource = ds;
                GridView3.DataBind();
            }

            catch
            {
                throw new Exception("handle the exception"); 
            }
            finally
            {
                con.Close(); 
            }

            // 7) NextResult()

            try
            {
                SqlCommand cmd5 = new SqlCommand("select * from student;select * from products", con);
                con.Open();

                SqlDataReader rdr = cmd5.ExecuteReader();
                GridView4.DataSource = rdr;
                GridView4.DataBind();

                while (rdr.NextResult())
                {
                    GridView5.DataSource = rdr;
                    GridView5.DataBind();
                }
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