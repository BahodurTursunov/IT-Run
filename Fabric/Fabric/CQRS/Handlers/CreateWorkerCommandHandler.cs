using AutoMapper;
using Fabric.CQRS.Commands;
using Fabric.Models;
using Fabric.Services;
using MediatR;

namespace Fabric.CQRS.Handlers
{
    public class CreateWorkerCommandHandler : IRequestHandler<CreateWorkerCommand, Worker>
    {
        private readonly IWorkerService _service;
        private readonly IMapper _mapper;

        public CreateWorkerCommandHandler(IWorkerService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Task<Worker> Handle(CreateWorkerCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<Worker>(request);
            _service.Create(user);
            return Task.FromResult(user);
        }
    }
}
