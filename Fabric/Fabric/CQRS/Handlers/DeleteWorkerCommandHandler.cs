using AutoMapper;
using Fabric.CQRS.Commands;
using Fabric.Services;
using MediatR;

namespace Fabric.CQRS.Handlers
{
    public class DeleteWorkerCommandHandler : IRequestHandler<DeleteWorkerCommand, string>
    {
        private IWorkerService _service;
        private readonly IMapper _mapper;

        public DeleteWorkerCommandHandler(IWorkerService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Task<string> Handle(DeleteWorkerCommand request, CancellationToken cancellationToken)
        {
            var result = _service.Delete(request.Id);
            return Task.FromResult(result);
        }
    }
}
