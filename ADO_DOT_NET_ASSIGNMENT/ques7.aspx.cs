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
    public partial class ques7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           Response.Write("improve system performance with the use of database caching and disconnected architecure"); 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            if (Cache["Stock"] == null)
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from product_inventory", con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    GridView1.DataSource = ds;
                    GridView1.DataBind();

                    Cache["Stock"] = ds;
                    Label1.Text = "data came from database";

                }
            }
            else
            {

                GridView2.DataSource =(DataSet)Cache["Stock"]; 
                GridView2.DataBind(); 
                Label1.Text = "data came from cache"; 
            }
        }
    }
}