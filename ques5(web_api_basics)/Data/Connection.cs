using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ques5_web_api_basics_.Data

{ //ques5) Create a WebAPI endpoint to delete an employee record in the database table.
    public class Connection
    {
        string CS = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        public bool Delete()
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Employee where emp_id = 102", con); 
                int rows = cmd.ExecuteNonQuery();

                if (rows >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


        }
    }
}