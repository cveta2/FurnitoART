using ASPProject.Application.DTOs;
using ASPProjekat.DataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Implementation.Validators
{

    public class SpecificationValidator : AbstractValidator<SpecificationDto>
    {
        public SpecificationValidator(ProjekatContext context)
        {
            RuleFor(x => x.SpecificationName).NotEmpty().WithMessage("Specification name is required")
                                             .Matches(@"^[A-Z][a-z]{2,}(\s[a-z]{3,})?$")
                                             .WithMessage("Specification name must start with uppercase letter.");
        }
    }
}
