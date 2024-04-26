using Fabric.Models;
using MediatR;

namespace Fabric.CQRS.Queryes
{
    public class GetWorkerByIdQuery : IRequest<Worker>
    {
        public Guid Id { get; set; }
    }
}
