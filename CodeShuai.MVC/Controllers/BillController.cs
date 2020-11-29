using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeShuai.MVC.Controllers
{
    public class BillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Analyse()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
