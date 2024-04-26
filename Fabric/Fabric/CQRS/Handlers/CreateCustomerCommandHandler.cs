using AutoMapper;
using Fabric.CQRS.Commands;
using Fabric.Models;
using Fabric.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Fabric.CQRS.Handlers
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Customer>
    {
        private readonly ICustomerService _service;
        private readonly IMapper _mapper;

        public CreateCustomerCommandHandler(ICustomerService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Task<Customer> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<Customer>(request);
            _service.Create(user);
            return Task.FromResult(user);
        }
    }
}
