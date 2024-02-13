using FabricSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace FabricSystem.Infrastucture
{
    public class FabricContext : DbContext
    {
        public FabricContext(DbContextOptions<FabricContext> options) : base(options)
        {
           
        }

        public DbSet<Worker> Workers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<BaseEntity>();

            var product = new Product("HeadAndShoulders", "Шампунь", 200);

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.HasData(bank);
            });
        }
    }
}
