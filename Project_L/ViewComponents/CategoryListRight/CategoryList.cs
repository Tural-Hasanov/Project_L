using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L.ViewComponents.CategoryListRight
{
    public class CategoryList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CategoryGetList g = new CategoryGetList();
            return View(g.BlogCategories());
        }
    }
    public class CategoryGetList
    {
        public List<BlogCategory> BlogCategories() 
        {
            using var c = new Context();
            var list = c.BlogCategories.Include(x => x.Blogs).ToList();
            return list;
        }
    }
}
