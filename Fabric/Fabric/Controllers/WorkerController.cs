using Fabric.CQRS.Commands;
using Fabric.CQRS.Queryes;
using Fabric.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fabric.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WorkerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Create")]
        public async Task<ActionResult<Worker>> CreateWorker(CreateWorkerCommand command)
        {
            var worker = await _mediator.Send(command);
            return Ok(worker);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Worker>> GetWorkerById(Guid id)
        {
            var query = new GetWorkerByIdQuery() { Id = id };
            var worker = await _mediator.Send(query);
            if (worker == null)
                return NotFound();
            return Ok(worker);
        }

        [HttpGet("AllWorkers")]
        public async Task<ActionResult<Worker>> GetAllWorker()
        {
            var query = new GetAllWorkerQuery();
            var worker = await _mediator.Send(query);
            return Ok(worker);
        }


        [HttpPut("update")]
        public async Task<ActionResult<Worker>> UpdateWorker(Guid id, UpdateWorkerCommand command)
        {
            command.Id = id;
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteWorker(DeleteWorkerCommand deleteWorker)
        {
            var result = await _mediator.Send(deleteWorker);
            return Ok(result);
        }
    }
}
