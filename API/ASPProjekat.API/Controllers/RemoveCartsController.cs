using ASPProject.Application.UseCases.Commands;
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
  [Authorize]
  public class RemoveCartsController : ControllerBase
  {
    private readonly UseCaseHandler _handler;
    private readonly IApplicationUser _user;

    public RemoveCartsController(UseCaseHandler handler, IApplicationUser user)
    {
      _handler = handler;
      _user = user;
    }

    // DELETE api/<RemoveCartsController>/5
    [HttpDelete]
    public IActionResult Delete([FromServices] IRemoveItemsFromUsersCart command)
    {
      _handler.HandleCommand(command, _user.Id);
      return NoContent();
    }
  }
}
