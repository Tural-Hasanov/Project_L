using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L_A.Models
{
    public class EmployeeDetailsHelper
    {
        public int ID { get; set; }
        public string UserName { get; set; } = null;
        public string Badge { get; set; } = null;
        public string TabelNumber { get; set; } = null;
        public string FullName { get; set; } = null;
        public string Position { get; set; } = null;
        public double? Salary { get; set; }
        public string InsuranceNumber { get; set; } = null;
        public string Adress { get; set; } = null;
        public string PhoneNumber { get; set; } = null;
        public string Education { get; set; } = null;
        public string IdentitySerialNumber { get; set; }
        public string ImageUrl { get; set; } = null;
        public string Email { get; set; } = null;
        public DateTime? EmploymentStartDate { get; set; }
        public DateTime? ResignationDate { get; set; }
        public string DepartmentName { get; set; } = null;
        public int? BalanceVacation { get; set; }
        public int? ExperienceYear { get; set; }
        public int? ExperienceMonth { get; set; }
        public int? ExperienceDay { get; set; }
        public int? VacDayTest { get; set; }

    }
}
