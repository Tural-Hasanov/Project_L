using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EmployeeDetail
    {
        [Key]
        public int ID { get; set; }
        [Required, StringLength(7, ErrorMessage = "* 7 sayda xarakter daxil edilmelidir.", MinimumLength = 7)]
        public string UserName { get; set; }
        [StringLength(10, ErrorMessage = "* Maksimum: 10, Minimum: 5 sayda xarakter daxil edilmelidir", MinimumLength = 5)]
        public string Badge { get; set; }
        public string TabelNumber { get; set; }
        [Required, RegularExpression("^([a-zA-Z]{1,}[ ]{1}[a-zA-Z]{1,}[ ]{1}[a-zA-Z]{1,})$", ErrorMessage = "Boşluq (Space) sayına diqqət edin məlumatın düzgünlüyünü yoxlayın")]
        public string FullName { get; set; }
        [Required, MaxLength(100, ErrorMessage = "Maksimum 100 xarakter daxil edilə bilər"), MinLength(1)]
        public string Position { get; set; }
        [Required, RegularExpression("^([0-9]{1,20})$", ErrorMessage = "Yalnız rəqəm daxil edin")]
        public double? Salary { get; set; }
        [Required, StringLength(13, ErrorMessage = "* 13 sayda rəqəm daxil edilməlidir", MinimumLength = 13)]
        public string InsuranceNumber { get; set; }
        public string Adress { get; set; }
        [Required, MaxLength(20, ErrorMessage = "* maksimum 20 xarakter daxil ola bilər"), MinLength(8, ErrorMessage = "* minimum 8 xarakter daxil edilməlidir")]
        [RegularExpression("^([+]{1}[0-9]{8,20})$", ErrorMessage = "nümunə olaraq(+994xxxxxxxx)")]
        public string PhoneNumber { get; set; }
        public string Education { get; set; }

        public string IdentitySerialNumber { get; set; }
        [Column(TypeName = "Date")]
        [Required]
        public DateTime? EmploymentStartDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? ResignationDate { get; set; }
        public EmployeeDepartment EmployeeDepartment { get; set; }
        public int EmployeeDepartmentDepartmentID { get; set; }
        public int RangeYear { get; set; }
        public int RangeMonth { get; set; }
        public int RangeDay { get; set; }
        [Required, RegularExpression("^([21]{2}|[30]{2})$", ErrorMessage = "duzgun reqem daxil edin")]
        public int? VacationDay { get; set; }
        [Required, RegularExpression("^([0-6]{1})$", ErrorMessage = "duzgun reqem daxil edin")]
        public int? ExperienceVacationDay { get; set; }
        public int? AllVacationDay { get; set; }
        public int? BalanceVacation { get; set; }
        public int? UsedVacationDay { get; set; }
        public int? UsedVacationPeriod { get; set; }
        public int ExpYear { get; set; }
        public int ExpMonth { get; set; }
        public int ExpDay { get; set; }
        public List<EmployeeExperience> EmployeeExperiences { get; set; }

        public EmployeePhoto EmployeePhoto { get; set; }



    }
}
