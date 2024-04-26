using Amazon.Runtime.Internal;
using Fabric.Models;
using MediatR;

namespace Fabric.CQRS.Queryes
{
    public class GetAllWorkerQuery : IRequest<List<Worker>>
    {
    }
}
