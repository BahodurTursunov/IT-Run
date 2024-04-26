
namespace Fabric.Models
{
    public class Product : BaseEntity
    {
        public string ProductName        { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price             { get; set; }
        public int CountOfProduct        { get; set; }
        //public List<Category> Categories { get; set; }
        //public List<Order> Orders        { get; set; }
    }   
}
