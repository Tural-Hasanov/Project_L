using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
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
    public class LoginUserController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginUserController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(SignInViewModel p)
        {
            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync(p.username, p.passWord, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Main");
                }
                else
                {
                    ViewData["Message"] = "İstifadəçi adı və ya şifrə yalnışdır...";
                }

                return View();

            }


            return View();
        }
        [HttpPost]
        public IActionResult LogOut()
        {

            if (User.Identity.IsAuthenticated)
            {
                _signInManager.SignOutAsync();
                return RedirectToAction("Index", "LoginUser");

            }
            return View();

        }
    }
}
