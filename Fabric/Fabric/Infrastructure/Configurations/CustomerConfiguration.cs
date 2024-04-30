using Fabric.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Fabric.Infrastructure.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");


            builder.HasKey(x => x.Id);

            builder
                .Property(p => p.FirstName)
                .HasColumnType("NVARCHAR(30)");

            builder
               .Property(p => p.LastName)
               .HasColumnType("NVARCHAR(30)");

            builder
               .Property(p => p.Address)
               .HasColumnType("NVARCHAR(30)");

            builder
               .Property(p => p.Username)
               .HasColumnType("NVARCHAR(30)");

            builder
               .Property(p => p.Password)
               .HasColumnType("NVARCHAR(30)");

            builder
               .Property(p => p.RefreshToken)
               .HasColumnType("NVARCHAR(30)");

            builder
              .Property(p => p.Position)
              .HasColumnType("NVARCHAR(30)");
        }
    }
}
