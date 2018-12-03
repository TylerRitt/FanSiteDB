using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;

namespace FanSite.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult AddStory()
        {
            return View();
        }

        public IActionResult History()
        {
            ViewData["Message"] = "Facts about person";

            return View();
        }

        public IActionResult Stories()
        {
            ViewData["Message"] = "Stories about person/ form";

            return View();
        }
    }
}
