using Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using Domain.Entities;
using Application.Features.NetworkDevices.Validators;
using Application.Features.NetworkDevices.Responses;

namespace Application.Features.NetworkDevices.Commands
{
    public class CreateNetworkDeviceCommandHandler : IRequestHandler<CreateNetworkDeviceCommand, CreateNetworkDeviceCommandResponse>
    {
        IMapper _mapper;
        IAsyncRepository<NetworkDevice> _repository;

        public CreateNetworkDeviceCommandHandler(IMapper mapper, IAsyncRepository<NetworkDevice> repository) 
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<CreateNetworkDeviceCommandResponse> Handle(CreateNetworkDeviceCommand request, CancellationToken cancellationToken)
        {
            var createNetworkDeviceCommandResponse = new CreateNetworkDeviceCommandResponse();

            var validator = new CreateNetworkDeviceCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Any()) 
            {
                createNetworkDeviceCommandResponse.ValidationErrors = new List<string>();
                foreach(var error in  validationResult.Errors)
                {
                    createNetworkDeviceCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if(createNetworkDeviceCommandResponse.Success)
            {
                var networkDevice = new NetworkDevice()
                {
                    HostName = request.HostName,
                    IP = request.IP,
                    Vendor = request.Vendor,
                    OS = request.OS,
                    OSVersion = request.OSVersion,
                    Location = request.Location,
                };

                await _repository.AddAsync(networkDevice);
            }

            return createNetworkDeviceCommandResponse;
        }
    }
}
