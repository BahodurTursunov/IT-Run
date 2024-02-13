using Fabric.Models;
using Microsoft.EntityFrameworkCore;

namespace Fabric.Infrastucture
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

    }
}
