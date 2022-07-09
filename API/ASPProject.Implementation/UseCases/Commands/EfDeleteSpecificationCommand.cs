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
    public class EfDeleteSpecificationCommand : IDeleteSpecificationCommand
    {
        private readonly ProjekatContext _context;

        public EfDeleteSpecificationCommand(ProjekatContext context)
        {
            _context = context;
        }

        public int Id => 20;

        public string Name => "Delete specification";

        public void Execute(int request)
        {
            var specification = _context.Specifications.Find(request);

            if(specification == null)
            {
                throw new EntityNotFoundException(nameof(Specification), request);
            }

            if (specification.ProductSpecifications.Any())
            {
                throw new ConflictException("It is not possible to delete this specification because of its links to products.");
            }
            _context.Specifications.Remove(specification);
            _context.SaveChanges();
        }
    }
}
