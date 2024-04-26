using Fabric.Models;
using Fabric.Repositories;

namespace Fabric.Services;


public class CategorySevice : ICategoryService
{
    private readonly ISQLRepository<Category> _repository;
    public CategorySevice(ISQLRepository<Category> repository)
    {
        _repository = repository;
    }
    public IQueryable<Category> GetAll()
    {
        return _repository.GetAll();
    }
    public string Create(Category item)
    {
        item.Id = Guid.NewGuid();

        if (string.IsNullOrEmpty(item.CategoryName))
        {
            return "The name cannot be empty";
        }
        else
        {
            _repository.Create(item);
            return $"Created new item with this ID: {item.Id}";
        }
    }

    public string Update(Guid id, Category item)
    {
        var _item = _repository.GetById(id).GetAwaiter().GetResult();
        if (_item is not null)
        {
            _item.CategoryName = item.CategoryName;
            _item.CategoryDescription = item.CategoryDescription;

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
    Task<Category> IBaseService<Category>.GetById(Guid id)
    {
        return _repository.GetById(id);
    }
}
