using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Project_L_A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L_A.ViewComponents.DepartEmployee
{
    public class DepartmentEmployee : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var c = new Context();
            var person = User.Identity.Name;
            var departmentid = c.EmployeeDetails.Where(x => x.UserName == person).Select(x => x.EmployeeDepartment).FirstOrDefault();
            var list = (from value in c.EmployeeDetails
                        where value.EmployeeDepartment == departmentid
                        from userurl in c.Users
                        where userurl.UserName==value.UserName
                        select new SameDepartment
                        {
                            SameDepartmentEmployeeName = value.FullName,
                            DepartmentUrl=userurl.ImageUrl
                            
                        }).ToList();

            return View(list);
        }
    }
}
