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
    public class EfGetCategoriesQuery : IGetCategoriesQuery
    {
        private readonly IMapper _mapper;
        private readonly ProjekatContext _context;

        public EfGetCategoriesQuery(IMapper mapper, ProjekatContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public int Id => 16;

        public string Name => "Search categories";

        public IEnumerable<CategoryDto> Execute(BasePagedSearch request)
        {
            var query = _context.Categories.Include(x => x.ChildCategories)
                        .Include(x => x.ParentCategory).AsQueryable();

            return query.Where(x => x.IsActive)
                            .Select(x => _mapper.Map<Category, CategoryDto>(x)).ToList();
    }
  }
}
