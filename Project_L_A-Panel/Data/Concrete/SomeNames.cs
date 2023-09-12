using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L_A_Panel.Data.Concrete
{

    public class SomeNames : IdentityUser<int>
    {
        public string Fullname { get; set; }

    }
}
