using ASPProject.Application.DTOs;
using ASPProjekat.API.Core;
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
    public class LoginController : ControllerBase
    {
        private readonly JwtManager _manager;
        public LoginController(JwtManager manager)
        {
            _manager = manager;
        }
        // POST api/<LoginController>
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Post([FromBody] LogInDto dto)
        {
            var token = _manager.MakeToken(dto.Email, dto.Password);
            return Ok(new { token });
        }
    }
}
