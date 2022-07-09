using ASPProject.Application.DTOs;
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
    public class EfGetCartItems : IGetCartItems
    {
        private readonly ProjekatContext _context;
        private readonly IMapper _mapper;

        public EfGetCartItems(ProjekatContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public int Id => 9;

        public string Name => "Get user's cart items";

        public IEnumerable<CartDto> Execute(int request)
        {
            return _context.Carts.Include(x => x.Product).ThenInclude(x => x.Prices).Where(x => x.UserId == request && x.IsActive).Select(x => _mapper.Map<Cart, CartDto>(x));
        }
    }
}
