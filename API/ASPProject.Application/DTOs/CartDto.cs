using ASPProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Application.DTOs
{
    public class CartDto 
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Product { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
  }
}
