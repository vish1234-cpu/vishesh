using MVC_ASSIGNMENT1.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ASSIGNMENT1.Controllers
{
    public class MainController : Controller
    {
        private readonly StudentService _std;
        public MainController()
        {
            _std = new StudentService();
        }

        public ActionResult GetAllStudents() //ques3. passing data from controller to view using viewbag. 
        {
            try
            {
                var result = _std.GetAllStudents();
                ViewBag.list = result; // viewbag is a dynamic container that doest need any type casting . 
                return View();
            }
            catch
            {
                throw;
            }

        }


        public ActionResult Home()  // home page 
        {
            try
            {
                return View();

            }
            catch(Exception ex)
            {
                throw ex; 
            }
        }

        public ActionResult Questions() // questions (all the questions are inside the nav link "Questions")
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

        public ActionResult AboutMVC() // ques1.  
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

        public ActionResult MVCLifeCycle() // ques2. 
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

        public ActionResult DataPass() // ques3. 
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

        public ActionResult Use() // ques4. 
        {
            try
            {
                return RedirectToAction("Use", "Main1");  // ques6. passsing data from one controller to another controller. 

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
                return RedirectToAction("Differnce", "Main1"); // ques6.passsing data from one controller to another controller.

            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

    }
}