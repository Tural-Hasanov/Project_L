using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L_A.ViewComponents.Header
{
    public class HeaderInfo : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            var identityname = User.Identity.Name;
            ViewBag.name = c.Users.Where(x => x.UserName == identityname).Select(x => x.NameSurname).FirstOrDefault();
            return View();
        }
    }
}
