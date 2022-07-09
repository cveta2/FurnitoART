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
    public class EfDeleteProductCommand : IDeleteProductCommand
    {
        private readonly ProjekatContext _context;
        public EfDeleteProductCommand(ProjekatContext context)
        {
            _context = context;
        }

        public int Id => 12;

        public string Name => "Delete product.";

        public void Execute(int request)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == request && x.IsActive);

            if(product == null)
            {
                throw new EntityNotFoundException(nameof(Product), request);
            }
            if (product.InOrderItems.Any())
            {
                throw new ConflictException($"Product with id of {request} can not be deleted because of it's link to some orders.");
            }

            _context.Images.RemoveRange(product.Images);
            _context.ProductSpecifications.RemoveRange(product.Specifications);
            _context.Prices.RemoveRange(product.Prices);
            _context.Products.Remove(product);

            _context.SaveChanges();
        }
    }
}
