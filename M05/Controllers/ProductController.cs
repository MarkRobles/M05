using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M05.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var Context = new Models.NORTHWNDEntities();

            var Products = Context.Products.ToList();

            return View(Products);
        }

        public ActionResult Display(int ID)
        {
            var Context = new Models.NORTHWNDEntities();
            var Product = Context.Products.FirstOrDefault(p => p.ProductID == ID);
            return View("DinamycView",Product);
        }


        public ActionResult DisplayExtern(int ID)
        {
            var Extern = new Models.ExternProduct { ProductName = "ProductoExterno", UnitPrice = 10, UnitsInStock = 100, ExternID = 50 };

            return View("DinamycView", Extern);
        }
    }
}