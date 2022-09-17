using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uriel.Domain.Customer.Commands.Requests;
using Uriel.Domain.Customer.Commands.Responses;

namespace Uriel.Domain.Customer.Handlers.FindById
{
    public class FindCustomerByIdHandler : IFindCustomerByIdHandler
    {
        private readonly ICustomerRepository _customerRepository;

        public FindCustomerByIdHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public FindCustomerByIdResponse Handle(FindCustomerByIdRequest command)
        {
            var customerEntity = _customerRepository.FindById(command.Id);
            if (customerEntity == null)
                return null;

            var response = new FindCustomerByIdResponse
            {
                Id = customerEntity.Id,
                Name = customerEntity.Name,
                Email = customerEntity.Email
            };

            return response;
        }
    }
}
