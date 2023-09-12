using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EmployeePhoto
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Url { get; set; } = null;
        public List<EmployeeDetail> EmployeeDetails { get; set; }

    }
}
