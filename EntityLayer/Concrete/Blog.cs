using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogName { get; set; }
        public string BlogContent { get; set; }
        public string BlogImage { get; set; }
        public string BlogCreator { get; set; }
        public DateTime BlogCreationDate { get; set; }
        public int BlogCategoryID { get; set; }
        public BlogCategory BlogCategory { get; set; }
        public List<BlogComment> BlogComments { get; set; }
        public int HrTeamID { get; set; }
        public HrTeam HrTeam { get; set; }


    }
}
