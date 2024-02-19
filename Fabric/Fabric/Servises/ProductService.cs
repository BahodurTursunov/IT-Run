using FabricSystem.Models;
using FabricSystem.Repositories;

namespace FabricSystem.Servises
{
    public class ProductService : IProductService
    {
        ISQLRepository<Product> _repository;
        public ProductService(ISQLRepository<Product> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public Product GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Create(Product item)
        {
            item.Id = Guid.NewGuid();

            if (string.IsNullOrEmpty(item.ProductName))
            {
                return "The name cannot be empty";
            }
            else
            {
                _repository.Create(item);
                return $"Created new item with this ID: {item.Id}";
            }
        }

        public string Update(Guid id, Product item)
        {
            var _item = _repository.GetById(id);
            if (_item is not null)
            {
                _item.ProductName = item.ProductName;
                _item.ProductDescription = item.ProductDescription;
                _item.Price = item.Price;

                var result = _repository.Update(item);
                if (result)
                    return "Item updated";
            }
            return "Item not updated";
        }

        public string Delete(Guid id)
        {
            var _item = _repository.GetById(id);
            if (_item is null)
            {
                return "Item not found";
            }
            _repository.Delete(id);

            return "Item deleted";
        }
    }
}
