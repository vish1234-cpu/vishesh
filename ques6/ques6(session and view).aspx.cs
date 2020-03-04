using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ques6 // this question contains session state and view state. and application state is same as that of ques5. 
{
    public partial class ques6_session_and_view_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["u_name"] = TextBox1.Text;
            Session["password"] = TextBox2.Text;
            ViewState["user_name"] = TextBox3.Text;
            ViewState["pass_word"] = TextBox4.Text;
            Response.Redirect("ques6_2part.aspx"); 
        } 
    }
}