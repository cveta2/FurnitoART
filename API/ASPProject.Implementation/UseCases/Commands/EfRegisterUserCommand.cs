using ASPProject.Application.DTOs;
using ASPProject.Application.UseCases;
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
    public class EfRegisterUserCommand : IRegisterUserCommand
    {
        private readonly ProjekatContext _context;
        private readonly IMapper _mapper;
        private readonly RegisterUserValidator _validator;
        public EfRegisterUserCommand(IMapper mapper, ProjekatContext context, RegisterUserValidator validator)
        {
            _mapper = mapper;
            _context = context;
            _validator = validator;
        }
        public int Id => 1;
        public string Name => "Register user command";

        public void Execute(RegisterDto request)
        {
            request.RoleId = 1;
            _validator.ValidateAndThrow(request);

            _context.Users.Add(_mapper.Map<RegisterDto, User>(request));

            _context.SaveChanges();

            //sending email
        }
    }
}
