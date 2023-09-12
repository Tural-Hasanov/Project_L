using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string AboutDetails1 { get; set; }
        public string AboutDetails2 { get; set; }
        public string AboutDetails3 { get; set; }
        public string AboutImage1 { get; set; }
        public string AboutImage2 { get; set; }
        public string AboutPhoneNumber { get; set; }
        public string AboutAdress { get; set; }
        public string AboutEmailAdress { get; set; }
        public string AboutTwitterAdress { get; set; }
        public string AboutFacebookAdress { get; set; }
        public string AboutInstagramAdress { get; set; }
        public string AboutLinkedinAdress { get; set; }
        public bool AboutStatus { get; set; }
    }
}
