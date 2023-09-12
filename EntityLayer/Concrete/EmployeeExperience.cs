using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EmployeeExperience
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? EmploymentStartDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? ResignationDate { get; set; }
        public int RangeYear { get; set; }
        public int RangeMonth { get; set; }
        public int RangeDay { get; set; }
        public EmployeeDetail EmployeeDetail { get; set; }
    }
}
