using ASPProject.Application.DTOs;
using ASPProject.Application.UseCases.Commands;
using ASPProject.Application.UseCases.Queries;
using ASPProject.Domain;
using ASPProject.Implementation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPProjekat.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CartsController : ControllerBase
    {
        private readonly UseCaseHandler _handler;
        private readonly IApplicationUser _user;
        public CartsController(UseCaseHandler handler, IApplicationUser user)
        {
            _handler = handler;
            _user = user;
        }
        // GET: api/<CartsController>
        [HttpGet]
        public IActionResult Get([FromServices] IGetCartItems query)
        {
            var items = _handler.HandleQuery(query, _user.Id);
            return Ok(items);
        }

        // POST api/<CartsController>
        [HttpPost]
        public IActionResult Post([FromBody] AddToCartDto dto, [FromServices] IAddProductToCartCommand command)
        {
            _handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<CartsController>/5
        [HttpPut("{id}")]
        public IActionResult Put( [FromBody] CartDto dto, [FromServices] IUpdateCartItemCommand command)
        {
            _handler.HandleCommand(command, dto);
            return Ok();
        }

        // DELETE api/<CartsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteItemFromCartCommand command)
        {
            _handler.HandleCommand(command, id);
            return NoContent();
        }

       
    }
}
