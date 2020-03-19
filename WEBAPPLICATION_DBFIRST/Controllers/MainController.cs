using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBAPPLICATION_DBFIRST.Data;
using WEBAPPLICATION_DBFIRST.Models;

namespace WEBAPPLICATION_DBFIRST.Controllers
{
    [Route("api/[controller]/[action]")] 
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IClass _data;

        /// <summary>
        /// Dependency Injection 
        /// </summary>
        /// <returns></returns>
        public MainController(IClass data) 
        {
            _data = data;
        }


        /// <summary>
        /// 
        /// GET METHOD TO GET THE CUSTOMER DETAILS AND ORDER DETAILS. 
        /// <returns></returns>
        [HttpGet]

        public IActionResult GetDATA()
        {
            try
            {
                var re = _data.GETDATA();
                return Ok(re);
            }

            catch
            {
                throw; 
            }
            
        }

        // <summary>
        /// 
        /// GET METHOD TO GET THE CUSTOMER DETAILS AND ORDER DETAILS PRODUCT DETAILS BY ID.  
        /// <returns></returns>
        /// 
        [HttpGet("{id}")] 
       public IActionResult GETDATAID(int id) 
        {
            try
            {
                var re = _data.GETDATAID(id);
                return Ok(re);
            }
            catch
            {
                throw; 
            }
            
        }

     

        // <summary>
        /// 
        /// INSERT  METHOD  
        /// <returns></returns>

        [HttpPost]

        public IActionResult INSERTDATA(Orders orders) 
        {
            try
            {
                var re = _data.INSERTDATA(orders);
                return Ok(re);
            }
            catch
            {
                throw; 
            }
           
        }

        // <summary>
        /// 
        /// UPDATE METHOD  
        /// <returns></returns>

        [HttpPut("{id}")] 

        public IActionResult UPDATEDATA(int id)
        {
            var re = _data.UPDATEDATA(id);
            return Ok(re); 
        }

        // <summary>
        /// 
        /// DELETE METHOD   
        /// <returns></returns>

        [HttpDelete("{id}")] 

        public IActionResult DELETEDATA(int id) 
        {
            try
            {
                var re = _data.DELETEDATA(id); 
                return Ok(re); 
            }
            catch
            {
                throw; 
            }
        }
    }
}