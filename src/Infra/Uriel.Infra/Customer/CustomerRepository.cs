using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uriel.Domain.Customer;
using Uriel.Domain.Customer.Entities;
using Uriel.Infra.Context;

namespace Uriel.Infra.Customer
{
    public class CustomerRepository : ICustomerRepository
    {

        public Guid Save(CustomerEntity customer)
        {
            using (var context = new DataContext())
            {
                context.Customer.Add(customer);
                context.SaveChanges();

                return customer.Id;
            }
        }

        public CustomerEntity FindById(Guid id)
        {
            using (var context = new DataContext())
                return context.Customer.FirstOrDefault(x => x.Id == id);
        }
    }
}
