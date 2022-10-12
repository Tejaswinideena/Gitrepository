using CoreWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System;
using System.Diagnostics;

namespace CoreWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ITransientService _transientservice1;
        private readonly ITransientService _transientservice2;

        public ProductController(ILogger<ProductController> logger, ITransientService t1, ITransientService t2)
        {
            _logger = logger;
            _transientservice1 = t1;
            _transientservice2 = t2;
        }
        static List<ProductsModel> prodlist = new List<ProductsModel>();
        static ProductController()
        {
            prodlist.Add(new ProductsModel { ProdName = "Pantene", MfgDate = new DateTime(2022, 01, 06) });
            prodlist.Add(new ProductsModel { ProdName = "Sunsilk", MfgDate = new DateTime(2021, 08, 27) });
            prodlist.Add(new ProductsModel { ProdName = "Dove", MfgDate = new DateTime(2022, 03, 04) });
        }
        public ActionResult ProdIndex()
        {
            return View(prodlist);
        }
        public ActionResult SearchProduct(int id)
        {
            ProductsModel foundData = prodlist.Find(product => product.Prodid == id);
            return View(foundData);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
