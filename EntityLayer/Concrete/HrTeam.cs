using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class HrTeam
    {
        [Key]
        public int HrTeamID { get; set; }
        public string HrTeamSAA { get; set; }
        public string HrTeamPosition { get; set; }
        public string HrTeamImageUrl { get; set; }
        public string HrTeamOpinion { get; set; }
        public string AboutTwitterAdress { get; set; }
        public string AboutFacebookAdress { get; set; }
        public string AboutInstagramAdress { get; set; }
        public string AboutLinkedinAdress { get; set; }
        public List<BlogComment> BlogComments { get; set; }
        public List<Blog> Blogs { get; set; }



    }
}
