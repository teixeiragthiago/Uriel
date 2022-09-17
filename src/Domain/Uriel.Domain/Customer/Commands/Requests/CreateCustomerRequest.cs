using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uriel.Domain.Customer.Commands.Responses;

namespace Uriel.Domain.Customer.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
