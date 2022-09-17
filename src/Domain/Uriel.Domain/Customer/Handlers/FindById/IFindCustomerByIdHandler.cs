using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uriel.Domain.Customer.Commands.Requests;
using Uriel.Domain.Customer.Commands.Responses;

namespace Uriel.Domain.Customer.Handlers.FindById
{
    public interface IFindCustomerByIdHandler
    {
        FindCustomerByIdResponse Handle(FindCustomerByIdRequest command);
    }
}
