using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Web_api_Assignment_Basic_.Data
{
    // ques1) Create a WebAPI endpoint to get all employee data from the table.
    public class Connection
    {
        string CS = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        public DataSet getval() 
        {
            using (SqlConnection con = new SqlConnection(CS))
            {

                SqlCommand cmd = new SqlCommand("select * from Employee ", con); 
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sd.Fill(ds);
                return ds; 
            }


        }

    }
}