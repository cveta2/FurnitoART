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
    public class EfPlaceOrderCommand : IPlaceOrderCommand
    {
        private readonly ProjekatContext _context;
        private readonly IMapper _mapper;
        private readonly IApplicationUser _user;
        private readonly PlaceOrderValidator _validator;
        public EfPlaceOrderCommand(ProjekatContext context, IMapper mapper, IApplicationUser user, PlaceOrderValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _user = user;
            _validator = validator;
        }

        public int Id => 13;

        public string Name => "User places an order";

        public void Execute(OrderDto request)
        {
            _validator.ValidateAndThrow(request);

            var order = _mapper.Map<OrderDto, Order>(request);
            order.UserId = _user.Id;
            order.OrderNumber = new Random().Next(1000000, 9999999);

            _context.Orders.Add(order);
            _context.SaveChanges();


            //var items = _mapper.Map<IEnumerable<OrderItemDto>, IEnumerable<OrderItem>>(request.OrderItems);

            //foreach(var item in items)
            //{
            //    item.OrderId = order.Id;  
            //}
            //_context.OrderItems.AddRange(items);

            //_context.SaveChanges();
        }
    }
}
