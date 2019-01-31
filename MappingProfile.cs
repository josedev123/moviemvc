using AutoMapper;
using moviemvc.Models;
using moviemvc.Dtos;

namespace moviemvc
{
public class MappingProfile : Profile {
    public MappingProfile() {

        // Domain to Dto
        CreateMap<Customer, CustomerDto>();
        CreateMap<Movie, MovieDto>();

        // Dto to Domain
        CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());

        CreateMap<MovieDto, Movie>().ForMember(c => c.Id, opt => opt.Ignore());

        }
}
}