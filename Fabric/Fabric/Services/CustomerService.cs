﻿using Fabric.Models;
using Fabric.Repositories;

namespace Fabric.Services
{
    public class CustomerService : ICustomerService
    {
        ISQLRepository<Customer> _repository;
        public CustomerService(ISQLRepository<Customer> repository)
        {
            _repository = repository;
        }
        public IQueryable<Customer> GetAll()
        {
            return _repository.GetAll();
        }
        public async Task<Customer> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }
        public string Create(Customer item)
        {
            item.Id = Guid.NewGuid();
            if (string.IsNullOrEmpty(item.FirstName))
                return "The name cannot be empty";
            else
            {
                _repository.Create(item);
                return $"Created new item with this ID: {item.Id}";
            }
        }
        public string Update(Guid id, Customer item)
        {
            var _item = _repository.GetById(id).GetAwaiter().GetResult();
            if (_item is not null)
            {
                _item.FirstName = item.FirstName;
                _item.LastName = item.LastName;
                _item.Status = item.Status;
                _item.Birthday = item.Birthday;
                _item.Username= item.Username;
                _item.Password= item.Password;

                var result = _repository.Update(item);
                if (result) 
                    return "Item updated";
            }
            return "Item not updated";
        }
        public string Delete(Guid id)
        {
            var result = _repository.Delete(id);
            if (result)
                return "Item deleted";
            else
                return "Item not found";
        }
    }
}
