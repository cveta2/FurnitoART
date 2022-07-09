using ASPProject.Application.DTOs;
using ASPProject.Application.Exceptions;
using ASPProject.Application.UseCases.Commands;
using ASPProject.Domain;
using ASPProjekat.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Implementation.UseCases.Commands
{
    public class EfUpdateCartItemCommand : IUpdateCartItemCommand
    {
        private readonly ProjekatContext _context;
        public EfUpdateCartItemCommand(ProjekatContext context)
        {
            _context = context;
        }

        public int Id => 11;

        public string Name => "Update the quantity of product for cart item";

        public void Execute(CartDto request)
        {
            if (request.Quantity < 1 )
            {
                request.Quantity = 1;
            }

            var item = _context.Carts.FirstOrDefault(x => x.IsActive && x.Id == request.Id);

            if(item == null)
            {
                throw new EntityNotFoundException(nameof(Cart), request.Id);
            }

            item.Quantity = request.Quantity;
            _context.SaveChanges();
        }
    }
}
