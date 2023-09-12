using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View(GetList());
        }
        public List<Service> GetList()
        {
            using var c = new Context();
            var list = c.Set<Service>().ToList();
            return list;
        }
        public IActionResult ServiceDetails(int id)
        {
            using var c = new Context();
            ViewBag.name = c.Services.Where(x => x.ServiceID == id).Select(y => y.ServiceName).FirstOrDefault();
            ViewBag.desc = c.Services.Where(x => x.ServiceID == id).Select(y => y.ServiceDescription).FirstOrDefault();
            
            return View();
        }
    }
}
