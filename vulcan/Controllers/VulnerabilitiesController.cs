using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace vulcan.Controllers
{
    public class VulnerabilitiesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Vulnerabilidades";
            return View();
        }
    }
}