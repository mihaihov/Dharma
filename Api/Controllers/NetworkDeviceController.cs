using Application.Features.NetworkDevices.Commands;
using Application.Features.NetworkDevices.Responses;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NetworkDeviceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NetworkDeviceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllNetworkDevices")]
        public async Task<ActionResult<QueryNetworkDeviceByHostNameCommandResponse>> GetAllNetworkDevices()
        {
            var result = await _mediator.Send(new QueryAllNetworkDevicesCommand());
            return Ok(result);
        }

        [HttpGet(Name = "GetNetworkDeviceByHostName")]
        public async Task<ActionResult<QueryNetworkDeviceByHostNameCommandResponse>> GetNetworkDeviceByHostName([FromBody] QueryNetworkDeviceByHostNameCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}