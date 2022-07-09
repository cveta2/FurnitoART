using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Domain
{
    public interface IApplicationUser
    {
        int Id { get; }
        IEnumerable<int> AllowedUseCaseIds { get; }
        string Email { get; }

    }
}
