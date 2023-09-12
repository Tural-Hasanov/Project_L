using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EmployeeDepartment
    {
        [Key]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public List<EmployeeDetail> EmployeeDetails { get; set; }
    }
}
