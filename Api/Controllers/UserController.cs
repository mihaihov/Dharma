using Application.Features.Users.Commands;
using Application.Features.Users.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("byusername", Name = "GetUserByUsername")]
        public async Task<ActionResult<QueryUserByUserNameCommandResponse>> GetUserByUsername([FromBody] QueryUserByUserNameCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}