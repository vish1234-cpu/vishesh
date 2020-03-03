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
    public partial class ques6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            

        }

        public void myfunc()
        {
            string CS = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);

            con.Open();

            SqlCommand cmd1 = new SqlCommand("select * from employee",con);
            SqlDataReader red = cmd1.ExecuteReader();
            GridView1.DataSource = red;
            GridView1.DataBind(); 


        }
       

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);

            con.Open();
            SqlTransaction st = con.BeginTransaction();

            try
            {
                SqlCommand cmd = new SqlCommand("update employee set emp_sal=emp_sal-100 where emp_id=102", con, st);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("update employee set emp_sal=emp_sal+100 where emp_id=103", con, st);
                cmd.ExecuteNonQuery();
                st.Commit();
                Label1.Text = "Transaction complete";

            }

            catch
            {
                st.Rollback();
                Label1.Text = "Transaction Failed";
            }
            finally
            {
                con.Close(); 
            }

            myfunc();

        }
    }
}