using Fabric.CQRS.Commands;
using Fabric.Infrastructure;
using Fabric.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fabric.Controllers
{
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly FabricContext _context;
        public CategoryController(ILogger<CategoryController> logger, FabricContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("AllCategories")]
        public ActionResult<IEnumerable<Category>> AllCategory(CancellationToken cancellationToken) {
            return Ok(_context.Categories);
        }

        [HttpGet("GetCategoryById")]
        [Authorize(Roles = "editor")]
        public ActionResult<Category> Get(Guid guid)
        {
            return Ok(_context.Categories.FirstOrDefault(b=>b.Id== guid));
        }
    }
}
