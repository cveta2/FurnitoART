using ASPProject.Application.DTOs.Searches;
using ASPProject.Application.UseCases.Queries;
using ASPProject.Implementation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPProjekat.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditLogsController : ControllerBase
    {
        private readonly UseCaseHandler _handler;

        public AuditLogsController(UseCaseHandler handler)
        {
            _handler = handler;
        }

        // GET: api/<AuditLogsController>
        [HttpGet]
        [Authorize]
        public IActionResult Get([FromQuery] BasePagedSearch search, [FromServices] ISearchAuditLogsQuery query)
        {
            return Ok(_handler.HandleQuery(query, search));
        }
    }
}
