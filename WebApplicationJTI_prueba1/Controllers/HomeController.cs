using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationJTI_prueba1.Models;

namespace WebApplicationJTI_prueba1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

   

        public IActionResult About()
        {
            ViewData["Message"] = "Sistema de Geolocalización Vehículos JTI.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Detalles de Contacto.";

            return View();
        }

        public IActionResult Reportes()
        {
            ViewData["Message"] = "Reportes de Geolocalización.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PruebaJson()
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
