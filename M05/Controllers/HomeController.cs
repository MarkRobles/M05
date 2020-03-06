using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M05.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<String> Dias = new string[] { "Domingo","Lunes","Martes","Miercoles","Jueves","Viernes","Sabado","",""};
            ViewBag.Dias = Dias;

            return View();
        }
    }
}