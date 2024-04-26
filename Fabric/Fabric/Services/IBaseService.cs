using Fabric.Models;

namespace Fabric.Services;

public interface IBaseService<TEntity> where TEntity : BaseEntity
{
    IQueryable<TEntity> GetAll();
    Task<TEntity> GetById(Guid id);
    string Create(TEntity worker);
    string Update(Guid id, TEntity item);
    string Delete(Guid id);
}