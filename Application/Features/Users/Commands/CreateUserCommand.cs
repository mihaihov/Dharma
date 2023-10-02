using Application.Features.Users.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Commands
{
    public class CreateUserCommand : IRequest<CreateUserCommandResponse>
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? Department {  get; set; }
        public string? Location { get; set; }
        public int? LocationId { get; set; }
    }
}
