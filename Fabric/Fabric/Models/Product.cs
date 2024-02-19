namespace FabricSystem.Models
{
    public class Product : BaseEntity, ICreatedIUpdatedAt
    {
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int CountOfProduct { get; set; } // тут количество продукта, которые есть в наличии

        //public Product(string productName, string productDescription, decimal price)
        //{
        //    ProductName = productName;
        //    ProductDescription = productDescription;
        //    Price = price;
        //    CreatedAt = DateTime.Now; // при создании объекта Product автоматически генерируется дата создания товара
        //}

        //public void ShowProductInfo(Product product)  // выводим на консоль данные нашего продукта при создании
        //{
        //    Console.WriteLine($"Name of product: {product.ProductName}\n" +
        //        $"Description of product: {product.ProductDescription}\n" +
        //        $"Product price: {product.Price}");
        //}

        //public void UpdateProduct(string newName, decimal newPrice)
        //{
        //    ProductName = newName;
        //    Price = newPrice;
        //    UpdatedAt = DateTime.UtcNow; // при обновлении объекта Product автоматически генерируется дата изменения товара
        //}
    }
}
