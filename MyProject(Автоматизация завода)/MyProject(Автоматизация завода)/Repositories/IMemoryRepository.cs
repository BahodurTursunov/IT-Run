using MyProject.Models;

namespace MyProject.Repositories
{
    public interface IMemoryRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        bool Create(T customer);
        bool Update(T customer);
        bool Delete(Guid id);
    }
}
