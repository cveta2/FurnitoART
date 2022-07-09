using ASPProject.Application.DTOs;
using ASPProject.Application.DTOs.Searches;
using ASPProject.Application.UseCases.Commands;
using ASPProject.Application.UseCases.Queries;
using ASPProject.Implementation;
using ASPProjekat.API.Core;
using ASPProjekat.DataAccess;
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
    public class UsersController : ControllerBase
    {
        private readonly UseCaseHandler _handler;
        public UsersController(UseCaseHandler handler)
        {
            _handler = handler;
        }
        // GET: api/<UsersController>
        [HttpGet]
        [Authorize]
        public IActionResult Get([FromQuery] BasePagedSearch search, [FromServices] IGetUsersQuery query)
        {
           var users = _handler.HandleQuery(query, search);
           return Ok(users);
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        [Authorize]
        public IActionResult Get(int id, [FromServices] IFindUserQuery query)
        {
            return Ok(_handler.HandleQuery(query, id));
        }

        // POST api/<UsersController>
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Post([FromBody] RegisterDto registerUserDto, [FromServices] IRegisterUserCommand command)
        {
            _handler.HandleCommand(command, registerUserDto);
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<UsersController>/5
        [HttpPut]
        [Authorize]
        public IActionResult Put( [FromBody] UpdateUserDto request, [FromServices] IUpdateUserCommand command)
        {
            _handler.HandleCommand(command, request);
            return Ok();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteUserCommand command)
        {
            _handler.HandleCommand(command, id);
            return NoContent();
        }
    }
}
