using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Application.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IEnumerable<OrderDto> Orders { get; set; }
        public string Role { get; set; }
        public int RoleId { get; set; }
        public IEnumerable<int> UseCases { get; set; }
        public IEnumerable<CartDto> CartItems { get; set; }
    }
}
