namespace FabricSystem.Models
{
    public class Category : BaseEntity
    {
        List<Product> products = new();

        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public Category(string categoryName, string categoryDescription)
        {
            CategoryName = categoryName;
            CategoryDescription = categoryDescription;

            Console.WriteLine($"Category Name: {categoryName}, Category Description: {categoryDescription}");
        }

    }
}
