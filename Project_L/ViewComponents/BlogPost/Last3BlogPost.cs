using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L.ViewComponents.BlogPost
{
    public class Last3BlogPost : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Information a = new Information();
            return View(a.Getlist());
        }
        
    }
    public class Information
    {
        public List<Blog> Getlist()
        {
            using var c = new Context();
            var list = c.Blogs.Include(x => x.BlogCategory).Include(x=>x.HrTeam).OrderByDescending(y => y.BlogID).Take(6).ToList();
            return list;
        }
    }
}
