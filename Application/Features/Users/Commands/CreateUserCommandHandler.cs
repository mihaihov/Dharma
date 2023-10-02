using Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using Domain.Entities;
using Application.Features.Users.Validators;
using Application.Features.Users.Responses;

namespace Application.Features.Users.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<User> _userRepository;

        public CreateUserCommandHandler(IMapper mapper, IAsyncRepository<User> userRepository) 
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var createUserCommandResponse = new CreateUserCommandResponse();

            var validator = new CreateUserCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Any())
            {
                createUserCommandResponse.Success = false;
                createUserCommandResponse.ValidationErrors = new List<string>();
                foreach(var error in validationResult.Errors)
                {
                    createUserCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if(createUserCommandResponse.Success)
            {
                var user = new User()
                {
                    UserName = request.UserName,
                    Password = request.Password,
                    Location = request.Location,
                    Department = request.Department,
                    LocationId = request.LocationId,
                };
                user = await _userRepository.AddAsync(user);
            }

            return createUserCommandResponse;
        }
    }
}
