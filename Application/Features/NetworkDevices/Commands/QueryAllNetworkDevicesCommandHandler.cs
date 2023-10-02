using Application.Contracts.Persistence;
using Application.Features.NetworkDevices.Responses;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.NetworkDevices.Commands
{
    public class QueryAllNetworkDevicesCommandHandler : IRequestHandler<QueryAllNetworkDevicesCommand, QueryAllNetworkDevicesResponse>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<NetworkDevice> _repository;

        public QueryAllNetworkDevicesCommandHandler(IMapper mapper, IAsyncRepository<NetworkDevice> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<QueryAllNetworkDevicesResponse> Handle(QueryAllNetworkDevicesCommand request, CancellationToken cancellationToken)
        {
            var response = new QueryAllNetworkDevicesResponse();

            response.Success = true;
            response.networkDevices = await _repository.ListAllAsync();

            return response;
        }
    }
}
