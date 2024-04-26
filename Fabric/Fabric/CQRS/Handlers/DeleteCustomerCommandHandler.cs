using AutoMapper;
using Fabric.CQRS.Commands;
using Fabric.Services;
using MediatR;

namespace Fabric.CQRS.Handlers
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, string>
    {
        private readonly ICustomerService _service;
        private readonly IMapper _mapper;

        public DeleteCustomerCommandHandler(ICustomerService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;   
        }

        public Task<string> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken) {
            var result = _service.Delete(request.Id);
            return Task.FromResult(result);
        }
    }
}
