using ASPProject.Application.DTOs;
using ASPProject.Application.Exceptions;
using ASPProject.Application.UseCases.Commands;
using ASPProject.Domain;
using ASPProject.Implementation.Validators;
using ASPProjekat.DataAccess;
using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASPProject.Implementation.UseCases.Commands
{
    public class EfAddProductCommand : IAddProductCommand
    {
        private readonly ProjekatContext _context;
        private readonly IMapper _mapper;
        private readonly ProductValidator _validator;

        public EfAddProductCommand(ProjekatContext context, IMapper mapper, ProductValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }


        public int Id => 22;

        public string Name => "Add new product";
        private static IEnumerable<string> allowedExtensions = new List<string> { ".jpg", ".png", ".jpeg" };

    public void Execute(NewProductsDto request)
        {
            _validator.ValidateAndThrow(request);

            if(_context.Products.Any(x => x.ProductName == request.ProductName))
            {
                throw new UnprocessableEntityException("Product with this name already exists");
            }

            if(!_context.Categories.Any(x => x.Id == request.CategoryId))
            {
                throw new UnprocessableEntityException("Provided category for this product does not exists in our system. First add the category, then the product.");
            }

            if (request.Images == null || request.Images.Count() == 0)
            {
                throw new UnprocessableEntityException("Product must have at least one image. Select an image.");
            }

            var product = _mapper.Map<NewProductsDto, Product>(request);
            _context.Products.Add(product);
            _context.SaveChanges();
            
            foreach(var file in request.Images)
            {
                var guid = Guid.NewGuid().ToString();

                var extension = Path.GetExtension(file.FileName);

                if (!allowedExtensions.Contains(extension))
                {
                    throw new InvalidOperationException("Unsupported file type.");
                }

                var fileName = guid + extension;

                var filePath = Path.Combine("wwwroot", "images", fileName);

                using var stream = new FileStream(filePath, FileMode.Create);

                file.CopyTo(stream);

                _context.Images.Add(new Image
                {
                    ProductId = product.Id,
                    Path = fileName,
                    Alt = "Image for product " + product.Id
                });
            }

            _context.Prices.Add(new Price
            {
                ProductId = product.Id,
                PriceValue = request.Price
            });

            _context.SaveChanges();
        }
    }
}
