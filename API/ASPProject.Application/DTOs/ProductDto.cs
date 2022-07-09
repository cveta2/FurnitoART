using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Application.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
        public PriceDto Price { get; set; }

        public IEnumerable<ProductSpecificationDto> Specifications { get; set; }

        public IEnumerable<ImageDto> Images { get; set; }
    }

    public class PriceDto
    {
        public int Id { get; set; }
        public decimal PriceValue { get; set; }
        public int ProductId { get; set; }
    }
}
