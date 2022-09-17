using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Uriel.Domain.Customer.Commands.Requests;
using Uriel.Domain.Customer.Commands.Responses;
using Uriel.Domain.Customer.Entities;

namespace Uriel.Domain.Customer.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        private readonly ICustomerRepository _customerRepository;

        public CreateCustomerHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var customerEntity = new CustomerEntity(request.Name, request.Email);

            _customerRepository.Save(customerEntity);

            var result = new CreateCustomerResponse
            {
                Id = customerEntity.Id,
                Name = customerEntity.Name,
                Email = customerEntity.Email,
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
