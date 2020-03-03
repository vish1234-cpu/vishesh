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
    public partial class ques4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // connection oriented: Datareader() method it needs the connection to open explicitly. 
            string CS = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            SqlConnection con = new SqlConnection(CS); // connection object is also connection oriented. 

            try
            {
                SqlCommand cmd1 = new SqlCommand("select * from product_inventory", con); //command object is also connection oriented

                con.Open(); // the connection is opened. 
                SqlDataReader rdr = cmd1.ExecuteReader();
                GridView1.DataSource = rdr;
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

            // Disconnected architecture using DataAdapter() method in which we dont have to explicitly open and close the connection.

            using (SqlDataAdapter sda = new SqlDataAdapter("select * from product_inventory", con))
            { 

                DataSet ds = new DataSet();
                sda.Fill(ds);

                GridView2.DataSource = ds;
                GridView2.DataBind();
            }
           

            
        }
    }
}