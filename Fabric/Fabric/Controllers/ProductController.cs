using Fabric.Models;
using Fabric.Servises;
using Microsoft.AspNetCore.Mvc;

namespace Fabric.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        readonly IProductService _service;

        public ProductController(IProductService customerService)
        {
            _service = customerService;
        }

        [HttpGet("AllItems")]
        public IEnumerable<Product> Get()
        {
            return (IEnumerable<Product>)_service.GetAll();
        }

        [HttpPost("Create")]
        public string Post([FromBody] Product item)
        {
            return _service.Create(item);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] Product item)
        {
            return _service.Update(id, item);
        }

        [HttpDelete("Delete")]
        public string Delete([FromQuery] Guid id)
        {
            return _service.Delete(id);
        }
    }
}
