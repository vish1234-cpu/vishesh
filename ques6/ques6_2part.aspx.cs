using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ques6 
{
    public partial class ques6_2part : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Session["u_name"].ToString();
            TextBox2.Text = Session["password"].ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["u_name"] = TextBox1.Text;
            Session["password"] = TextBox2.Text;
            ViewState["user_name"] = TextBox1.Text;
            ViewState["pass_word"] = TextBox2.Text;

        }

        
    }
}