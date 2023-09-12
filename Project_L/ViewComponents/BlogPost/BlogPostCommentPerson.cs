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
    public class BlogPostCommentPerson : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            BlogCommentGetList list = new BlogCommentGetList();
            return View(list.BlogComments(id));
        }
    }
    public class BlogCommentGetList
    {
        public List<BlogComment> BlogComments(int id)
        {
            using var c = new Context();
            var list1 = c.BlogComments.Include(x => x.HrTeam).Where(x=>x.BlogID==id).ToList();
            return list1;
        }
    }
}
