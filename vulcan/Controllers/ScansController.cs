using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using vulcan.Classes;

namespace vulcan.Controllers
{
    public class ScansController : Controller
    {       
        public IActionResult Index()
        {
            return View();
        }
    }
}