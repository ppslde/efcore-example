using System.Reflection;
using EfCoreExample.Application.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCoreExample.Infrastructure.Persistence
{
    public class ApplicationDbContextDbFirst : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContextDbFirst(DbContextOptions<ApplicationDbContextDbFirst> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
