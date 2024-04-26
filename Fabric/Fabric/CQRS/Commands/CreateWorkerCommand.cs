using Fabric.Models;
using MediatR;

namespace Fabric.CQRS.Commands
{
    public class CreateWorkerCommand : IRequest<Worker>
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
