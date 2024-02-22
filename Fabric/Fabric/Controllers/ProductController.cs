using FabricSystem.Infrastucture;
using FabricSystem.Models;
using FabricSystem.Servises;
using Microsoft.AspNetCore.Mvc;

namespace FabricSystem.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        private readonly FabricContext _fabricContext;

        public ProductController(IProductService service, FabricContext fabricContext)
        {
            _service = service;
            _fabricContext = fabricContext;
        }

        [HttpGet("AllItems")]
        public IQueryable<Product> Get()
        {
            return _service.GetAll();
            //return _fabricContext.Product;
        }

        [HttpPost("Create")]
        public Product Post([FromBody] Product item)
        {
            _service.Create(item);
            //_fabricContext.Add(item);
            //_fabricContext.SaveChanges();
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
