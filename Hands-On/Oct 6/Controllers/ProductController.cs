using Oct_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oct_6.Controllers
{
    public class ProductController : Controller
    {
        static List<ProductModel> prodlist = new List<ProductModel>();
        static ProductController()
        {
            prodlist.Add(new ProductModel { Prodid = 1, ProdName = "Pantene",MfgDate=new DateTime(2022, 01, 06) });
            prodlist.Add(new ProductModel { Prodid = 2, ProdName = "Sunsilk",MfgDate=new DateTime(2021, 08,27) });
            prodlist.Add(new ProductModel { Prodid = 3, ProdName = "Dove",MfgDate = new DateTime(2022, 03, 04) });
        }
        public ActionResult Index() 
        {
            return View(prodlist);
        }
        public ActionResult SearchProduct(int id)
        {
            ProductModel foundData = prodlist.Find(product => product.Prodid == id);
            return View(foundData);
        }
    }
}