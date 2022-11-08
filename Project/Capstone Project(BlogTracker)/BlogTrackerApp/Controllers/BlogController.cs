using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogDAL;
using BlogTrackerApp.Models;

namespace BlogTrackerApp.Controllers
{
    public class BlogController : Controller
    {
        BlogInfoDAL helper = null;
        public BlogController()
        {
            helper = new BlogInfoDAL();
        }
        // GET: Emp
        public ActionResult BlogPage()
        {
            var list = helper.GetAllBlogDetails();
            List<BlogModel> m = new List<BlogModel>();
            foreach (var item in list)
            {
                m.Add(new BlogModel { BlogID = item.BlogID, Title = item.Title, Subject = item.Subject, DateOfCreation = item.DateOfCreation, BlogURL = item.BlogURL, EmpEmailID = item.EmpEmailID });
            }
            return View(m);
        }
        public ActionResult BlogHomePage()
        {
            var list = helper.GetAllBlogDetails();
            List<BlogModel> m = new List<BlogModel>();
            foreach (var item in list)
            {
                m.Add(new BlogModel { Title = item.Title, Subject = item.Subject, DateOfCreation = item.DateOfCreation, BlogURL = item.BlogURL, EmpEmailID = item.EmpEmailID });
            }
            return View(m);
        }

        // GET: Emp/Details/5
        public ActionResult BlogDetails(int id)
        {
            var data = helper.GetAllBlogDetailsByBlogID(id);
            BlogModel emp = new BlogModel();
            emp.BlogID = id;
            emp.Title = data.Title;
            emp.Subject = data.Subject;
            emp.DateOfCreation = data.DateOfCreation;
            emp.BlogURL = data.BlogURL;
            emp.EmpEmailID = data.EmpEmailID;
            return View(emp);
        }

        public ActionResult AddaBlog()
        {
            return View();
        }

        // GET: Emp/Create
        [HttpPost]
        public ActionResult AddaBlog(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                BlogInfo bal = new BlogInfo();
                bal.BlogID = Convert.ToInt32(Request["BlogID"]);
                bal.Title = Request["Title"].ToString();
                bal.Subject = Request["Subject"].ToString();
                bal.DateOfCreation = Convert.ToDateTime(Request["DateOfCreation"]);
                bal.BlogURL = Request["BlogURL"].ToString();
                bal.EmpEmailID = Request["EmpEmailID"].ToString();

                bool ans = helper.AddBlog(bal);
                if (ans)
                {
                    return RedirectToAction("BlogPage");
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
        public ActionResult EditBlog(int id)
        {
            var emp = helper.GetAllBlogDetailsByBlogID(id);
            BlogModel model = new BlogModel();
            model.BlogID = id;
            model.Title = emp.Title;
            model.Subject = emp.Subject;
            model.DateOfCreation = emp.DateOfCreation;
            model.BlogURL = emp.BlogURL;
            model.EmpEmailID = emp.EmpEmailID;
            return View(model);
        }

        // POST: Emp/Edit/5
        [HttpPost]
        public ActionResult EditBlog(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var emp = helper.GetAllBlogDetailsByBlogID(id);
                emp.BlogID = Convert.ToInt32(Request["BlogID"]);
                emp.Title = Request["Title"].ToString();
                emp.Subject = Request["Subject"].ToString();
                emp.DateOfCreation = Convert.ToDateTime(Request["DateOfCreation"]);
                emp.BlogURL = Request["BlogURL"].ToString();
                emp.EmpEmailID = Request["EmpEmailID"].ToString();
                bool ans = helper.UpdateBlogDetails(id, emp);
                if (ans)
                {
                    return RedirectToAction("BlogPage");
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
        public ActionResult DeleteBlog(int id)
        {
            var emp = helper.GetAllBlogDetailsByBlogID(id);
            BlogModel model = new BlogModel();
            model.BlogID = id;
            model.Title = emp.Title;
            model.Subject = emp.Subject;
            model.DateOfCreation = emp.DateOfCreation;
            model.BlogURL = emp.BlogURL;
            model.EmpEmailID = emp.EmpEmailID;
            return View(model);
        }

        // POST: Emp/Delete/5
        [HttpPost]
        public ActionResult DeleteBlog(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var dataFound = helper.GetAllBlogDetailsByBlogID(id);
                if (dataFound != null)
                {
                    bool ans = helper.DeleteBlogDetails(id);
                    if (ans)
                    {
                        return RedirectToAction("BlogPage");
                    }
                    else
                    {
                        return View();
                    }
                }

                return RedirectToAction("BlogPage");
            }
            catch
            {
                return View();
            }
        }
    }
}
