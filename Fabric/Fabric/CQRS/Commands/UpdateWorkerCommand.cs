using System.Text.Json.Serialization;
using MediatR;

namespace Fabric.CQRS.Commands
{
    public class UpdateWorkerCommand : IRequest<string>
    {

        [JsonIgnore]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
