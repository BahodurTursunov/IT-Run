using Fabric.Models;

namespace Fabric.Servises
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();

        Customer GetById(Guid id);

        string Create(Customer customer);

        string Update(Guid id, Customer item);

        string Delete(Guid id);
    }
}
