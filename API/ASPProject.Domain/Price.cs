using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Domain
{
    public class Price : Entity
    {
        public decimal PriceValue { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
