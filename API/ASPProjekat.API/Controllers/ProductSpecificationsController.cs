using ASPProject.Application.DTOs;
using ASPProject.Application.UseCases.Commands;
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
    public class ProductSpecificationsController : ControllerBase
    {
        private readonly UseCaseHandler _handler;

        public ProductSpecificationsController(UseCaseHandler handler)
        {
            _handler = handler;
        }

        // POST api/<ProductSpecificationsController>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] NewProductSpecificationDto request, [FromServices] IAddSpecificationsForProductCommand command)
        {
            _handler.HandleCommand(command, request);
            return Ok();
        }

        // PUT api/<ProductSpecificationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
