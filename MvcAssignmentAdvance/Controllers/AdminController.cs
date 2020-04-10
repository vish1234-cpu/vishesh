using MvcAssignmentAdvance.ExceptionFilter;
using MvcAssignmentAdvance.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAssignmentAdvance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
            [OutputCache(Duration =10,Order =2)]  // these are the orders for the filters first handle error will run then outputcache will run.
            [HandleError(Order = 1)] 
        public ActionResult Admin() // admin signup form 
        {
            try
            {
                return View(); // validation message for and validation summary is on the Admin.cshtml 

            }
            catch
            {
                throw;
            }
        }


        
        [HttpPost]
        [ValidateAntiForgeryToken] // antiforgery token is also used to check the credentials of admin. 
        public ActionResult Admin(Admin admin) // admin identification  
        {
            if (ModelState.IsValid)
            {
                using (MVCEntities db = new MVCEntities())
                {

                    var obj = db.Admins.Where(a => a.UserName.Equals(admin.UserName)).FirstOrDefault();
                    if (obj != null && obj.PassKey == admin.PassKey) // sql server will do case insensitive comparison.
                    {                                              // so compare outisde the where condition. 
                        Session["UserId"] = obj.Id.ToString();
                        Session["UserName"] = obj.UserName.ToString();
                        return RedirectToAction("AdminModule", "Admin"); 
                    }
                   else
                    {
                        return RedirectToAction("Error"); 
                    } 
                   
                }
            }
            return View(admin);
        }

        public ActionResult Error()
        {
            return View(); 
        }

        public ActionResult AdminModule() // admin will get redirect to this view. 
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

        [CustomException] // IException  

        public ActionResult ExceptionArisingMethod() 
        {
            try
            {
                return View("hello");  // this will take you to the error page because there is no view of name "hello".

            }
            catch
            {
                throw;
            }
        } 
    }
}