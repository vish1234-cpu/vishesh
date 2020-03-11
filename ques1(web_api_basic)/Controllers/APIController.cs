using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_api_Assignment_Basic_.Data;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Web_api_Assignment_Basic_.Controllers
{
    public class APIController : ApiController
    {
        Data.Connection c = new Data.Connection();

        public IHttpActionResult getval()
        {
            DataSet ds = c.getval(); 
            return Ok(ds); 
        }
    }
}
