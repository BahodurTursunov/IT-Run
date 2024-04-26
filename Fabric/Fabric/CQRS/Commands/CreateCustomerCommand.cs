using Fabric.Models;
using MediatR;

namespace Fabric.CQRS.Commands
{
    public class CreateCustomerCommand : Customer, IRequest<Customer>
    {
       
    }


}
