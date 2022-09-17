using Uriel.Domain.Customer.Commands.Responses;
using Uriel.Domain.Customer.Commands.Requests;

namespace Uriel.Domain.Customer.Handlers
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest command);
    }
}
