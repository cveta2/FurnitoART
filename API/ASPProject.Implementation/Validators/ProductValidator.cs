using ASPProject.Application.DTOs;
using ASPProjekat.DataAccess;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Implementation.Validators
{
    public class ProductValidator : AbstractValidator<NewProductsDto>
    {
        public ProductValidator(ProjekatContext conext)
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Product name is required")
                                        .Matches(@"^[A-Z][a-z]{2,}(\s[a-z]{3,})?$").WithMessage("Product name must start with an uppercase letter.");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Category id is required");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Product must have a price.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Product description is required")
                                        .Matches(@"^[A-Z][a-z]{2,}(\s[a-z]{3,})?$").WithMessage("Description must start with an uppercase letter");
        }
    }
}
