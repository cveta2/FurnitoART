using ASPProject.Application.DTOs;
using ASPProject.Application.DTOs.Searches;
using ASPProject.Application.UseCases.Commands;
using ASPProject.Application.UseCases.Queries;
using ASPProject.Implementation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    [Authorize]
    public class OrdersController : ControllerBase
    {

        private readonly UseCaseHandler _handler;
        public OrdersController(UseCaseHandler handler)
        {
            _handler = handler;
        }
        // GET: api/<OrdersController>
        [HttpGet]
        public IActionResult Get([FromQuery] OrdersSearch search, [FromServices] ISearchOrdersByDateQuery query)
        {
            return Ok(_handler.HandleQuery(query, search));
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        //pretrazivanje porudzbina po broju porudzbine
        public IActionResult Get(int id, [FromServices] IFindOrderQuery query)
        {
            return Ok(_handler.HandleQuery(query, id));
        }

        // POST api/<OrdersController>
        [HttpPost]
        public IActionResult Post([FromBody] OrderDto order, [FromServices] IPlaceOrderCommand command)
        {
            _handler.HandleCommand(command, order);
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
