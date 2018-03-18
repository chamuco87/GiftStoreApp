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
            GiftStoreAppContext dbContext = new GiftStoreAppContext();
            var setting = dbContext.GlobalSettings.FirstOrDefault();
            return View("Register");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
