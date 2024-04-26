using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fabric.CQRS.Commands
{
    public class DeleteCustomerCommand : IRequest<string>
    {
        [FromQuery]
        public Guid Id { get; set; }
    }
}
