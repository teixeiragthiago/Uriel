using MediatR;
using System;
using Uriel.Domain.Customer.Commands.Responses;

namespace Uriel.Domain.Customer.Commands.Requests
{
    public class FindCustomerByIdRequest : IRequest<FindCustomerByIdResponse>
    {
        public Guid Id { get; set; }
    }
}
