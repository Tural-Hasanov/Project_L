using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogComment
    {
        [Key]
        public int BlogCommentID { get; set; }
        public string BlogCommentDescription { get; set; }
        public DateTime BlogCommentDate { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
        public int HrTeamID { get; set; }
        public HrTeam HrTeam { get; set; }


    }
}
