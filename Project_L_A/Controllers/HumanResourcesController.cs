using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project_L_A.Models;
using Project_L_A.ValidationRules;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L_A.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HumanResourcesController : Controller
    {

        public IActionResult Index()
        {
            var c = new Context();
            var list = c.EmployeeDetails.Include(x => x.EmployeeDepartment).ToList();
            return View(list);
        }
        public IActionResult IndexWithPhoto()
        {
            var c = new Context();
            //var list = c.EmployeeDetails.Include(x => x.EmployeeDepartment).Include(x => x.EmployeePhoto).ToList();
            var list = (from infperson in c.EmployeeDetails

                        from empusernameurlphoto in c.EmployeePhotos

                        where infperson.UserName == empusernameurlphoto.UserName



                        select new EmployeeDetailsHelper
                        {
                            ID = infperson.ID,
                            FullName = infperson.FullName,
                            Position = infperson.Position,
                            Salary = infperson.Salary,
                            UserName = infperson.UserName,
                            Badge = infperson.Badge,
                            Adress = infperson.Adress,
                            ImageUrl = empusernameurlphoto.Url,
                            Education = infperson.Education,
                            IdentitySerialNumber = infperson.IdentitySerialNumber,
                            InsuranceNumber = infperson.InsuranceNumber,
                            PhoneNumber = infperson.PhoneNumber,
                            TabelNumber = infperson.TabelNumber,
                            EmploymentStartDate = infperson.EmploymentStartDate,
                            DepartmentName = infperson.EmployeeDepartment.DepartmentName,
                            BalanceVacation = infperson.BalanceVacation,
                            ExperienceYear = infperson.ExpYear,
                            ExperienceMonth = infperson.ExpMonth,
                            ExperienceDay = infperson.ExpDay

                        }).ToList();




            return View(list);

        }
        public IActionResult EmployeeInfo(int ID)
        {
            ViewBag.IDE = ID;
            var c = new Context();
            var person = c.EmployeeDetails.Where(x => x.ID == ID).Select(x => x.UserName).FirstOrDefault();
            var list = (from infperson in c.EmployeeDetails
                        where infperson.ID == ID
                        from empusernameurlphoto in c.EmployeePhotos
                        where empusernameurlphoto.UserName == person



                        select new EmployeeDetailsHelper
                        {
                            ID = infperson.ID,
                            FullName = infperson.FullName,
                            Position = infperson.Position,
                            Salary = infperson.Salary,
                            UserName = infperson.UserName,
                            Badge = infperson.Badge,
                            Adress = infperson.Adress,
                            ImageUrl = empusernameurlphoto.Url,
                            Education = infperson.Education,
                            IdentitySerialNumber = infperson.IdentitySerialNumber,
                            InsuranceNumber = infperson.InsuranceNumber,
                            PhoneNumber = infperson.PhoneNumber,
                            TabelNumber = infperson.TabelNumber,
                            EmploymentStartDate = infperson.EmploymentStartDate,
                            DepartmentName = infperson.EmployeeDepartment.DepartmentName,
                            BalanceVacation = infperson.BalanceVacation,
                            ExperienceYear = infperson.ExpYear,
                            ExperienceMonth = infperson.ExpMonth,
                            ExperienceDay = infperson.ExpDay

                        }).ToList();


            return View(list);
        }
        [HttpPost]
        public IActionResult VacationAction(int ID, int vacday, DateTime vacstartdate)
        {
            var c = new Context();
            var person = c.EmployeeDetails.Where(x => x.ID == ID).FirstOrDefault();
            Document doc = new Document();
            //string path = @"C:\Users\Tural\Desktop\test\vacation.docx";
            //string newpath = @"C:\Users\Tural\Desktop\test\" + person.FullName + "_" + DateTime.Now.ToString("dd.MM.yyyy" + "_" + "hh_mm_ss") + ".docx";
            //Ilk defe vacation file komputer folderinde idi. yuxaridaki kod onun ucun nezerde tutulub
            string pathtest = Path.GetFullPath("wwwroot/AzfenImages/AzfenVacation/vacation.docx");
            string filelocationpath = Path.GetDirectoryName(pathtest + "/");
            string path = pathtest;
            string newpath = filelocationpath + person.FullName + "_" + DateTime.Now.ToString("dd.MM.yyyy" + "_" + "hh_mm_ss") + ".docx";

            if (ModelState.IsValid && vacday < person.BalanceVacation && vacday > 0)
            {

                DateTime resultfirstperioddatetime;
                DateTime resultsecondperioddatetime;

                var vacationday = person.UsedVacationDay;
                if (vacationday == null || vacationday == 0)
                {
                    vacationday = 0;
                }
                DateTime resfirstdate = Convert.ToDateTime(person.EmploymentStartDate); //Deyishmeyen deyer datetime
                vacationday += vacday;
                doc.LoadFromFile(path);
                DateTime firstperioddatetime = Convert.ToDateTime(person.EmploymentStartDate);
                resultfirstperioddatetime = firstperioddatetime.AddYears(Convert.ToInt32(person.UsedVacationPeriod));
                doc.Replace("[dovr1]", resultfirstperioddatetime.ToString("dd.MM.yyyy"), true, true);
                person.UsedVacationDay = vacationday;
                c.SaveChanges();
                var c1 = new Context();
                var person1 = c1.EmployeeDetails.Where(x => x.ID == ID).FirstOrDefault();
                if (person1.UsedVacationDay % (person1.VacationDay + person1.ExperienceVacationDay) == 0)
                {
                    person1.UsedVacationPeriod = person1.UsedVacationPeriod - 1;
                }
                resultsecondperioddatetime = resfirstdate.AddYears(Convert.ToInt32(person1.UsedVacationPeriod) + 1);
                doc.Replace("[dovr2]", resultsecondperioddatetime.ToString("dd.MM.yyyy"), true, true);


                var ishebashlama = vacstartdate.AddDays(vacday);
                doc.Replace("[vezife]", person.Position, true, true);
                doc.Replace("[saa]", person.FullName, true, true);
                doc.Replace("[mezgetmetarix]", vacstartdate.ToString("dd.MM.yyyy"), true, true);
                doc.Replace("[mezgun]", vacday.ToString(), true, true);
                doc.Replace("[buguntarix]", DateTime.Now.ToString("dd.MM.yyyy"), true, true);
                doc.Replace("[qayitmatarix]", ishebashlama.ToString("dd.MM.yyyy"), true, true);
                doc.SaveToFile(newpath, FileFormat.Docx2013);
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(newpath)
                {
                    UseShellExecute = true
                };
                p.Start();
            }
            return RedirectToAction("EmployeeInfo", "HumanResources", new { @id = ID });
        }
        [HttpGet]
        public IActionResult HrRecruitment()
        {
            var c = new Context();
            List<SelectListItem> values = (from x in c.EmployeeDepartments.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.DepartmentName,
                                               Value = x.DepartmentID.ToString()
                                           }).ToList();
            ViewBag.test = values;
            return View();
        }
        [HttpPost]
        public IActionResult HrRecruitment(EmployeeDetail p)
        {


            if (!ModelState.IsValid)
            {
                return View();
            }





            var c = new Context();
            List<SelectListItem> values = (from x in c.EmployeeDepartments.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.DepartmentName,
                                               Value = x.DepartmentID.ToString()
                                           }).ToList();


            ViewBag.test = values;

            EmployeePhoto photo = new EmployeePhoto();
            photo.UserName = p.UserName;

            photo.Url = "/AzfenImages/ProfilePic/" + p.UserName + ".jpg";



            var test = c.EmployeePhotos.Where(x => x.UserName == p.UserName).Select(x => x.UserName).FirstOrDefault();
            if (test != p.UserName)
            {
                c.EmployeePhotos.Add(photo);
            }

            c.EmployeeDetails.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");


        }
        [HttpGet]
        public IActionResult UploadFiles()
        {
            var c = new Context();
            var list = (from photourl in c.EmployeePhotos


                        select new UploadFiles()
                        {
                            SqlUrl = photourl.Url
                        }).ToList();
            return View(list);
        }
        [HttpPost]
        public IActionResult UploadFiles(UploadFiles p)
        {
            var c = new Context();
            EmployeePhoto f = new EmployeePhoto();
            var list = (from photourl in c.EmployeePhotos


                        select new UploadFiles()
                        {
                            SqlUrl = photourl.Url
                        }).ToList();
            //return View(list);
            if (p.PhotoUrl != null)
            {

                //var extension = Path.GetExtension(p.PhotoUrl.FileName);
                var extension = p.PhotoUrl.FileName;
                var getusername = p.PhotoUrl.FileName.Substring(0, 7);
                var imagename = extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AzfenImages/ProfilePic/", imagename);

                var location1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AzfenImages/ProfilePic/");

                f.Url = "/AzfenImages/ProfilePic/" + imagename;
                f.UserName = getusername;
                string[] filenames = Directory.GetFiles(location1);
                bool okey = true;
                foreach (var item in filenames)
                {
                    if (item.ToString().Split('/').Last().Substring(0, 7) == getusername)
                    {
                        var itemnewvalue = item.ToString().Split('/').Last().Substring(0, 7);
                        //stream.Close();
                        System.IO.File.Delete(location);
                        okey = false;

                    }
                    if (okey == false)
                    {
                        break;
                    }
                }

                var stream = new FileStream(location, FileMode.Create);
                p.PhotoUrl.CopyTo(stream);

                var idofvalue = c.EmployeePhotos.Where(x => x.UserName == getusername).Select(x => x.ID).FirstOrDefault();
                var usernameinsql = c.EmployeePhotos.Where(x => x.UserName == getusername).Select(x => x.UserName).FirstOrDefault();
                if (usernameinsql != getusername)
                {
                    c.EmployeePhotos.Add(f);
                    c.SaveChanges();


                }
                stream.Close();

            }



            return View(list);
        }

    }
}
