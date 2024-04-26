using System.Text.Json.Serialization;
using Fabric.Models;
using MediatR;

namespace Fabric.CQRS.Commands
{
    public class UpdateCustomerCommand : Customer, IRequest<string>
    {

        [JsonIgnore]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

