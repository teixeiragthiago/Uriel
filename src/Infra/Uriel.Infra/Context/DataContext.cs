using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uriel.Domain.Customer.Entities;

namespace Uriel.Infra.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DbSet<CustomerEntity> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase(databaseName: "Uriel");
        }
    }
}
