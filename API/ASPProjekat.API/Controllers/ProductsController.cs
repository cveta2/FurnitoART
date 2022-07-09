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
    public class ProductsController : ControllerBase
    {
        private readonly UseCaseHandler _handler;
        public ProductsController(UseCaseHandler handler)
        {
            _handler = handler;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Get([FromQuery] ProductsSearch search, [FromServices] ISearhProductsQuery query)
        {
            var products = _handler.HandleQuery(query, search);
            return Ok(products);
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult Get(int id, [FromServices] IFindProductQuery query)
        {
            var product = _handler.HandleQuery(query, id);
            return Ok(product);
        }

        // POST api/<ProductsController>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromForm] NewProductsDto product, [FromServices] IAddProductCommand command)
        {
            _handler.HandleCommand(command, product);
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<ProductsController>/5
        [HttpPut]
        public IActionResult Put([FromBody] NewProductsDto dto, [FromServices] IUpdateProductCommand command)
        {
            _handler.HandleCommand(command, dto);
            return Ok();
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete(int id, [FromServices] IDeleteProductCommand command)
        {
            _handler.HandleCommand(command, id);
            return NoContent();
        }
    }
}
