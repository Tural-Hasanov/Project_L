using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project_L_A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Project_L_A.Controllers
{
    [Authorize(Roles = "Moderator")]
    public class ListOfEmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Index(int page = 1)
        {
            using var c = new Context();
            var list = c.AzfenEmployees.Where(x => x.Status == true).ToList().ToPagedList(page, 10);
            return View(list);
        }
        [HttpPost]
        public IActionResult Index(string p, int page = 1)
        {
            using var c = new Context();
            var list = c.AzfenEmployees.Where(x => x.SAA.Contains(p) || x.Badge.Contains(p) || x.Position.Contains(p)).Where(x => x.Status == true).ToList().ToPagedList(page, 1000);
            return View(list);
        }
        //public List<AzfenEmployee> GetAllList()
        //{
        //    using var c = new Context();
        //    var list = c.Set<AzfenEmployee>().ToList();
        //    return list;
        //}
        public IActionResult Details(int id)
        {
            using var c = new Context();
            var list = c.AzfenEmployees.Find(id);
            var imgid = c.AzfenEmployees.Where(x => x.EmployeeID == id).Select(x => x.UserName).FirstOrDefault();
            
            if (c.Users.Where(x => x.UserName == imgid).Select(x => x.ImageUrl).FirstOrDefault() == null)
            {
                ViewBag.Img = "/AzfenImages/ProfilePic/nophoto.png";
            }
            else
            {
                ViewBag.Img = c.Users.Where(x => x.UserName == imgid).Select(x => x.ImageUrl).FirstOrDefault();
            }
            if (c.AzfenEmployees.Where(x => x.EmployeeID == id).Select(x => x.ResignationDate).FirstOrDefault() == null)
            {
                ViewBag.ResignationDate = "31.12.9999";
            }
            else
            {
                ViewBag.ResignationDate = c.AzfenEmployees.Where(x => x.EmployeeID == id).Select(x => x.ResignationDate).FirstOrDefault().Value.Date.ToString("dd.MM.yyyy");
            }
            return View(list);
        }
        [HttpGet]
        public IActionResult Change(int id)
        {
            using var c = new Context();
            var imgid = c.AzfenEmployees.Where(x => x.EmployeeID == id).Select(x => x.UserName).FirstOrDefault();
            ViewBag.Img = c.Users.Where(x => x.UserName == imgid).Select(x => x.ImageUrl).FirstOrDefault();
            var list1 = c.AzfenEmployees.Find(id);
            return View(list1);
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Change(int id, AzfenEmployee p)
        {

            using var c = new Context();
            var data = c.AzfenEmployees.FirstOrDefault(x => x.EmployeeID == id);
            //if (data != null)
            //{
            data.OccupationalChange = p.OccupationalChange;
            data.SpecialistDegree = p.SpecialistDegree;
            data.EmploymentStartDate = p.EmploymentStartDate;
            data.ResignationDate = p.ResignationDate;
            data.ProjectStatus = p.ProjectStatus;
            data.Department = p.Department;
            data.PositionEng = p.PositionEng;
            data.Classification = p.Classification;
            data.PersonnelCode = p.PersonnelCode;
            data.LSRE = p.LSRE;
            data.Nationality = p.Nationality;
            data.Gender = p.Gender;
            // }
            //c.Update(p);
            c.SaveChanges();
            return RedirectToAction("Index", "ListOfEmployee");
        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(AzfenEmployee p)
        {
            var c = new Context();
            c.AzfenEmployees.Add(p);
            c.SaveChanges();
            return View();
        }
        public IActionResult DeleteEmployee(int id)
        {
            var c = new Context();
            var list = c.AzfenEmployees.Find(id);
            list.Status = false;
            c.SaveChanges();
            return RedirectToAction("Index", "ListOfEmployee");
        }
    }


}


