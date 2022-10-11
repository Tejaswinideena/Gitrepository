using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Oct_7.Models;

namespace Oct_7.Controllers
{
    public class LibraryController : Controller
    {
        // GET: Library
        BookOperation h = null;
        public LibraryController()
        {
            h = new BookOperation();

        }
        List<BookModel> modelsList = new List<BookModel>();
        public ActionResult Index()
        {
            var emplist = h.GetAllBooks();
            List<BookModel> modelsList = new List<BookModel>();
            foreach (var item in emplist)
            {
                modelsList.Add(new BookModel { Bookid = item.Bookid, BookName = item.BookName, cost = item.cost, Author = item.Author, memberid = item.memberid });
            }

            return View(modelsList);

        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: NW_Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                BLClass1 bal = new BLClass1();
                bal.Bookid = Convert.ToInt32(Request["EmployeeID"]);
                bal.BookName = Request["Bookname"].ToString();
                bal.Author = Request["Author"].ToString();
                //  bal.Category = Request["Category"].ToString();
                bal.cost = Convert.ToInt32(Request["cost"]);
                bal.memberid = Convert.ToInt32(Request["member_id"]);

                h.InsertBook(bal);
                /* if (ans)
                 {
                     return RedirectToAction("Index");
                 }
                 else
                 {
                     return View();
                 }*/
                Console.WriteLine("Record Inserted successfully...");
                Console.WriteLine("---------------");
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ViewBag.exMsg = ex.Message;
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            //var emp = helper.SearchEmployee(id);

            BookModel model = new BookModel();
            BLClass1 b = new BLClass1();
            model.Bookid = id;
            model.BookName = b.BookName;

            model.cost = b.cost;

            //only date
            //model.memberid = emp.BirthDate;


            model.memberid = b.memberid;



            return View(model);
        }

        // POST: NW_Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                // var emp = h.UpdateBook(id);


                BLClass1 bal = new BLClass1();
                bal.Bookid = Convert.ToInt32(Request["EmployeeID"]);
                bal.BookName = Request["Bookname"].ToString();
                bal.Author = Request["Author"].ToString();
                //  bal.Category = Request["Category"].ToString();
                bal.cost = Convert.ToInt32(Request["cost"]);
                bal.memberid = Convert.ToInt32(Request["member_id"]);

                h.UpdateBook(bal);


                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            BookModel foundData = modelsList.Find(customer => customer.Bookid == id);
            return View(foundData);
        }

        [HttpPost]
        public ActionResult Delete(int id, BookModel cust)
        {
            BookModel foundData = modelsList.Find(customer => customer.Bookid == id);
            modelsList.Remove(foundData);
            return View(foundData);
            //return RedirectToAction("Index");
        }

    }
}