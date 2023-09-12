using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L_A.Models
{
    public class SignUpViewModel
    {
        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage = "Ad Soyad Daxil edin")]
        public string NameSurname { get; set; }

        [Display(Name = "Şifrə")]
        [Required(ErrorMessage = "Şifrənizi daxil edin")]
        public string PassWord { get; set; }

        [Display(Name = "Təkrar Şifrə")]
        [Compare("PassWord", ErrorMessage = "Şifrə fərqlidi")]
        public string ConfirmPassword { get; set; }
        
        [Display(Name = "Mail ünvanı")]
        [Required(ErrorMessage = "Mail ünvanı daxil edin")]
        public string Mail { get; set; }
        
        [Display(Name = "İstifadəçi adı")]
        [Required(ErrorMessage = "İstifadəçi adı Daxil edin")]
        public string UserName { get; set; }

    }
}
