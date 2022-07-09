using ASPProject.Application.DTOs;
using ASPProject.Application.Exceptions;
using ASPProject.Application.UseCases.Queries;
using ASPProject.Domain;
using ASPProjekat.DataAccess;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Implementation.UseCases.Queries
{
    public class EfFindProductQuery : IFindProductQuery
    {
        public readonly ProjekatContext _context;
        private readonly IMapper _mapper;
        public EfFindProductQuery(ProjekatContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public int Id => 7;

        public string Name => "Find product by id";

        public ProductDto Execute(int request)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == request && x.IsActive);

            if(product == null)
            {
                throw new EntityNotFoundException(nameof(Product), request);
            }

            return _mapper.Map<Product, ProductDto>(product);
        }
    }
}
