using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ques4_web_api_basics_.Data 
{
    //ques4) Create a WebAPI endpoint to update an employee record in the database table.
    public class Connection
    {
        string CS = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        public bool update() 
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Employee SET emp_name = 'Majid', emp_address= 'Jhilmil' where emp_id = 101", con); 
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