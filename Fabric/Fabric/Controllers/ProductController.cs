using Fabric.Infrastucture;
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
        private readonly FabricContext _fabricContext;

        public ProductController(IProductService service, FabricContext fabricContext)
        {
            _service = service;
            _fabricContext = fabricContext;
        }

        [HttpGet("AllItems")]
        public IEnumerable<Product> Get()
        {
            //return (IEnumerable<Product>)_service.GetAll();
            return _fabricContext.Products;
        }

        [HttpPost("Create")]
        public Product Post([FromBody] Product item)
        {
            //return _service.Create(item);
            _fabricContext.Products.Add(item);
            _fabricContext.SaveChanges();
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
