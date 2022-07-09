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
    public class EfSearchAuditLogsQuery : ISearchAuditLogsQuery
    {
        private readonly ProjekatContext _context;
        private readonly IMapper _mapper;

        public EfSearchAuditLogsQuery(ProjekatContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 27;

        public string Name => "Search audit logs";

        public PagedResponse<AuditLogDto> Execute(BasePagedSearch request)
        {
            var query = _context.AuditLogs.AsQueryable();

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.UseCaseName.ToLower().Contains(request.Keyword.ToLower()));
            }
            if (request.PerPage == null || request.PerPage < 1)
            {
                request.PerPage = 15;
            }

            if (request.Page == null || request.Page < 1)
            {
                request.Page = 1;
            }

            var toSkip = (request.Page.Value - 1) * request.PerPage.Value;



            var response = new PagedResponse<AuditLogDto>();
            response.TotalCount = query.Count();
            response.Data = query
                            .Skip(toSkip)
                            .Take(request.PerPage.Value)
                            .Select(x => _mapper.Map<AuditLog, AuditLogDto>(x)).ToList();
            response.ItemsPerPage = request.PerPage.Value;
            response.CurrentPage = request.Page.Value;

            return response;
        }
    }
}
