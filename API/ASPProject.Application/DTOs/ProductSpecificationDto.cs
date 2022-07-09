using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Application.DTOs
{
    public class ProductSpecificationDto
    {
        public int Id { get; set; }
        public string SpecificationName { get; set; }

        public string SpecificationValue { get; set; }
    }
    public class NewProductSpecificationDto
    {
        public int Id { get; set; }
        public int SpecificationId { get; set; }
        public int ProductId { get; set; }
        public string SpecificationValue { get; set; }
    }
}
