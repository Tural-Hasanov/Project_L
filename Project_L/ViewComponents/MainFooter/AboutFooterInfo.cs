using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L.ViewComponents
{
    public class AboutFooterInfo : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            var getlist = c.Set<About>().ToList();
            ViewBag.Nomre = getlist.Select(x => x.AboutPhoneNumber).FirstOrDefault();
            ViewBag.Email = getlist.Select(x => x.AboutEmailAdress).FirstOrDefault();
            ViewBag.Adress = getlist.Select(x => x.AboutAdress).FirstOrDefault();
            ViewBag.Twitter = getlist.Select(x => x.AboutTwitterAdress).FirstOrDefault();
            ViewBag.Facebook = getlist.Select(x => x.AboutFacebookAdress).FirstOrDefault();
            ViewBag.Instagram = getlist.Select(x => x.AboutInstagramAdress).FirstOrDefault();
            ViewBag.Linkedin = getlist.Select(x => x.AboutLinkedinAdress).FirstOrDefault();

            return View(getlist);
        }

    }
}
