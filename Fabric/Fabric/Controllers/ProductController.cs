using Fabric.Infrastructure;
using Fabric.Models;
using Fabric.Services;
using Microsoft.AspNetCore.Mvc;

namespace Fabric.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service, FabricContext fabricContext)
        {
            _service = service;
        }

        [HttpGet("AllItems")]
        public IQueryable<Product> Get()
        {
            return _service.GetAll();
        }

        [HttpPost("Create")]
        public Product Post([FromBody] Product item)
        {
            _service.Create(item);
            return item;
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
