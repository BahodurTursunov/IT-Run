//using Fabric.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace Fabric.Infrastructure.Configurations
//{
//    public class OrderConfiguration : IEntityTypeConfiguration<Order>
//    {
//        public void Configure(EntityTypeBuilder<Order> builder)
//        {
//            builder
//                .ToTable("Orders");
//            builder
//                .HasKey(x => x.Id);

//            // Связь "один ко многим" между Order и Product
//            builder.HasMany(o => o.Product)   // У одного заказа может быть много товаров
//                   .WithOne(p => p.Order)      // Каждый товар принадлежит только одному заказу
//                   .HasForeignKey(p => p.OrderId); // Внешний ключ OrderId в таблице Product

//            // Связь "многие к одному" между Order и Customer
//            builder.HasOne(o => o.Customer)    // У каждого заказа есть только один покупатель
//                   .WithMany(c => c.Order)   // У одного покупателя может быть много заказов
//                   .HasForeignKey(o => o.CustomerId); // Внешний ключ CustomerId в таблице Order
//        }
//    }
//}
