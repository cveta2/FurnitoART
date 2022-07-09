using ASPProject.Application.UseCases.Queries;
using ASPProject.Domain;
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
  public class UsersProfileController : ControllerBase
  {
    private UseCaseHandler _handler;
    private IApplicationUser _user;

    public UsersProfileController(UseCaseHandler handler, IApplicationUser user)
    {
      _handler = handler;
      _user = user;
    }

    [HttpGet]
    [Authorize]
    public IActionResult Get([FromServices] IFindUserQuery query)
    {
      return Ok(_handler.HandleQuery(query, _user.Id));
    }
  }
}
