using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L_A.ViewComponents.Sidebar
{
    public class SidebarInfo : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            ViewBag.NameSurname = c.Users.Where(x => x.UserName == username).Select(x => x.NameSurname).FirstOrDefault();
            ViewBag.ImageUrl = c.Users.Where(x => x.UserName == username).Select(x => x.ImageUrl).FirstOrDefault();
            ViewBag.Position = c.Users.Where(x => x.UserName == username).Select(x => x.Position).FirstOrDefault();
            var sn1 = c.Users.Where(x => x.UserName == username).Select(x => x.NameSurname).FirstOrDefault().Split()[0].Substring(0, 1);
            var n1 = c.Users.Where(x => x.UserName == username).Select(x => x.NameSurname).FirstOrDefault().Split()[1].Substring(0, 1);
            ViewBag.sn1n1 = sn1 + n1;
            return View();
        }
    }
}
