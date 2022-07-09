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
    public class CategoryValidator : AbstractValidator<CategoryDto>
    {
        public CategoryValidator(ProjekatContext context)
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category name is required")
                        .Matches(@"^[A-Z][a-z]{2,}(\s[a-z]{3,})?$")
                        .WithMessage("Category name must start with first uppercase letter.");
        }
    }
}
