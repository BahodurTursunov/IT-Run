using Microsoft.AspNetCore.Mvc;
using MyProject.DataBase;
using MyProject.Models;
using MyProject.Services;

namespace MyProject.Controllers
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

        [HttpGet("Create")]
        public string Post([FromBody] Product product)
        {
            return _service.Create(product);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] Product product)
        {
            return _service.Update(id, product);
        }

        [HttpDelete("Delete")]
        public string Delete([FromQuery] Guid id)
        {
            return _service.Delete(id);
        }
    }
}

