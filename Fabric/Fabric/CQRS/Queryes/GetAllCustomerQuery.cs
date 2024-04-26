using Fabric.Models;
using MediatR;

namespace Fabric.CQRS.Queryes
{
    public class GetAllCustomerQuery : IRequest<List<Customer>>
    {
    }
}
