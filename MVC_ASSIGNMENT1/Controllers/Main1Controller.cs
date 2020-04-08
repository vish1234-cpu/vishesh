using MVC_ASSIGNMENT1.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ASSIGNMENT1.Controllers
{
    public class Main1Controller : Controller
    {
     
        // The below methods are of Main1 Controller whose navigations are coming from Main Controller.
        public ActionResult Use() // ques4. 
        {
            try
            {
                return View();

            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        public ActionResult Differnce() // ques5. 
        {
            try
            { 
                return View();

            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }
    }
}