using System.Reflection;
using Fabric.Models;
using Microsoft.EntityFrameworkCore;

namespace Fabric.Infrastructure
{
    public class FabricContext : DbContext
    {
        public FabricContext(DbContextOptions<FabricContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Worker> Workers { get; set; }

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
