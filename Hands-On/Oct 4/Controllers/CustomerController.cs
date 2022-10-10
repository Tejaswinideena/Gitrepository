using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oct_4.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SearchCustomer(int id)
        {
            return Content("Tried to find the Customer id= " + id);
        }
        public ActionResult AddCustomer()
        {
            return View();
        }

        public ActionResult GoToGoogle()
        {

            return Redirect("https://www.google.com");
        }


        public ActionResult DeleteCustomer()
        {

            return View();
        }

        [HttpPost]
        public ActionResult DeleteCustomer(int id)
        {

            return View();
        }

        public ActionResult GoToIndexPageofHomeController()
        {
            return RedirectToAction("Contact", "Home");
        }
        public ActionResult ShowCustomer(int id, string pname)
        {

            return Content("ID and Name:" + id + pname);
        }
    }
}