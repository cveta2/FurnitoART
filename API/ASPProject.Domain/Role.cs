using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Domain
{
    public class Role : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<RoleUseCase> RoleUseCases { get; set; } = new List<RoleUseCase>();
        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}
