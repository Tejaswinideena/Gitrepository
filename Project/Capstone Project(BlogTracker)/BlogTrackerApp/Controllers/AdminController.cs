using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogDAL;

namespace BlogTrackerApp.Controllers
{
    public class AdminController : Controller
    {
        ValidateAdmin ad = null;
        public AdminController()
        {
            ad = new ValidateAdmin();
        }
        // GET: Admin
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(FormCollection collection)
        {
            bool valid = ad.Validate(Request["EmailID"].ToString(), Request["Password"].ToString());
            if (valid)
            {
                //return RedirectToAction("actionName", "controllerName", null);
                return RedirectToAction("EmpPage", "Emp", null);
            }
            else
            {
                ViewBag.Message = "Email or Password is wrong...";
                return RedirectToAction("AdminLogin");
            }
        }
    }
}