using Day7HTMLHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day7HTMLHelpers.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            Product p = new Product();
            p.Price = 21643.348m;

            return View();
        }
    }

    public class State
    {
        public string StateCode { get; set; }
        public string MyProperty { get; set; }
    }
}