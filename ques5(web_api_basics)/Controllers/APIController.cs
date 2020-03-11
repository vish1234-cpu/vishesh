using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ques5_web_api_basics_.Data;
using System.Data.SqlClient;
using System.Data;
using System.Configuration; 

namespace ques5_web_api_basics_.Controllers
{
    public class APIController : ApiController
    {
        Connection c = new Connection();

        [HttpDelete] 
        public bool Delete()
        {
            var re = c.Delete(); 
            return re;

        }
    }
}
