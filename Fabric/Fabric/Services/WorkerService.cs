using Fabric.Models;
using Fabric.Repositories;

namespace Fabric.Services
{
    public class WorkerService : IWorkerService
    {
        ISQLRepository<Worker> _repository;

        public WorkerService(ISQLRepository<Worker> repository)
        {
            _repository = repository;
        }

        public string Create(Worker worker)
        {
            worker.Id = Guid.NewGuid();
            if (!string.IsNullOrEmpty(worker.FirstName))
            {
                _repository.Create(worker);
                return $"Created new worker with ID -> {worker.Id}";
            }
            else
                return "Name can not be empty";
        }

        public string Delete(Guid id)
        {
            var result = _repository.Delete(id);
            if (result)
                return "Item Deleted";
            else
                return "Item not found";
        }

        public IQueryable<Worker> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<Worker> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public string Update(Guid id, Worker item)
        {
            var _item = _repository.GetById(id).GetAwaiter().GetResult();
            if (_item is not null)
            {
                _item.FirstName = item.FirstName;
                _item.LastName = item.LastName;
                _item.Role = item.Role;
                _item.Respontibility = item.Respontibility;
                _item.Birthday = item.Birthday;
                _item.Username = item.Username;
                _item.Password = item.Password;

                var result = _repository.Update(item);
                if (result)
                    return "Item updated";
            }
            return "Item not updated";
        }
    }
}
