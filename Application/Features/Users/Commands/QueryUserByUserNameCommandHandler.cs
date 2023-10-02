using Application.Contracts.Persistence;
using Application.Features.Users.Responses;
using Application.Features.Users.Validators;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Commands
{
    public class QueryUserByUserNameCommandHandler : IRequestHandler<QueryUserByUserNameCommand, QueryUserByUserNameCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public QueryUserByUserNameCommandHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<QueryUserByUserNameCommandResponse> Handle(QueryUserByUserNameCommand request, CancellationToken cancellationToken)
        {
            var response = new QueryUserByUserNameCommandResponse();

            var validator = new QueryUserByUserNameCommandValidator();
            var validationResponse = await validator.ValidateAsync(request);

            if(validationResponse.Errors.Any())
            {
                response.Success = false;
                response.ValidationErrors = new List<string>();
                foreach(var error in  validationResponse.Errors)
                {
                    response.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if(response.Success)
            {
                response.User = await _userRepository.GetByUserNameAsync(request.UserName);
            }

            return response;
        }
    }
}
