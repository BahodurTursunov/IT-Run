using FabricSystem.Infrastucture;
using FabricSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
namespace FabricSystem.Repositories
{
    public class SQLRepository<T> : ISQLRepository<T> where T : BaseEntity
    {
        readonly FabricContext _fabricContext;

        public SQLRepository(FabricContext fabricContext)
        {
            _fabricContext = fabricContext;
        }

        public IQueryable<T> GetAll()
        {
            return _fabricContext.Set<T>();
        }

        public T GetById(Guid id)
        {
            return _fabricContext.Set<T>().SingleOrDefault(w => w.Id == id);
        }

        public bool Create(T item)
        {
            try
            {
                _fabricContext.Add(item);
                var result = _fabricContext.SaveChanges();
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(T item)
        {
            try
            {
                _fabricContext.Update(item);
                var result = _fabricContext.SaveChanges();
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                var item = _fabricContext.Set<T>().SingleOrDefault(w => w.Id == id);
                if (item is not null)
                {
                    _fabricContext.Remove(item);
                    var result = _fabricContext.SaveChanges();
                    return result > 0;
                }
            }
            catch
            { }
            return false;
        }
    }
}
