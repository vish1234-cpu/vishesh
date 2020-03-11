using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ques2_web_api_basic_.Data
{
    // ques2)  Create a WebAPI endpoint to a single employee data from the table.
    public class Connection
    {
        string CS = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        public DataSet getcol()
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select * from Employee where emp_id=106", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sd.Fill(ds);
                return ds; 
            }
                

        }
    }
}