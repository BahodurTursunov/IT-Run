﻿using FabricSystem.Models;

namespace FabricSystem.Servises
{
    public interface ICustomerService
    {
        IQueryable<Customer> GetAll();

        Customer GetById(Guid id);

        string Create(Customer item);

        string Update(Guid id, Customer item);

        string Delete(Guid id);
    }
}
