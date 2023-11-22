using AutoMapper;
using VillaProject_WebAPI.Models;
using VillaProject_WebAPI.Models.DTO;

namespace VillaProject_WebAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaCreateDTO>().ReverseMap(); //use .ReverseMap so we don't repeat second line
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
        }
    }
}
