using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FanSite.Controllers
{
    public class SourcesController : Controller
    {
        public IActionResult Books()
        {
            ViewData["Message"] = "Books about person";
            return View();
        }
        public IActionResult Links()
        {
            ViewData["Message"] = "Links about person";
            return View();
        }

        

    }
}