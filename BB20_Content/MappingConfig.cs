using AutoMapper;
using BB20_Content.Models;
using BB20_Content.Models.DTOs;

namespace BB20_Categories;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<ContentDTO, Content>().ReverseMap();

            config.CreateMap<Content, DropDownDTO>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.ContentId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Title));
        });
        return mappingConfig;
    }
}
