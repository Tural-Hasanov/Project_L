using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L_A.Models
{
    public class UploadFiles
    {
        public string UserName { get; set; }
        public string SqlUrl { get; set; }
        public IFormFile PhotoUrl { get; set; }

    }
}
