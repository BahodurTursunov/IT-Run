using Fabric.Models;

namespace Fabric.Repositories
{
    public interface ISQLRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        Task<T> GetById(Guid id);
        bool Create(T item);
        bool Update(T item);
        bool Delete(Guid id);
    }
}
