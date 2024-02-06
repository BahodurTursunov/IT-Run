using Fabric.Models;
using Fabric.Repositories;

namespace Fabric.Servises
{

    /// <summary>
    /// Клиенты
    /// </summary>
    public class CustomerService : ICustomerService
    {
        IMemoryRepository<Customer> _repository;
        public CustomerService(IMemoryRepository<Customer> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _repository.GetAll();
        }

        public Customer GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Create(Customer item)
        {
            item.Id = Guid.NewGuid();
            if (string.IsNullOrEmpty(item.FirstName))
            {
                return "The name cannot be empty";
            }
            else
            {
                _repository.Create(item);
                return $"Created new item with this ID: {item.Id}";
            }
        }

        public string Update(Guid id, Customer item)
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
