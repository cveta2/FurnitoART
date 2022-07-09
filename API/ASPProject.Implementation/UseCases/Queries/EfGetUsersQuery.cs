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
    public class EfGetUsersQuery : IGetUsersQuery
    {
        private readonly ProjekatContext _context;
        private readonly IMapper _mapper;
        public EfGetUsersQuery(ProjekatContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public int Id => 2;

        public string Name => "Get all users with server-side pagination.";

        public PagedResponse<UserDto> Execute(BasePagedSearch request)
        {
            var query = _context.Users
                        .Include(x => x.Role)
                        .ThenInclude(x => x.RoleUseCases)
                        .Include(x => x.Orders)
                        .ThenInclude(x => x.OrderItems)
                        .Include(x => x.CartItems)
                        .AsQueryable(); //include roles i use cases

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.FirstName.ToLower().Contains(request.Keyword.ToLower()) || x.LastName.ToLower().Contains(request.Keyword.ToLower()));
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



            var response = new PagedResponse<UserDto>();
            response.TotalCount = query.Count();
            response.Data = query.Where(x => x.IsActive)
                            .Skip(toSkip)
                            .Take(request.PerPage.Value)
                            .Select(x => _mapper.Map<User, UserDto>(x))
                            .ToList();
            response.ItemsPerPage = request.PerPage.Value;
            response.CurrentPage = request.Page.Value;

            return response;
        }
    }
}
