using MVCASSIGNMENT2.Models.Entity;
using MVCASSIGNMENT2.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCASSIGNMENT2.Controllers
{
    public class MainController : Controller 
    {
        private readonly EmployeeService _emp; // object for service class. 
        public MainController()
        {
            _emp = new EmployeeService(); 
        }

        public ActionResult Home() // home page method. 
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

        public ActionResult Questions() // questions method in which all the questions are present. 
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

        public ActionResult PartialTypes() // ques1) RenderPartial, Partial and Render Action with examples 
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

        [HttpGet] 
        public ActionResult GetList() // this method representing the view. this will return the list of employees using entity framework. 
        {
            try
            {
                var result = _emp.GetEmployees();
                return View(result);  
            }
            catch
            {
                throw;
            }
          

        }
        public ActionResult EmployeeResgistrationForm() // employee registration form and the partial view of form is created 
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
        [HttpPost]
        public ActionResult InsertEmployee([Bind(Include = "EmployeeId,EmployeeFirstName,EmployeeLastName,EmployeeAddress,EmployeeGender")]Employee employee)  // insert action method whose services and interface is in models folder. 
        {
            try
            {
                _emp.InsertEmployee(employee);
                return RedirectToAction("GetList","Main");  
            }
            catch
            {
                throw; 
            }
          
        }

        public ActionResult Child() //  ques2) NoAction, ChildActionOnly with example
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

        [NonAction]  // non action attribute 
        public ActionResult NonAction() // this is a non action method which cannot be invoked by direct url request. 
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

        [ChildActionOnly] // child action only attribute 
        public ActionResult ChildAction() //this is a child ony action method which can be invoked by child reques request. 
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


        public ActionResult RenderSection() //  ques3) Render Section and CShtml function with examples.Why do we use the “Bind'' attribute in the action parameter
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

        public ActionResult Layout() // ques4) Explain Layout and how to set layout into view from Controller, View or globally
        {
            try 
            {

                var MyLayout = View();
                MyLayout.MasterName = "~/Views/Shared/_LayoutPage.cshtml"; 
                return MyLayout;  

            }
            catch
            {
                throw;
            }
        }

        public ActionResult Bundles() // ques5) What is bundling and how to use bundling in view. 
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