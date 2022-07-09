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
    public class EfDeleteItemFromCartCommand : IDeleteItemFromCartCommand
    {
        private readonly ProjekatContext _context;
        public EfDeleteItemFromCartCommand(ProjekatContext context)
        {
            _context = context;
        }

        public int Id => 10;

        public string Name => "Remove one item from users cart";

        public void Execute(int request)
        {
            var cartItem = _context.Carts.FirstOrDefault(x => x.Id == request && x.IsActive);
            if(cartItem == null)
            {
                throw new EntityNotFoundException(nameof(Cart), request);
            }
            _context.Carts.Remove(cartItem);
            _context.SaveChanges();
        }
    }
}
