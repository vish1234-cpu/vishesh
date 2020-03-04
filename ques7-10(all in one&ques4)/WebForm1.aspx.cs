using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ques7_10_all_in_one_
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) //----ques4(postback)----// 
        {
            if (!IsPostBack)
            {
                stu_name.Focus();
            }

        }

        protected void StudentRegister(object sender, EventArgs e) 
        {
            string CS = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS)) 
            {

                //----validations are added(ques9)-----//
                SqlCommand cmd = new SqlCommand("insert into student_data(student_name,student_age,std_password,std_email) values(@stu_name,@stu_age,@stu_pass,@stu_email)", con);
                cmd.Parameters.AddWithValue("@stu_name", stu_name.Text);
                cmd.Parameters.AddWithValue("@stu_age", stuage.Text);
                cmd.Parameters.AddWithValue("@stu_pass", stupass.Text);
                cmd.Parameters.AddWithValue("@stu_email", stuemail.Text);


                try  //----nested try-catch(ques10)-------//
                {
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        Label1.Text = "Data inserted in the form successfully! </br> Congratulations!!";
                        con.Close();
                    }
                    catch (SqlException)
                    {
                        Console.WriteLine("This is a Sql Exception!! Handle it!!");
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("I am super class exception!!");
                }
                SqlCommand cmd1 = new SqlCommand("select * from student_data", con);
                con.Open();
                GridView1.DataSource = cmd1.ExecuteReader();
                GridView1.DataBind();
                con.Close();

            }
        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            switch (e.CommandName) ///-----button events(ques7)-----////
            {
                case "Button1":
                    Label2.Text = "command event of button 1";
                    break;
                case "Button2":
                    Label3.Text = "command event of button 2";
                    break;

            }
        }
    }
}