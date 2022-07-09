using ASPProject.Application.DTOs;
using ASPProject.Application.Exceptions;
using ASPProject.Application.UseCases.Commands;
using ASPProject.Domain;
using ASPProject.Implementation.Validators;
using ASPProjekat.DataAccess;
using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Implementation.UseCases.Commands
{
    public class EfUpdateUserCommand : IUpdateUserCommand
    {
        private readonly ProjekatContext _context;
        private readonly IMapper _mapper;
        private readonly UpdateUserValidator _validator;
        private IApplicationUser _user;

        public EfUpdateUserCommand(ProjekatContext context, IMapper mapper, UpdateUserValidator validator, IApplicationUser user)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
            _user = user;
        }
        
        public int Id => 4;

        public string Name => "Update user";

        public void Execute(UpdateUserDto request)
        {
            request.Id = _user.Id;
            var user = _context.Users.Find(request.Id);

            if(user == null)
            {
                throw new EntityNotFoundException(nameof(User), request.Id);
            }

            _validator.ValidateAndThrow(request);

            _mapper.Map(request, user);
            _context.SaveChanges();
        }
    }
}
