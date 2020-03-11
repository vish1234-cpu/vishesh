using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ques4_web_api_basics_.Data; 

namespace ques4_web_api_basics_.Controllers
{
    public class APIController : ApiController
    {
        Connection c = new Connection();

        [HttpPut] 
        public bool update()
        {
            var re = c.update(); 
            return re;

        }
    }
}
