using ASPProject.Application.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Implementation.Validators
{
    public class PlaceOrderValidator : AbstractValidator<OrderDto>
    {
        public PlaceOrderValidator()
        {
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address is required");
            RuleFor(x => x.City).NotEmpty().WithMessage("City is required");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Country is required");

            var phoneRegex = @"^0[0-9]{8,9}$";
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone is required")
                .Matches(phoneRegex)
                .WithMessage("Phone is not in correct format. E.g. 0665122121");
            RuleFor(x => x.OrderItems).NotEmpty().WithMessage("You can not place orders without any products");
        }
    }
}
