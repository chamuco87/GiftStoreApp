using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GiftStoreApp.Models;
using GiftStoreApp.ViewModels;

namespace GiftStoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            GiftStoreAppContext dbContext = new GiftStoreAppContext();
            var setting = dbContext.GlobalSettings.FirstOrDefault();
            return View("Login");
        }

        public IActionResult Register()
        {
            GiftStoreAppContext dbContext = new GiftStoreAppContext();
            var setting = dbContext.GlobalSettings.FirstOrDefault();
            return View("Register");
        }

        [HttpPost]
        public IActionResult Register(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                GiftStoreAppContext dbContext = new GiftStoreAppContext();
                var setting = dbContext.GlobalSettings.FirstOrDefault();
                return Ok(model);
            }
            else{

                return BadRequest(ModelState);
            }

        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
