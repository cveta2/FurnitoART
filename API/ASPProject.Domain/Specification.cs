using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Domain
{
    public class Specification : Entity
    {
        public string SpecificationName { get; set; }

        public virtual ICollection<ProductSpecification> ProductSpecifications { get; set; } = new List<ProductSpecification>();
    }
}
