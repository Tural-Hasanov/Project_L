using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project_L_A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L_A.Controllers
{
    public class RegisterUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(SignUpViewModel p)
        {

            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    NameSurname = p.NameSurname,
                    UserName = p.UserName,
                    Email = p.Mail,
                    ImageUrl = "/AzfenImages/ProfilePic/nophoto.png"

                };
                var result = await _userManager.CreateAsync(user, p.PassWord);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Main");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }
    }
}
