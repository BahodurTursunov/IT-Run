using AutoMapper;
using Fabric.CQRS.Queryes;
using Fabric.Models;
using Fabric.Services;
using MediatR;

namespace Fabric.CQRS.Handlers
{
    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomerQuery, List<Customer>>
    {
        private readonly ICustomerService _service;
        private readonly IMapper _mapper;

        public GetAllCustomersQueryHandler(ICustomerService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<List<Customer>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
        {
            var customer = _service.GetAll().ToList();
            return await Task.FromResult(customer);
        }
    }
}
