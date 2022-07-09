using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Application.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public IEnumerable<OrderItemDto> OrderItems { get; set; }

    }
}
