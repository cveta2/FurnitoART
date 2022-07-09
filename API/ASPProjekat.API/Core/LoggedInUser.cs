using ASPProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPProjekat.API.Core
{
    public class LoggedInUser : IApplicationUser
    {
        public int Id { get; set; }

        public IEnumerable<int> AllowedUseCaseIds { get; set; } = new List<int>();

        public string Email { get; set; }
    }
}
