using System.Reflection;
using EfCoreExample.Application.Entities;
using EfCoreExample.Infrastructure.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace EfCoreExample.Infrastructure.Persistence
{
    public class ApplicationDbContextCodeFirst : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContextCodeFirst(DbContextOptions<ApplicationDbContextCodeFirst> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.SetSingularizedTableNames();

            base.OnModelCreating(modelBuilder);
        }
    }
}
