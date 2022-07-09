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
    public class EfAddProductToCartCommand : IAddProductToCartCommand
    {
        private readonly ProjekatContext _context;
        private readonly IMapper _mapper;
        private readonly IApplicationUser _user;
        private readonly AddProductToCartValidator _validator;
        public EfAddProductToCartCommand(ProjekatContext context, IMapper mapper, IApplicationUser user, AddProductToCartValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _user = user;
            _validator = validator;
        }
        public int Id => 8;

        public string Name => "Add product to users cart";

        public void Execute(AddToCartDto request)
        {
            request.UserId = _user.Id;
      _validator.ValidateAndThrow(request);
      var cart = _context.Carts.FirstOrDefault(x => x.UserId == request.UserId && x.ProductId == request.ProductId && x.IsActive);
            if(cart != null)
              {
        cart.Quantity = request.Quantity;

              }
      else
      {
        _context.Carts.Add(_mapper.Map<AddToCartDto, Cart>(request));
      }

      _context.SaveChanges();
        }
    }
}
