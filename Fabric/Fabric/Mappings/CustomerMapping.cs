using AutoMapper;
using Fabric.CQRS.Commands;
using Fabric.Models;

namespace Fabric.Mappings
{
    public class CustomerMapping : Profile
    {
        public CustomerMapping()
        {
            CreateMap<CreateCustomerCommand, Customer>();
            CreateMap<UpdateCustomerCommand, Customer>();
        }
    }
}
