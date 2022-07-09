using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Domain
{
    public class ProductSpecification : Entity
    {
        public int SpecificationId { get; set; }
        public int ProductId { get; set; }
        public string SpecificationValue { get; set; }

        public virtual Specification Specification { get; set; }
        public virtual Product Product { get; set; }
    }
}
