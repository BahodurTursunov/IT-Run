using AutoMapper;
using Fabric.CQRS.Commands;
using Fabric.Models;
using Fabric.Services;
using MediatR;

namespace Fabric.CQRS.Handlers
{
    public class UpdateWorkerCommandHandler : IRequestHandler<UpdateWorkerCommand, string>
    {
        private IWorkerService _service;
        private readonly IMapper _mapper;

        public UpdateWorkerCommandHandler(IWorkerService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Task<string> Handle(UpdateWorkerCommand request, CancellationToken cancellationToken)
        {
            var client = _mapper.Map<Worker>(request);
            var result = _service.Update(request.Id, client);

            return Task.FromResult(result);
        }
    }
}
