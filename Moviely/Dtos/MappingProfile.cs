using AutoMapper;
using Moviely.Models;
using Moviely.Dtos;

namespace Moviely.Dtos
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}
