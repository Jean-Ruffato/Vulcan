﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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