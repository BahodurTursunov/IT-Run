using Fabric.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fabric.Infrastructure.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .ToTable("Products");
            builder
                .HasKey(x => x.Id);
            builder
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
            //builder
            //    .HasMany(p => p.Categories)
            //    .WithMany(p => p.Products);
        }
    }
}
