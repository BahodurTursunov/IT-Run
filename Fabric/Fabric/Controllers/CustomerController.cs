using System.Text.Json.Serialization;
using Fabric.Models;
using Fabric.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using MediatR;
using Fabric.CQRS.Commands;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Fabric.CQRS.Queryes;
using Microsoft.Extensions.Logging.Abstractions;

namespace Fabric.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Create")]
        public async Task<ActionResult<Customer>> CreateCustomer(CreateCustomerCommand command)
        {
            var user = await _mediator.Send(command);
            return Ok(user);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomerById(Guid id)
        {
            var query = new GetCustomerByIdQuery() { Id = id };
            var customer = await _mediator.Send(query);
            if (customer == null)
                return NotFound();
            return Ok(customer);
        }

        [HttpGet("AllCustomers")]
        public async Task<ActionResult<Customer>> GetAllCustomers()
        {
            var query = new GetAllCustomerQuery();
            var customers = await _mediator.Send(query);
            return Ok(customers);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Customer>> UpdateCustomer(Guid id, UpdateCustomerCommand command)
        {
            command.Id = id;
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteCustomer(DeleteCustomerCommand deleteCustomer)
        {
            var result = await _mediator.Send(deleteCustomer);
            return Ok(result);
        }
    }
}
