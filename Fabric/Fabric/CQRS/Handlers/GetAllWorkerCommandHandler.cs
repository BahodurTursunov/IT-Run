using AutoMapper;
using Fabric.CQRS.Queryes;
using Fabric.Models;
using Fabric.Services;
using MediatR;

namespace Fabric.CQRS.Handlers
{
    public class GetAllWorkerCommandHandler : IRequestHandler<GetAllWorkerQuery, List<Worker>>
    {
        private readonly IWorkerService _service;
        private readonly IMapper _mapper;

        public GetAllWorkerCommandHandler(IWorkerService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<List<Worker>> Handle(GetAllWorkerQuery request, CancellationToken cancellationToken)
        {
            var worker = _service.GetAll().ToList();
            return await Task.FromResult(worker);
        }
    }
}
