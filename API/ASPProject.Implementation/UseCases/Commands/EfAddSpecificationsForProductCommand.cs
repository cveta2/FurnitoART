using ASPProject.Application.DTOs;
using ASPProject.Application.UseCases.Commands;
using ASPProject.Domain;
using ASPProjekat.DataAccess;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Implementation.UseCases.Commands
{
    public class EfAddSpecificationsForProductCommand : IAddSpecificationsForProductCommand
    {
        private readonly ProjekatContext _context;
        private readonly IMapper _mapper;

        public EfAddSpecificationsForProductCommand(ProjekatContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 25;

        public string Name => "Add specifications for product";

        public void Execute(NewProductSpecificationDto request)
        {
            var prodSpec = _mapper.Map<NewProductSpecificationDto, ProductSpecification>(request);
            _context.ProductSpecifications.Add(prodSpec);
            _context.SaveChanges();
        }
    }
}
