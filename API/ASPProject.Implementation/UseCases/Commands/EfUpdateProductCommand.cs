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
    public class EfUpdateProductCommand : IUpdateProductCommand
    {
        private readonly ProjekatContext _context;

        public EfUpdateProductCommand(ProjekatContext context)
        {
            _context = context;
        }

        public int Id => 26;

        public string Name => "Update product";

        public void Execute(NewProductsDto request)
        {
            var product =  _context.Products.FirstOrDefault(x => x.Id == x.Id);
            if(product == null)
            {
                throw new EntityNotFoundException(nameof(Product), request.Id);
            }
            product.ProductName = request.ProductName;
            var price = _context.Prices.Where(x => x.ProductId == request.Id).OrderByDescending(x => x.CreatedAt).FirstOrDefault();
            price.PriceValue = request.Price;
            product.Description = request.Description;
            product.CategoryId = request.CategoryId;

            _context.SaveChanges();
        }
    }
}
