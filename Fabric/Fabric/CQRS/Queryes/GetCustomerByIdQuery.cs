using Fabric.Models;
using MediatR;

namespace Fabric.CQRS.Queryes
{
    public class GetCustomerByIdQuery : IRequest<Customer>
    {
        public Guid Id { get; set; }
    }
}
