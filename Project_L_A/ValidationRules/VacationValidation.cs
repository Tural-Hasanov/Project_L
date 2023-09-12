using EntityLayer.Concrete;
using FluentValidation;
using Project_L_A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L_A.ValidationRules
{
    public class VacationValidation : AbstractValidator<EmployeeDetailsHelper>
    {
        public VacationValidation()
        {
            RuleFor(x => x.Badge).NotEmpty().WithMessage("bosh olmaz");
        }
    }
}
