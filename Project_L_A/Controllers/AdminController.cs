using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_L_A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Project_L_A.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;


        public AdminController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var c = new Context();
            var list = _userManager.Users.ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult AuthorizationDetail(int id)
        {
            var c = new Context();
            var list = _userManager.Users.Where(x => x.Id == id).FirstOrDefault();
            ViewBag.abc = c.UserRoles.Where(x => x.UserId == id).Select(x => x.RoleId).FirstOrDefault();
            return View(list);
        }
        [HttpPost]
        public async Task<IActionResult> AuthorizationDetail(string id, IFormCollection p)
        {
            var aaa = int.Parse(p["Authorization"]);
            var user = await _userManager.FindByIdAsync(id);
            var role = await _userManager.GetRolesAsync(user);
            var roleee = _roleManager.Roles.Where(x => x.Id == aaa).Select(x => x.Name).FirstOrDefault();
            await _userManager.AddToRoleAsync(user, roleee);
            return RedirectToAction("AuthorizationDetail", "Admin");
        }
        [HttpGet]
        public IActionResult UserRoleAuthorizationDetail(int id)
        {
            var c = new Context();
            var list = (from user in c.UserRoles
                        where user.UserId == id
                        from user1 in c.Users
                        where user1.Id == id
                        from user2 in c.Roles
                        where user2.Id == user.RoleId
                        select new testroledetail()
                        {
                            ID = user1.Id,
                            UserNamee = user1.NameSurname,
                            RoleName = user2.Name,
                            RoleID = user.RoleId

                        }).ToList();

            return View(list);
        }
        [HttpPost]
        public IActionResult UserRoleAuthorizationDetail(int id, int RoleNameID)
        {
            var c = new Context();
            var user = c.Users.Where(x => x.Id == id).FirstOrDefault();

            c.UserRoles.Remove(new IdentityUserRole<int>
            {
                UserId = user.Id,
                RoleId = RoleNameID
            });
            c.SaveChanges();
            Thread.Sleep(1500);
            return RedirectToAction("UserRoleAuthorizationDetail", "Admin");
        }

        public IActionResult UserRole()
        {
            var list = _roleManager.Roles.ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult AddUserRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddUserRole(AddRole p)
        {
            if (ModelState.IsValid)
            {
                AppRole app = new AppRole
                {
                    Name = p.RoleAdd
                };
                var result = await _roleManager.CreateAsync(app);

                if (result.Succeeded)
                {
                    return RedirectToAction("UserRole");
                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }

            }
            return View();
        }
        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var data = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            UpdateRole role = new UpdateRole
            {
                ID = data.Id,
                Name = data.Name
            };
            return View(role);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRole p, int id)
        {
            var data = _roleManager.Roles.FirstOrDefault(x => x.Id == id);

            data.Name = p.Name;
            var result = await _roleManager.UpdateAsync(data);
            if (result.Succeeded)
            {
                return RedirectToAction("UserRole");
            }
            return View();


        }
        public IActionResult DeleteRole(int id)
        {
            var data = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            _roleManager.DeleteAsync(data);
            return RedirectToAction("UserRole");
        }
    }
}
