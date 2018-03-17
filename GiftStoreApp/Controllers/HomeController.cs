using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GiftStoreApp.Models;

namespace GiftStoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            DB_A109B3_chamucolol87Context dbContext = new DB_A109B3_chamucolol87Context();
            return View(dbContext.GlobalSettings.FirstOrDefault());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
