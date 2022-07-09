using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Application.DTOs.Searches
{
    public class BasePagedSearch : PagedSearch
    {
        public string Keyword { get; set; }
    }
}
