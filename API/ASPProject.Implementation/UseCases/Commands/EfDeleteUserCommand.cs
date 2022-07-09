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
    public class EfDeleteUserCommand : IDeleteUserCommand
    {
        private readonly ProjekatContext _context;

        public EfDeleteUserCommand(ProjekatContext context)
        {
            _context = context;
        }
        public int Id => 5;

        public string Name => "Delete user with specific Id";

        public void Execute(int request)
        {
            var user = _context.Users.Find(request);

            if(user == null)
            {
                throw new EntityNotFoundException(nameof(User), request);
            }
            _context.Remove(user);
            _context.SaveChanges();
        }
    }
}
