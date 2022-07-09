using ASPProject.Application.DTOs;
using ASPProject.Application.DTOs.Searches;
using ASPProject.Application.UseCases;
using ASPProject.Application.UseCases.Queries;
using ASPProject.Domain;
using ASPProjekat.DataAccess;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASPProject.Implementation.UseCases.Queries
{
    public class EfSearchOrdersByDateQuery : ISearchOrdersByDateQuery
    {
        private readonly ProjekatContext _context;
        private readonly IMapper _mapper;
    private readonly IApplicationUser _user;

        public EfSearchOrdersByDateQuery(ProjekatContext context, IMapper mapper, IApplicationUser user)
        {
            _context = context;
            _mapper = mapper;
      _user = user;
        }

        public int Id => 15;

        public string Name => "Search orders by date with server-side pagination";

        public IEnumerable<OrderDto> Execute(OrdersSearch request)
        {
            var query = _context.Orders.Include(x => x.OrderItems).ThenInclude(x => x.Product).Where(x => x.UserId == _user.Id).Select(x => _mapper.Map<Order, OrderDto>(x)).ToList();

            //var dateStart = ChangeDate(request.date, 00, 00, 00);
            //var dateEnd = ChangeDate(request.date, 23, 59, 59);

            //if (request.date != DateTime.MinValue)
            //{
            //    query = query.Where(x => x.CreatedAt >= dateStart && x.CreatedAt <= dateEnd);
            //}
            //if (request.PerPage.Value < 1 || request.PerPage == null)
            //{
            //    request.PerPage = 15;
            //}
            //if (request.Page < 1 || request.Page == null)
            //{
            //    request.Page = 1;
            //}
            //var toSkip = (request.Page.Value - 1) * request.PerPage.Value;

            //var response = new PagedResponse<OrderDto>();

            //response.ItemsPerPage = request.PerPage.Value;
            //response.CurrentPage = request.Page.Value;
            //response.TotalCount = query.Count();
            //response.Data = query.Skip(toSkip).Take(request.PerPage.Value)
            //                    .Select(x => _mapper.Map<Order, OrderDto>(x))
            //                    .ToList();

            return query;
        }

        public DateTime ChangeDate(DateTime date, int hours, int minutes, int seconds)
        {
            return new DateTime(date.Year, date.Month, date.Day, hours, minutes, seconds);
        }

  }
}
