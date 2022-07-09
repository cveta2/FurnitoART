using ASPProject.Application.DTOs;
using ASPProject.Application.Exceptions;
using ASPProject.Application.UseCases.Queries;
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

namespace ASPProject.Implementation.UseCases.Queries
{
    public class EfFindOrderQuery : IFindOrderQuery
    {
        public readonly ProjekatContext _context;
        private readonly IMapper _mapper;
        private readonly OrderNumberValidator _validator;
        public EfFindOrderQuery(ProjekatContext context, IMapper mapper, OrderNumberValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 14;

        public string Name => "Find order by orderNumber";

        public OrderDto Execute(int request)
        {
            _validator.ValidateAndThrow(request);

            var order = _context.Orders.FirstOrDefault(x => x.OrderNumber == request);

            if(order == null)
            {
                throw new EntityNotFoundException(nameof(Order), request);
            }

            return _mapper.Map<Order, OrderDto>(order);
        }
    }
}
