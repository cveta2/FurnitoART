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
    public class EfUpdateCategoryCommand : IUpdateCategoryCommand
    {
        private readonly ProjekatContext _context;

        public EfUpdateCategoryCommand(ProjekatContext context)
        {
            _context = context;
        }

        public int Id => 24;

        public string Name => "Update category";

        public void Execute(CategoryDto request)
        {
            var cat = _context.Categories.FirstOrDefault(x => x.Id == request.CategoryId);
            if(cat == null)
            {
                throw new EntityNotFoundException(nameof(Category), request.CategoryId);
            }
            cat.CategoryName = request.CategoryName;
            _context.SaveChanges();
        }
    }
}
