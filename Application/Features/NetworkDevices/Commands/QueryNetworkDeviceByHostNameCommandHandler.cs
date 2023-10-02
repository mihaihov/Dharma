using AutoMapper;
using MediatR;
using Application.Contracts.Persistence;
using Application.Features.NetworkDevices.Validators;
using Application.Features.NetworkDevices.Responses;

namespace Application.Features.NetworkDevices.Commands
{
    public class QueryNetworkDeviceByHostNameCommandHandler : IRequestHandler<QueryNetworkDeviceByHostNameCommand, QueryNetworkDeviceByHostNameCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly INetworkDeviceRepository _repository;

        public QueryNetworkDeviceByHostNameCommandHandler(IMapper mapper, INetworkDeviceRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<QueryNetworkDeviceByHostNameCommandResponse> Handle(QueryNetworkDeviceByHostNameCommand request, CancellationToken cancellationToken)
        {
            var response = new QueryNetworkDeviceByHostNameCommandResponse();

            var validator = new QueryNetworkDeviceByHostNameCommandValidator();
            var validationResponse = await validator.ValidateAsync(request);

            if(validationResponse.Errors.Any())
            {
                response.Success = false;
                response.ValidationErrors = new List<string>();
                foreach(var error in validationResponse.Errors)
                {
                    response.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if(response.Success)
            {
                response.NetworkDevice = await _repository.GetByHostNameAsync(request.HostName);
            }

            return response;
        }
    }
}
