using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Project_L.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index(int id)
        {
            ViewBag.blogid = id;
            var list = GetInformation().Where(x => x.BlogID == id).ToList();
            return View(list);
        }

        public List<Blog> GetInformation()
        {
            using var c = new Context();
            var list = c.Blogs.Include(x => x.BlogComments).Include(x => x.BlogCategory).Include(x => x.HrTeam).ToList();
            return list;
        }
        public IActionResult BlogPage(int page = 1)
        {
            using var c = new Context();
            var list = c.Blogs.Include(x => x.HrTeam).Include(x => x.BlogCategory).ToList().ToPagedList(page, 6);
            return View(list);
        }
        public IActionResult CategoryBlogList(int id)
        {
            using var c = new Context();
            var list = GetInformation().Where(x => x.BlogCategoryID == id).ToList();
            ViewBag.categorynameblog = GetInformation().Where(x => x.BlogCategory.BlogCategoryID == id).Select(x => x.BlogCategory.BlogCategoryName).FirstOrDefault();
            return View(list);

        }

    }
}
