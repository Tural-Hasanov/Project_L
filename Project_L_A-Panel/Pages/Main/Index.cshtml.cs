using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project_L_A_Panel.Data;
using Project_L_A_Panel.Data.Concrete;

namespace Project_L_A_Panel.Pages.Main
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public IndexModel(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            
        }

        public void OnGet()
        {
            
            SomeNames s = new SomeNames();
            var identit = User.Identity.Name;
            var list1 = _userManager.Users.Where(x => x.Email == identit).Select(y => y.UserName).FirstOrDefault();
            //var list = userManager1.Users.Where(x => x.Email == identit).Select(y => y.Fullname).FirstOrDefault();

            ViewData["list"] = list1;


        }


        public async Task<IActionResult> Exit()
        {


            if (_signInManager.IsSignedIn(User))
            {
                await _signInManager.SignOutAsync();
                return Redirect("~/Main/Index");
            }
            return Redirect("~/Main/Index");


        }
    }
}
