using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L_A.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index(int code)
        {
            return View();
        }
        public IActionResult Denied(int code)
        {
            return View();
        }
    }
}
