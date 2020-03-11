using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration; 

namespace ques3__web_api_basics_.Models.Data
{
    //ques3) Create a WebAPI endpoint to create a new record in the database table. 
    public class Connection
    {
        string CS = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        public bool Insert() 
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open(); 
                SqlCommand cmd = new SqlCommand("insert into Employee(emp_name,emp_address,emp_salary) values('Rajesh','Kerela',40000)", con);
                int rows= cmd.ExecuteNonQuery(); 
                
                if(rows>=0)
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