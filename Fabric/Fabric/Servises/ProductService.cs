using Fabric.Models;
using Fabric.Repositories;

namespace Fabric.Servises
{
    public class ProductService : IProductService
    {
        IMemoryRepository<Product> _repository;
        public ProductService(IMemoryRepository<Product> repository)
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
            if (_item is null)
            {
                return "Item not found";
            }
            _repository.Update(_item);
            return "Item updated";
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
