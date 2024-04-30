using System.ComponentModel.DataAnnotations;

namespace Fabric.Models
{
    public class Order : BaseEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchareDate { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public Guid ProductId { get; set; }
        public Guid CustomerId { get; set; } 
    }
}
