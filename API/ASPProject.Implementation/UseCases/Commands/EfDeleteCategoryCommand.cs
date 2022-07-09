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
    public class EfDeleteCategoryCommand : IDeleteCategoryCommand
    {
        private readonly ProjekatContext _context;

        public EfDeleteCategoryCommand(ProjekatContext context)
        {
            _context = context;
        }

        public int Id => 17;

        public string Name => "Delete category";

        public void Execute(int request)
        {
            var category = _context.Categories.Find(request);

            if(category == null)
            {
                throw new EntityNotFoundException(nameof(Category), request);
            }

            if (category.Products.Any())
            {
                throw new ConflictException("It is not possible to delete this category because of its link to products.");
            }

            if (category.ChildCategories.Any())
            {
                throw new ConflictException("It is not possible to delete this category because of its subcategories.");
            }

            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}
