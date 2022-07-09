using ASPProject.Application.DTOs;
using ASPProject.Application.DTOs.Searches;
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
    public class EfGetSpecificationsQuery : IGetSpecificationsQuery
    {
        private readonly ProjekatContext _context;
        private readonly IMapper _mapper;

        public EfGetSpecificationsQuery(ProjekatContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 19;

        public string Name => "Get all specifications";

        public PagedResponse<SpecificationDto> Execute(PagedSearch request)
        {
            var query = _context.Specifications.Where(x => x.IsActive).AsQueryable();
            
            if (request.PerPage == null || request.PerPage < 1)
            {
                request.PerPage = 15;
            }

            if (request.Page == null || request.Page < 1)
            {
                request.Page = 1;
            }

            var toSkip = (request.Page.Value - 1) * request.PerPage.Value;



            var response = new PagedResponse<SpecificationDto>();
            response.TotalCount = query.Count();
            response.Data = query
                            .Skip(toSkip)
                            .Take(request.PerPage.Value)
                            .Select(x => _mapper.Map<Specification, SpecificationDto>(x))
                            .ToList();
            response.ItemsPerPage = request.PerPage.Value;
            response.CurrentPage = request.Page.Value;

            return response;
        }
    }
}
