﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SpecialTopics.Controllers
{
    public class DelegateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}