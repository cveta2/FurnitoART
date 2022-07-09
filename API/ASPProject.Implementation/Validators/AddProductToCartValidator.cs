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
    public class AddProductToCartValidator : AbstractValidator<AddToCartDto>
    {
        public AddProductToCartValidator(ProjekatContext contxet)
        {
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("Product is required");
            RuleFor(x => x.Quantity).NotEmpty().WithMessage("Quantity is required");
        }
    }
}
