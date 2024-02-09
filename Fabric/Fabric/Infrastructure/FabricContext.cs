using Microsoft.EntityFrameworkCore;

namespace Fabric.FabricContext
{
    public class FabricContext : DbContext
    {
        public static string ConnectionString = "Persist Security Info=False;Trusted_Connection=True;database=AdventureWorks;server=(local)";


        public FabricContext(DbContextOptions<FabricContext> options) : base(options)
        {
            Database.EnsureCreated();
        }


    }
}
