using System.Reflection;
using Fabric.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace Fabric.Infrastructure
{
    public class FabricContext : DbContext
    {
        public FabricContext(DbContextOptions<FabricContext> options) : base(options) { }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Worker> Worker { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<BaseEntity>();

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //modelBuilder.Entity<Order>()
            //    .HasOne(o => o.Orders)
            //    .WithMany(o => o.Product);
        }

    }
}
