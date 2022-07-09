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
    public class EfUpdateSpecificationCommand : IUpdateSpecificationCommand
    {
        private readonly ProjekatContext _context;

        public EfUpdateSpecificationCommand(ProjekatContext context)
        {
            _context = context;
        }

        public int Id => 23;

        public string Name => "Update specification";

        public void Execute(SpecificationDto request)
        {
            var spec = _context.Specifications.FirstOrDefault(x => x.Id == request.SpecificationId);
            if(spec == null)
            {
                throw new EntityNotFoundException(nameof(Specification), request.SpecificationId);
            }
            spec.SpecificationName = request.SpecificationName;
            _context.SaveChanges();
        }
    }
}
