using Fabric.Models;
using Fabric.Servises;
using Microsoft.AspNetCore.Mvc;

namespace Fabric.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpGet("AllItems")]
        public IEnumerable<Customer> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("Create")]
        public string Post([FromBody] Customer customer)
        {
            return _service.Create(customer);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] Customer customer)
        {
            return _service.Update(id, customer);
        }

        [HttpDelete("Delete")]
        public string Delete([FromQuery] Guid id)
        {
            return _service.Delete(id);
        }
    }
}
