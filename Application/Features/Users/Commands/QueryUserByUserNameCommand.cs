using Application.Features.Users.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Commands
{
    public class QueryUserByUserNameCommand : IRequest<QueryUserByUserNameCommandResponse>
    {
       public string UserName { get; set; } = string.Empty;
    }
}
