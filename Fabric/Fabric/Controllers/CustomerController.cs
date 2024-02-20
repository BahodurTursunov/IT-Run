using FabricSystem.Infrastucture;
using FabricSystem.Models;
using FabricSystem.Servises;
using Microsoft.AspNetCore.Mvc;

namespace FabricSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        readonly ICustomerService _service;
        private readonly FabricContext _fabricContext;


        public CustomerController(ICustomerService service, FabricContext fabricContext)
        {
            _service = service;
            _fabricContext = fabricContext;
        }

        [HttpGet("AllItems")]
        public IQueryable<Customer> Get()
        {
            return _fabricContext.Customer;
        }

        [HttpGet("GetItemById")]
        public Customer Get(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Create")]
        public Customer Post([FromBody] Customer item)
        {
            _service.Create(item);
            _fabricContext.Add(item);
            _fabricContext.SaveChanges();
            return item;
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] Customer item)
        {
            return _service.Update(id, item);
        }

        [HttpDelete("Delete")]
        public IActionResult Delete([FromQuery] Guid id)
        {
            var existingItem = _service.GetById(id);
            if (existingItem == null) 
                return NotFound();
            //_fabricContext.Delete(id);

            return NoContent();
        }
    }
}
