using ASPProject.Application.DTOs;
using ASPProject.Application.Exceptions;
using ASPProject.Application.UseCases.Queries;
using ASPProject.Domain;
using ASPProjekat.DataAccess;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Implementation.UseCases.Queries
{
    public class EfFindUserQuery : IFindUserQuery
    {
        private readonly ProjekatContext _context;
        private readonly IMapper _mapper;
        public EfFindUserQuery(ProjekatContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 3;

        public string Name => "Find user by Id";

        public UserDto Execute(int request)
        {
            var user = _context.Users.Find(request);
            if(user == null || !user.IsActive )
            {
                throw new EntityNotFoundException(nameof(User), request);
            }

            return _mapper.Map<User, UserDto>(user);
        }
    }
}
