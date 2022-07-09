using ASPProject.Application.DTOs;
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
    public class EfAddSpecificationCommand : IAddSpecificationCommand
    {
        private readonly ProjekatContext _context;
        private readonly IMapper _mapper;
        private readonly SpecificationValidator _validator;

        public EfAddSpecificationCommand(ProjekatContext context, IMapper mapper, SpecificationValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 21;

        public string Name => "Add new specification";

        public void Execute(SpecificationDto request)
        {
            _validator.ValidateAndThrow(request);

            _context.Specifications.Add(_mapper.Map<SpecificationDto, Specification>(request));
            _context.SaveChanges();
        }
    }
}
