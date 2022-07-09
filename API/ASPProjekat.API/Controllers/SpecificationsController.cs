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
    public class SpecificationsController : ControllerBase
    {
        private readonly UseCaseHandler _handler;

        public SpecificationsController(UseCaseHandler handler)
        {
            _handler = handler;
        }

        // GET: api/<SpecificationsController>
        [HttpGet]
        public IActionResult Get([FromQuery] PagedSearch search, [FromServices] IGetSpecificationsQuery query)
        {
            return Ok(_handler.HandleQuery(query, search));
        }

        // POST api/<SpecificationsController>
        [HttpPost]
        public IActionResult Post([FromBody] SpecificationDto dto, [FromServices] IAddSpecificationCommand command)
        {
            _handler.HandleCommand(command, dto);
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<SpecificationsController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] SpecificationDto specification, [FromServices] IUpdateSpecificationCommand command)
        {
            _handler.HandleCommand(command, specification);
            return Ok();
        }

        // DELETE api/<SpecificationsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteSpecificationCommand command)
        {
            _handler.HandleCommand(command, id);
            return NoContent();
        }
    }
}
