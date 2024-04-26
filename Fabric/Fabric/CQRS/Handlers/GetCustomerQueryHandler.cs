using AutoMapper;
using Fabric.CQRS.Queryes;
using Fabric.Models;
using Fabric.Services;
using MediatR;

namespace Fabric.CQRS.Handlers
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerByIdQuery, Customer>
    {
        private readonly ICustomerService _service;
        private readonly IMapper _mapper;

        public GetCustomerQueryHandler(ICustomerService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var client = await _service.GetById(request.Id);
            return client;
        }
    }
}
