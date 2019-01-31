using AutoMapper;
using moviemvc.Models;
using moviemvc.Dtos;

namespace moviemvc
{
public class MappingProfile : Profile {
    public MappingProfile() {
        // Add as many of these lines as you need to map your objects
        CreateMap<Customer, CustomerDto>();
        CreateMap<CustomerDto, Customer>();
    }
}
}