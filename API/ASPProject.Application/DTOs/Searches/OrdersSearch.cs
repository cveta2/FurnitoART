using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Application.DTOs.Searches
{
    public class OrdersSearch : PagedSearch
    {
        public DateTime date { get; set; }
    }
}
