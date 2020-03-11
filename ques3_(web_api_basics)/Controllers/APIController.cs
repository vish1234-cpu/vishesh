using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ques3__web_api_basics_.Models.Data;  
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ques3__web_api_basics_.Models;

namespace ques3__web_api_basics_.Controllers
{
    public class APIController : ApiController
    {
        Connection c = new Connection(); 

        [HttpPost]  
        public bool Insert()
        {
            var re = c.Insert(); 
            return re;

        }
    }
}
