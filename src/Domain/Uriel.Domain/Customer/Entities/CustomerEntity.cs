using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uriel.Domain.Customer.Entities
{
    public class CustomerEntity
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }

        public CustomerEntity(string name, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
        }
    }
}
