using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration; 

namespace ADO_DOT_NET_ASSIGNMENT
{
    public partial class ques5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        /*
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = con;
           con.Open();
           cmd.CommandText = "select * from products where product_name like '" + TextBox1.Text + "%'";
           GridView1.DataSource = cmd.ExecuteReader();
           GridView1.DataBind();
            */

        //above is the code in which sql injection attack can be carried out by the hacker. 



        // sqlinjection attack prevention by using stored procedure. 
        // never use concatinate queries , this will open the gate for sql injection attacks. 
        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("getbyname", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pro_name", TextBox1.Text + "%");
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string s = TextBox1.Text;
        }
    }
}