using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Project_L_A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L_A.ViewComponents.DocumentationEmployeeInfo
{
    public class DocEmployeeInf : ViewComponent
    {
        public IViewComponentResult Invoke(int ID)
        {
            var c = new Context();
            var person = c.EmployeeDetails.Where(x => x.ID == ID).Select(x => x.UserName).FirstOrDefault();
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
