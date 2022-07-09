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
    public class EfAddCategoryCommand : IAddCategoryCommand
    {
        private readonly ProjekatContext _context;
        private readonly IMapper _mapper;
        private readonly CategoryValidator _validator;

        public EfAddCategoryCommand(ProjekatContext context, IMapper mapper, CategoryValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 18;

        public string Name => "Add new category";

        public void Execute(CategoryDto request)
        {
            _validator.ValidateAndThrow(request);

            var cat = _mapper.Map<CategoryDto, Category>(request);
            _context.Categories.Add(cat);
            _context.SaveChanges();
        }
    }
}
