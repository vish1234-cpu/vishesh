using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using WEB_API_ADVANCE_ASSIGNMENT.Model;

namespace WEB_API_ADVANCE_ASSIGNMENT.Data
{
    public class IEmployeeClass : IEmployee_Interface 
    {
        Model.Employees employee = new Employees(); 

        private readonly IOptions<Connection> _connection;



        /// <summary>
        /// Dependency Injection 
        /// </summary>
        /// <returns></returns>

        public IEmployeeClass(IOptions<Connection> connection)
        {
            _connection = connection;
        }

        public DataSet GetData()
        {
            try
            {
                string CS = _connection.Value.ConnectionString;
                SqlConnection con = new SqlConnection(CS);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Employees", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }
            catch (SqlException ex)
            {

                throw ex; 
            }

        }

        public DataSet GetDataId(int id)
        {
            try
            {
                string CS = _connection.Value.ConnectionString;
                SqlConnection con = new SqlConnection(CS);
                SqlCommand cmd = new SqlCommand("select * from Employees where Id=" + id, con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }

            catch(SqlException ex)
            {
                throw ex; 
            }
           
        }

        public bool InsertData(Employees employee)
        {
            string CS = _connection.Value.ConnectionString;

            try
            {


                SqlConnection con = new SqlConnection(CS);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Employees(FirstName,LastName,Gender,Salary) values(@fn,@ln,@gender,@sal)", con);
                cmd.Parameters.AddWithValue("@fn", employee.FirstName); 
                cmd.Parameters.AddWithValue("@ln", employee.LastName);
                cmd.Parameters.AddWithValue("@gender", employee.Gender);
                cmd.Parameters.AddWithValue("@sal", employee.Salary); 



                int result = cmd.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                    return true;
                else
                    return false;

            }
            catch (SqlException ex)
            {

                throw ex;

            }
            finally
            {
                
            }
        }


        public bool UpdateData(int id, Employees employee)
        {
            string CS = _connection.Value.ConnectionString;

            try
            {
                SqlConnection con = new SqlConnection(CS);
                con.Open();
                SqlCommand cmd = new SqlCommand("update Employees set FirstName=@fn where Id="+id, con);

                cmd.Parameters.AddWithValue("@id", employee.Id);
                cmd.Parameters.AddWithValue("@fn", employee.FirstName); 




                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                    return true;
                else
                    return false;

            }
            catch (SqlException ex)
            {

                throw ex;

            }
            finally
            {

            }
        }


        public bool DeleteData(int id,Employees employee) 
        {
            string CS = _connection.Value.ConnectionString;
            try
            {

                SqlConnection con = new SqlConnection(CS);
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Employees where Id= " +id, con);

                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
    }
}
