using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uriel.Domain.Customer.Entities;

namespace Uriel.Domain.Customer
{
    public interface ICustomerRepository
    {
        Guid Save(CustomerEntity customer);
        CustomerEntity FindById(Guid id);
    }
}
