using MyProject.Models;

namespace MyProject.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();

        /// <summary>
        /// This is for getting item by Id
        /// </summary>
        /// <param name="id">Id of item</param>
        /// <returns>returns item if found otherwase null</returns>
        Product GetById(Guid id);
        string Create(Product product);
        string Update(Guid id, Product item);
        string Delete(Guid id);
    }
}
