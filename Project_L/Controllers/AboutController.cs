using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Project_L.ValidationRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L.Controllers
{
    public class AboutController : Controller
    {

        public IActionResult Index()
        {
            using var c = new Context();
            var a = c.Abouts.Select(x => x.AboutImage1).FirstOrDefault();
            var b = c.Abouts.Select(x => x.AboutDetails1).FirstOrDefault();
            var c1 = c.Abouts.Select(x => x.AboutDetails3).FirstOrDefault();
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.c1 = c1;
            return View(GetListAll());

        }
        public List<HrTeam> GetListAll()
        {
            using var a = new Context();
            var Getlist = a.Set<HrTeam>().ToList();
            return Getlist;
        }
        public List<About> DetailForContact()
        {
            using var c = new Context();
            var list = c.Abouts.ToList();
            return list;
        }
        
        

    }
}
