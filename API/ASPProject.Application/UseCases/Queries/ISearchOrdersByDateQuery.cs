using ASPProject.Application.DTOs;
using ASPProject.Application.DTOs.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Application.UseCases.Queries
{
    public interface ISearchOrdersByDateQuery : IQuery<OrdersSearch, IEnumerable<OrderDto>>
    {
    }
}
