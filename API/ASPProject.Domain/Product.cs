using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Domain
{
    public class Product : Entity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Price> Prices { get; set; } = new List<Price>();
        public virtual ICollection<Image> Images { get; set; } = new List<Image>();
        public virtual ICollection<OrderItem> InOrderItems { get; set; } = new List<OrderItem>();
        public virtual ICollection<ProductSpecification> Specifications { get; set; } = new List<ProductSpecification>();
    }
}
