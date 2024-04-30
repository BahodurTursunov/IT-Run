using System.ComponentModel.DataAnnotations.Schema;

namespace Fabric.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }

        //public List<Product> Products { get; set; }
    }
}
