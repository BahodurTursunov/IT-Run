using FabricSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace FabricSystem.Infrastucture
{
    public class FabricContext : DbContext
    {
        public FabricContext(DbContextOptions<FabricContext> options) : base(options) { }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
        //public DbSet<Person> Person { get; set; }
        public DbSet<Worker> Worker { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<Department> Department { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<BaseEntity>();

            //modelBuilder.Entity<Customer>(entity =>
            //{
            //    entity.HasKey(c => c.Id);
            //    entity.Property(c => c.FullName).HasComputedColumnSql("CONCAT(FirstName, ' ', LastName");
            //    entity.ToTable("Customers");
            //});

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasData(new Customer()
                {
                    FirstName = "Bahodurkhon",
                    LastName = "Tursunov",
                    Birthday = new DateTimeOffset(2001, 2, 7, 0, 0, 0, TimeSpan.Zero),
                    Status = (CustomerStatus)1,
                });
                entity.ToTable("Customers");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.HasData(new Worker()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Role = "technician"
                });
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.HasData(new Product()
                {
                    ProductName = "MacBook Pro 16",
                    ProductDescription = "With thousands of apps optimized to unlock the full power of macOS and Apple silicon, M3 chips accelerate performance like never before. Now apps just soar — from your go-to productivity apps to your favorite games and hardest-working pro apps.",
                    Price = 1599,
                    CountOfProduct = 10
                });
            });
        }

    }
}
