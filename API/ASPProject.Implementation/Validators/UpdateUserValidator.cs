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
    public class UpdateUserValidator : AbstractValidator<UpdateUserDto>
    {
        public UpdateUserValidator(ProjekatContext context)
        {
      RuleFor(x => x.Email)
          .Cascade(CascadeMode.Stop)
          .NotEmpty().WithMessage("Email is required.")
          .EmailAddress().WithMessage("Email is not in correct format. E.g. useremail@mail.com");

            var nameRegex = @"^[A-Z][a-z]{2,}(\s[A-Z][a-z]{2,})?$";
            var passwordRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";


            RuleFor(x => x.FirstName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("First name is required.")
                .Matches(nameRegex).WithMessage("First name is not in the correct format.");

            RuleFor(x => x.LastName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Last name is required.")
                .Matches(nameRegex).WithMessage("Last name is not in the correct format.");

            //RuleFor(x => x.Password)
            //    .Cascade(CascadeMode.Stop)
            //    .NotEmpty().WithMessage("Password is required.")
            //    .Matches(passwordRegex).WithMessage("Password shoud be minimum 8 characters long(at least one uppercase and lowercase letter, digit and special character.)");

            //RuleFor(x => x.RoleId)
            //    .NotEmpty().WithMessage("Role is required");
        }
    }
}
