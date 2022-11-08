using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogDAL;
using BlogTrackerApp.Models;

namespace BlogTrackerApp.Controllers
{
    public class EmpController : Controller
    {
        EmpInfoDAL helper = null;
        public EmpController()
        {
            helper = new EmpInfoDAL();
        }
        // GET: Emp
        public ActionResult EmpPage()
        {
            var emplist = helper.GetAllEmployeeDetails();
            List<EmpModel> m = new List<EmpModel>();
            foreach(var item in emplist)
            {
                m.Add(new EmpModel { Passcode = item.Passcode, EmailID = item.EmailID, Name = item.Name , DateOfJoining = item.DateOfJoining});
            }
            return View(m);
        }

        // GET: Emp/Details/5
        public ActionResult EmpDetails(int id)
        {
            var data = helper.GetEmployeeDetailsByPasscode(id);
            EmpModel emp = new EmpModel();
            emp.Passcode = id;
            emp.EmailID = data.EmailID;
            emp.Name= data.Name;
            emp.DateOfJoining = data.DateOfJoining;
            return View(emp);
        }
        public ActionResult AddEmployee()
        {
            return View();
        }

        // GET: Emp/Create
        [HttpPost]
        public ActionResult AddEmployee(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                EmpInfo bal = new EmpInfo();
                bal.Passcode = Convert.ToInt32(Request["Passcode"]);
                bal.EmailID = Request["EmailID"].ToString();
                bal.Name = Request["Name"].ToString();
                bal.DateOfJoining = Convert.ToDateTime(Request["DateOfJoining"]);

                bool ans = helper.AddEmp(bal);
                if (ans)
                {
                    return RedirectToAction("EmpPage");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.exMsg = ex.Message;
                return View();
            }
        }

        // GET: Emp/Edit/5
        public ActionResult EditEmp(int id)
        {
            var emp = helper.GetEmployeeDetailsByPasscode(id);
            EmpModel model = new EmpModel();
            model.Passcode = id;
            model.EmailID = emp.EmailID;
            model.Name = emp.Name;
            model.DateOfJoining = emp.DateOfJoining;
            return View(model);
        }

        // POST: Emp/Edit/5
        [HttpPost]
        public ActionResult EditEmp(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var emp = helper.GetEmployeeDetailsByPasscode(id);
                emp.Passcode = Convert.ToInt32(Request["Passcode"]);
                emp.EmailID = Request["EmailID"].ToString();
                emp.Name = Request["Name"].ToString();
                emp.DateOfJoining = Convert.ToDateTime(Request["DateOfJoining"]);
                bool ans = helper.UpdateEmployeeDetails(id,emp);
                if (ans)
                {
                    return RedirectToAction("EmpPage");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Emp/Delete/5
        public ActionResult DeleteEmp(int id)
        {
            var emp = helper.GetEmployeeDetailsByPasscode(id);
            EmpModel model = new EmpModel();
            model.Passcode = id;
            model.EmailID = emp.EmailID;
            model.Name = emp.Name;
            model.DateOfJoining = emp.DateOfJoining;
            return View(model);
        }

        // POST: Emp/Delete/5
        [HttpPost]
        public ActionResult DeleteEmp(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var dataFound = helper.GetEmployeeDetailsByPasscode(id);
                if (dataFound != null)
                {
                    bool ans = helper.DeleteEmployeeDetails(id);
                    if (ans)
                    {
                        return RedirectToAction("EmpPage");
                    }
                    else
                    {
                        return View();
                    }
                }

                return RedirectToAction("EmpPage");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult EmpLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EmpLogin(FormCollection collection)
        {
            bool valid = helper.ValidateEmp(Request["EmailID"].ToString(), Convert.ToInt32(Request["Passcode"]));
            if (valid)
            {
                //return RedirectToAction("actionName", "controllerName", null);
                return RedirectToAction("BlogPage", "Blog", null);
            }
            else
            {
                ViewBag.Message = "Email or Passcode is wrong...";
                return RedirectToAction("EmpLogin");
            }
        }
    }
}
