using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project_L_A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace Project_L_A.Controllers
{
    [Authorize]
    public class MainController : Controller
    {
        public readonly UserManager<AppUser> _userManager;

        public MainController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var c = new Context();
            var person = User.Identity.Name;
            ViewBag.nameperson = c.Users.Where(x => x.UserName == person).Select(x => x.NameSurname).FirstOrDefault();
            var list = (from infperson in c.EmployeeDetails
                        where infperson.UserName == person
                        from test in c.Users
                        where test.UserName==person
                        
                        select new EmployeeDetailsHelper
                        {
                            FullName = infperson.FullName,
                            Position = infperson.Position,
                            Salary = infperson.Salary,
                            UserName = infperson.UserName,
                            Badge=infperson.Badge,
                            Adress=infperson.Adress,
                            Education=infperson.Education,
                            IdentitySerialNumber=infperson.IdentitySerialNumber,
                            InsuranceNumber=infperson.InsuranceNumber,
                            PhoneNumber=infperson.PhoneNumber,
                            TabelNumber=infperson.TabelNumber,
                            ImageUrl=test.ImageUrl,
                            Email=test.NormalizedEmail,
                            EmploymentStartDate=infperson.EmploymentStartDate,
                            DepartmentName=infperson.EmployeeDepartment.DepartmentName,
                            BalanceVacation=infperson.BalanceVacation,
                            ExperienceYear=infperson.ExpYear,
                            ExperienceMonth=infperson.ExpMonth,
                            ExperienceDay=infperson.ExpDay
                            
                        }).ToList();




            return View(list);
        }
    }
}
