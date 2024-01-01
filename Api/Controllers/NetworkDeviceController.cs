using Application.Features.Ansible.Commands;
using Application.Features.Ansible.Responses;
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

        [HttpGet("ciscohostname", Name = "GetCiscoHostname")]
        public async Task<ActionResult<CiscoDeviceHostnameCommandResponse>> GetCiscoDeviceInformation([FromBody] CiscoDeviceHostnameCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("ciscosoftwareinformation", Name ="GetCiscoSoftwareInformation")]
        public async Task<ActionResult<CiscoDeviceSoftwareInformationCommandResponse>> GetCiscoSoftwareInformation([FromBody] CiscoDeviceHostnameCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("ciscosoftwareversion", Name ="GetCiscoSoftwareVersion")]
        public async Task<ActionResult<CiscoSoftwareVersionCommandResponse>> GetCiscoSoftwareVersion([FromBody] CiscoSoftwareVersionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("getciscosnmpv3configuration", Name = "GetCiscoSnmpV3Configuration")]
        public async Task<ActionResult<GetCiscoSnmpV3CommandResponse>> GetCiscoSnmpV3Configuration([FromBody] GetCiscoSnmpV3Command command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("getciscointerfaces", Name ="GetCiscoInterfaces")]
        public async Task<ActionResult<GetCiscoInterfacesCommandResponse>> GetCiscoInterfaces([FromBody] GetCiscoInterfacesCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("ciscogatherfacts", Name = "CiscoGatherFacts")]
        public async Task<ActionResult<CiscoGatherFactsCommandResponse>> CiscoGatherFacts([FromBody] CiscoGatherFactsCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("getciscontp", Name = "GetCiscoNTP")]
        public async Task<ActionResult<GetCiscoNTPCommandResponse>> GetCiscoNTP([FromBody] GetCiscoNTPCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("getciscodhcp", Name = "GetCiscoDHCP")]
        public async Task<ActionResult<GetCiscoDhcpCommandResponse>> GetCiscoDHCP([FromBody] GetCiscoDhcpCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("getciscointerfaceconfiguration", Name ="GetCiscoInterfaceConfiguration")]
        public async Task<ActionResult<GetCiscoInterfaceConfigurationCommandResponse>> GetCiscoInterfaceConfiguration([FromBody] GetCiscoInterfaceConfigurationCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("getciscoacl", Name="GetCiscoAcl")]
        public async Task<ActionResult<GetCiscoAclCommandResponse>> GetCiscoAcl([FromBody] GetCiscoAclCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}