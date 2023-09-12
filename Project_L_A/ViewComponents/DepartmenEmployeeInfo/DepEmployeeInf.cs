using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Project_L_A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L_A.ViewComponents.DepartmenEmployeeInfo
{
    public class DepEmployeeInf : ViewComponent
    {
        public IViewComponentResult Invoke(int ID)
        {
            var c = new Context();
            var persondepid = c.EmployeeDetails.Where(x => x.ID == ID).Select(x => x.EmployeeDepartmentDepartmentID).FirstOrDefault();
            var list = (from value in c.EmployeeDetails
                        where value.EmployeeDepartmentDepartmentID == persondepid
                        from image in c.EmployeePhotos
                        where image.UserName==value.UserName
                        select new EmployeeDetailsHelper
                        {
                            ID=value.ID,
                            UserName = value.UserName,
                            ImageUrl=image.Url
                            
                        }).ToList();


            return View(list);

        }
    }
}
