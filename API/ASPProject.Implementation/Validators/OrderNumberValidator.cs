using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Implementation.Validators
{
    public class OrderNumberValidator : AbstractValidator<int>
    {
        public OrderNumberValidator()
        {
            RuleFor(x => x).GreaterThan(1000000).WithMessage("Order number must contain 7 digits 1");
            RuleFor(x => x).LessThan(9999999).WithMessage("Order number must contain 7 digits 2");
        }
    }
}
