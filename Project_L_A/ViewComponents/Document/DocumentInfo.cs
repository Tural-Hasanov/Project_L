using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Project_L_A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L_A.ViewComponents.Document
{
    public class DocumentInfo : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var c = new Context();
            var person = User.Identity.Name;
            var list = (from namedoc in c.EmployeeDocuments
                        where namedoc.UserName == person
                        select new DocNameModel
                        {
                            UserName = namedoc.UserName,
                            FileName = namedoc.FileName
                        }).ToList();
            return View(list);
        }
       
    }
}
