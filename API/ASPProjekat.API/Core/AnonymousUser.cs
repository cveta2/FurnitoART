using ASPProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPProjekat.API.Core
{
    public class AnonymousUser : IApplicationUser
    {
        public int Id => 0;
        public IEnumerable<int> AllowedUseCaseIds => new List<int> { 1, 6, 7, 16 };
        public string Email => "anonymous@project.gmail";
    }
}
