using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Application.DTOs.Searches
{
    public class ProductsSearch : BasePagedSearch
    {
        public int Category { get; set; }
    }
}
