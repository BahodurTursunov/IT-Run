using Fabric.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fabric.Infrastructure.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                .ToTable("Orders");
            builder
                .HasKey(x => x.Id);
            
            //builder
            //    .HasMany(p => p.Products)
            //    .WithMany(p => p.Orders);

        }
    }
}
