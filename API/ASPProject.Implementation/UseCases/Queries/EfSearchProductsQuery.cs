using ASPProject.Application.DTOs;
using ASPProject.Application.DTOs.Searches;
using ASPProject.Application.UseCases.Queries;
using ASPProject.Domain;
using ASPProjekat.DataAccess;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Implementation.UseCases.Queries
{
    public class EfSearchProductsQuery : ISearhProductsQuery
    {
        private readonly ProjekatContext _context;
        private readonly IMapper _mapper;

        public EfSearchProductsQuery(ProjekatContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public int Id => 6;

        public string Name => "Get products with search and server-side pagination.";

        public IEnumerable<ProductDto> Execute(ProductsSearch request)
        {
            var query = _context.Products
                        .Include(x => x.Category)
                        .Include(x => x.Prices)
                        .Include(x => x.Specifications)
                        .ThenInclude(x => x.Specification)
                        .Include(x => x.Images);
            return query.Where(x => x.IsActive).Select(x => _mapper.Map<Product, ProductDto>(x)).ToList();

        }
  }
}
