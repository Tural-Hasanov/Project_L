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
    public class BlogDetailLastPost : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Posts p = new Posts();
            var list = p.Getlist();
            return View(list);
        }
    }
    public class Posts
    {
        public List<Blog> Getlist()
        {
            using var c = new Context();
            var list = c.Blogs.OrderByDescending(y => y.BlogCreationDate).Take(3).ToList();
            return list;
        }
    }
}
