using Fabric.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fabric.CQRS.Commands
{
    public class DeleteWorkerCommand : IRequest<string>
    {
        [FromQuery]
        public Guid Id { get; set; }
    }
}
