using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Configuration;
using System.Data.SqlClient; 

namespace ques2_web_api_basic_.Controllers
{
    public class APIController : ApiController
    {
        Data.Connection c = new Data.Connection();

        public IHttpActionResult getval()
        {
            DataSet ds = c.getcol();
            return Ok(ds);
        }
    }
}
