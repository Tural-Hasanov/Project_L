using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project_L_A_Panel.Data.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L_A_Panel.ViewComponents.SidebarSec
{
    public class SideBarSection : ViewComponent
    {
        //private readonly SignInManager<SomeNames> _signInManager;
        //private readonly UserManager<SomeNames> _userManager;

        //public SideBarSection(SignInManager<SomeNames> signInManager, UserManager<SomeNames> userManager)
        //{
        //    _signInManager = signInManager;
        //    _userManager = userManager;
        //}

        public IViewComponentResult Invoke()
        {
            //var identit = User.Identity.Name;
            
            //var list = _userManager.Users.Where(x => x.Email == identit).Select(y => y.Fullname).FirstOrDefault();
            
            
            
            //ViewData["list"] = list;
            return View();
        }
    }
}
