using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ZodiacoController : Controller
    {
        // GET: Zodiaco
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Result(int day, int month)
        {

          
            ViewBag.signo = "";
            DateTime fecha = new DateTime(2020, month, day);
            if (new DateTime(2019, 12, 22) <= fecha && new DateTime(2020, 1, 20) >= fecha)
            {
                ViewBag.signo = "Capricornio";
            }
            else if (new DateTime(2020, 1, 20) <= fecha && new DateTime(2020, 2, 18) >= fecha)
            {
                ViewBag.signo = "Acuario";

            }
            else if (new DateTime(2020, 2, 19) <= fecha && new DateTime(2020, 3, 20) >= fecha)
            {

                ViewBag.signo = "Piscis";
            }
            else if (new DateTime(2020, 3, 21) <= fecha && new DateTime(2020, 4, 20) >= fecha)
            {
                ViewBag.signo = "Aries";

            }
            else if (new DateTime(2020, 4, 21) <= fecha && new DateTime(2020, 5, 20) >= fecha)
            {
                ViewBag.signo = "Tauro";

            }
            else if (new DateTime(2020, 5, 21) <= fecha && new DateTime(2020, 6, 24) >= fecha)
            {
                ViewBag.signo = "Géminis";

            }
            else if (new DateTime(2020, 6, 25) <= fecha && new DateTime(2020, 7, 20) >= fecha)
            {
                ViewBag.signo = "Piscis";


            }
            else if (new DateTime(2020, 2, 19) <= fecha && new DateTime(2020, 3, 22) >= fecha)
            {
                ViewBag.signo = "Cáncer";


            }
            else if (new DateTime(2020, 2, 19) <= fecha && new DateTime(2020, 3, 20) >= fecha)
            {
                ViewBag.signo = "Piscis";


            }
            else if (new DateTime(2020, 7, 23) <= fecha && new DateTime(2020, 8, 23) >= fecha)
            {
                ViewBag.signo = "Leo";


            }
            else if (new DateTime(2020, 8, 24) <= fecha && new DateTime(2020, 9, 23) >= fecha)
            {
                ViewBag.signo = "Virgo";


            }
            else if (new DateTime(2020, 9, 24) <= fecha && new DateTime(2020, 10, 22) >= fecha)
            {
                ViewBag.signo = "Libra";


            }
            else if (new DateTime(2020, 10, 23) <= fecha && new DateTime(2020, 11, 22) >= fecha)
            {
                ViewBag.signo = "Escorpio";


            }
            else if (new DateTime(2020, 1, 23) <= fecha && new DateTime(2020, 12, 21) >= fecha)
            {
                ViewBag.signo = "Sagitario";


            }

            return View("resultado");
        }



        // GET: Zodiaco/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Zodiaco/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Zodiaco/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Zodiaco/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Zodiaco/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Zodiaco/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Zodiaco/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}