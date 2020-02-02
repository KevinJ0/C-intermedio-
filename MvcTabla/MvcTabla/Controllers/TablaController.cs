using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcTabla.Controllers
{
    public class TablaController : Controller
    {
        public IActionResult Index()
        {
            List<int> resultado;
            return View();
        }
    }
}