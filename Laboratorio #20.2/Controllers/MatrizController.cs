using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio__20._2.Controllers
{
    public class MatrizController : Controller
    {
        // GET: Matriz
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int dimension)
        {
            int[,] matriz = new int[dimension, dimension];
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    if (i + j == dimension - 1)
                        matriz[i, j] = 1;
                    else
                        matriz[i, j] = 0;
                }
            }

            ViewBag.Matriz = matriz;
            ViewBag.Dimension = dimension;

            return View();
        }
    }
}