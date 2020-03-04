using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ques5
{
    public class Global : HttpApplication
    {
       
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup  
            Application["Online Users At a Time:"] = 0;
        }
        void Session_Start(object sender, EventArgs e)
        {

            Application.Lock();
            Application["Online Users At a Time:"] = (int)Application["Online Users At a Time:"] + 1;
            Application.UnLock();
        }

        void Session_End(object sender, EventArgs e)
        {

            Application.Lock();
            Application["Online Users At a Time:"] = (int)Application["Online Users At a Time:"] - 1;
            Application.UnLock();
        }
    }
}