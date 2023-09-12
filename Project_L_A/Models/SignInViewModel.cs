using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L_A.Models
{
    public class SignInViewModel
    {
        [Required(ErrorMessage ="İstifadəçi adını daxil edin...")]
        public string  username { get; set; }
        [Required(ErrorMessage = "Şifrənizi daxil edin...")]
        public string  passWord { get; set; }
    }
}
