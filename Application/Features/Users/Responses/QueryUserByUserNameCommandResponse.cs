using Application.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Responses
{
    public class QueryUserByUserNameCommandResponse : BaseResponse
    {
        public QueryUserByUserNameCommandResponse() : base() { }


        public User? User { get; set; }
    }
}
