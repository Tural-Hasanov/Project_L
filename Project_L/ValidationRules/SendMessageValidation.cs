using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L.ValidationRules
{
    public class SendMessageValidation : AbstractValidator<MessageFromExternal>
    {
        public SendMessageValidation()
        {
            RuleFor(x => x.MessageFromExternalName).MaximumLength(15).NotEmpty().MinimumLength(3).WithMessage("Minimum 3 Maksimum 15 xarakter daxil ede bilersiniz");
            RuleFor(x => x.MessageFromExternalSubject).MaximumLength(30).NotEmpty().MinimumLength(3).WithMessage("Minimum 3 Maksimum 30 xarakter daxil ede bilersiniz");
            RuleFor(x => x.MessageFromExternalEmail).NotEmpty().EmailAddress().WithMessage("example@example.com");
            RuleFor(x => x.MessageFromExternalContent).MaximumLength(500).NotEmpty().MinimumLength(10).WithMessage("Minimum 3 Maksimum 500 xarakter daxil ede bilersiniz");
        }
    }
}
