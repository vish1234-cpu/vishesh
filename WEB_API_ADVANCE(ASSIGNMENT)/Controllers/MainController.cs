using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using WEB_API_ADVANCE_ASSIGNMENT.Data; 
using WEB_API_ADVANCE_ASSIGNMENT.Model;

namespace WEB_API_ADVANCE_ASSIGNMENT.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IEmployee_Interface _employee;

        /// <summary>
        /// Dependency Injection 
        /// </summary>
        /// <returns></returns>
        public MainController(IEmployee_Interface employee)
        {
            _employee = employee;
        }
        /// <summary>
        /// This is Get operation
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetData()
        {
            try
            {
                DataSet ds = _employee.GetData();
                return Ok(ds);
            }
            catch(Exception ex)
            {
                throw ex;
            }

           
        }

        /// <summary>
        /// This is Get operation through a particular id. 
        /// </summary>
        /// <returns></returns>

        [HttpGet("{id}")]
        public IActionResult GetDataId(int id)
        {
            try
            {
                DataSet ds = _employee.GetDataId(id);
                return Ok(ds);
            }

            catch(Exception ex)
            {
                throw ex; 
            }
           
        }


        /// <summary>
        /// This is post operation. 
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        public ActionResult<bool> InsertData(Employees employee)
        {

            try
            {
                if (employee == null)
                {
                    return Ok(BadRequest());
                }


                bool result = _employee.InsertData(employee);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " DATA NOT INSERTED!!!!" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        /// <summary>
        /// This is put operation.  
        /// </summary>
        /// <returns></returns>

        [HttpPut("{id}")]
        public ActionResult<bool> UpdateData(int id,Employees employee)
        {

            try
            {
                if (employee == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _employee.UpdateData( id,employee);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " DATA NOT INSERTED!!!!" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// This is delete operation.  
        /// </summary>
        /// <returns></returns>

        [HttpDelete("{id}")]

        public ActionResult<bool> DeleteData(int id, Employees employee)
        {
          


            try
            {
                if (employee == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _employee.DeleteData(id,employee);  

                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = "DATA NOT INSERTED!!!!" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}