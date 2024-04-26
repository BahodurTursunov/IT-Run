using System.ComponentModel.DataAnnotations;

namespace Fabric.Models
{
    public class Order : BaseEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchareDate { get; set; }
        public Guid ProductId { get; set; }
        public Guid CustomerId { get; set; } // внешний ключ
        //public Customer Customers { get; set; } // навигационное свойство
        //public List<Product> Products { get; set; }
    }
}
