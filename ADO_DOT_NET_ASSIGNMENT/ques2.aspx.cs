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
    public partial class ques2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String CS = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            SqlConnection con = new SqlConnection(CS); 

            //Connected Architecture using DataReader()  and Nextresult()
             try
            {
                SqlCommand cmd1 = new SqlCommand("select * from products;select * from productprice", con);
                con.Open(); 
                SqlDataReader rdr = cmd1.ExecuteReader();
                GridView1.DataSource = rdr;
                GridView1.DataBind(); 

                while(rdr.NextResult())
                {
                    GridView2.DataSource = rdr;
                    GridView2.DataBind(); 
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

            //Disconnected Architecture by DataAdapter() method 
            using(SqlDataAdapter sda = new SqlDataAdapter("select * from product_inventory",con))
            {
                DataSet ds = new DataSet();
                sda.Fill(ds);

                GridView3.DataSource = ds;
                GridView3.DataBind(); 
            }
        }
    }
}