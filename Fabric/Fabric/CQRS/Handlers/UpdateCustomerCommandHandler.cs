using AutoMapper;
using Fabric.CQRS.Commands;
using Fabric.Models;
using Fabric.Services;
using MediatR;

namespace Fabric.CQRS.Handlers
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, string>
    {
        private ICustomerService _service;
        private readonly IMapper _mapper;

        public UpdateCustomerCommandHandler(ICustomerService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Task<string> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var client = _mapper.Map<Customer>(request);
            var result = _service.Update(request.Id, client);

            return Task.FromResult(result);
        }
    }
}
