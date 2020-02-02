using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcEcuaciones.Controllers
{
    public class EcuacionController : Controller
    {
        public IActionResult Index(double A, double B, double C)
        {
           
             ViewBag.resultPositivo = ((-B + Math.Sqrt(B * B - 4 * A * C)) / (2 * A));
             ViewBag.resultNegativo = ((-B - Math.Sqrt(B * B - 4 * A * C)) / (2 * A));

            return View();
        }

        
    }
}