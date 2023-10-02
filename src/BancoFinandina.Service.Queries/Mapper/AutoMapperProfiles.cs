using AutoMapper;
using BancoFinandina.Domain;
using BancoFinandina.Service.Queries.DTOs;

namespace BancoFinandina.Service.Queries.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
