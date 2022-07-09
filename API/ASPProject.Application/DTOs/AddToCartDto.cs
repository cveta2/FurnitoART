using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Application.DTOs
{
    public class AddToCartDto
    {
        public int ProductId { get; set; } = 0;
        public int UserId { get; set; }
        public int Quantity { get; set; }
    }
}
