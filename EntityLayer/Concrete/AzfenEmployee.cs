using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AzfenEmployee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public string Badge { get; set; }
        public string SAA { get; set; }
        public string OccupationalChange { get; set; }
        public string Position { get; set; }
        public string SpecialistDegree { get; set; }
        public DateTime? EmploymentStartDate { get; set; }
        public DateTime? ResignationDate { get; set; }
        public string ProjectStatus { get; set; }
        public string Note { get; set; }
        public string ReasonOfResignation { get; set; }
        public string Department { get; set; }
        public string Classification { get; set; }
        public string PositionEng { get; set; }
        public string PersonnelCode { get; set; }
        public string LSRE { get; set; }
        public string PersonnelClassification { get; set; }
        public string DirectIndirect { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public string PmtSplit { get; set; }
        public string CitizenShip { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string FathersName { get; set; }
        public bool Status { get; set; }
    }
}
