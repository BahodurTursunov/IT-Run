using FabricSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace FabricSystem.Infrastucture
{
    public class FabricContext : DbContext
    {
        public FabricContext(DbContextOptions<FabricContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Worker> Worker { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Customer> Customer { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product { ProductName = "Shampoo", ProductDescription = "Head and shoulders"}
            );
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Ignore<BaseEntity>();

        //    var product = new Product("HeadAndShoulders", "Шампунь", 200);

        //    modelBuilder.Entity<Product>(entity =>
        //    {
        //        entity.HasKey(p => p.Id);
        //    });
        //}
    }
}
