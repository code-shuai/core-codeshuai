﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeShuai.MVC.Controllers
{
    public class Poetry : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
