using MvcAssignmentAdvance.Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAssignmentAdvance.Controllers
{
    [RoutePrefix("students")] // route prfix to avoid comman writing of routes.

    public class MainController : Controller
    {
        private readonly StudentService _ser;
        public MainController()
        {
            _ser = new StudentService();
        }

        public ActionResult Home() // this is a home action method 
        { 
            try
            {
                return View();

            }
            catch
            {
                throw; 
            }
        }

        public ActionResult Questions() // this is the question action method 
        {
            try
            {
                return View();

            }
            catch
            {
                throw;
            }
        }

        public ActionResult SignUp() // this is the question action method  
        {
            try
            {
                return View(); 

            }
            catch
            {
                throw;
            }
        }

        public ActionResult Admin()
        {
            try
            {
                return RedirectToAction("Admin","Admin");

            }
            catch
            {
                throw;
            }
        }


        [Route("")] // attribute routing : this will run by only route prefix in url request 
        public ActionResult GetStudents()  // getting the value of all the students by passing in url 
        {
            try
            {
                var result = _ser.GetStudents();
                return View(result);
            }
            catch
            {
                throw; 
            }
           
        }

        [Route("{id}")] // ques4) both the attribute routing is below on the same action method as we can have multiple routes for single action method. 
        [Route("{id}/Details")] // attribute routing 
        public ActionResult GetById(int id) // getting the value of students a particular id passing in url 
        {
            try
            {
                var result = _ser.GetById(id);
                return View(result); 
            }
            catch
            {
                throw; 
            }
           
        }

        public ActionResult ViewModel() // this is the ViewModel action method  
        {
            try
            {
                return View();

            }
            catch
            {
                throw;
            }
        }

        public ActionResult Filters() // this is the Filters action method  
        {
            try
            {
                return View();

            }
            catch
            {
                throw;
            }
        }
    }
}