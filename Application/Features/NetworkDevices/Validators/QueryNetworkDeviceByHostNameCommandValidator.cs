using Application.Features.NetworkDevices.Commands;
using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.NetworkDevices.Validators
{
    public class QueryNetworkDeviceByHostNameCommandValidator : AbstractValidator<QueryNetworkDeviceByHostNameCommand>
    {
        public QueryNetworkDeviceByHostNameCommandValidator()
        {
            RuleFor(p => p.HostName).NotEmpty()
                .NotNull();
        }
    }
}
