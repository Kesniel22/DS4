using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio__20._1.Controllers
{
    public class MultiplicarController : Controller
    {
        // GET: Multiplicar
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int numero)
        {
            ViewBag.Numero = numero;
            return View();
        }
    }
}