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
    public class CategoriesController : ControllerBase
    {

        private readonly UseCaseHandler _handler;
        public CategoriesController(UseCaseHandler handler)
        {
            _handler = handler;
        }

        // GET: api/<CategoriesController>
        [HttpGet]
        public IActionResult Get([FromQuery] BasePagedSearch search, [FromServices] IGetCategoriesQuery query)
        {
            return Ok(_handler.HandleQuery(query, search));
        }

        // POST api/<CategoriesController>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] CategoryDto category, [FromServices] IAddCategoryCommand command)
        {
            _handler.HandleCommand(command, category);
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<CategoriesController>/5
        [HttpPut]
        [Authorize]
        public IActionResult Put([FromBody] CategoryDto category, [FromServices] IUpdateCategoryCommand command)
        {
            _handler.HandleCommand(command, category);
            return Ok();
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete(int id, [FromServices] IDeleteCategoryCommand command)
        {
            _handler.HandleCommand(command, id);
            return NoContent();
        }
    }
}
