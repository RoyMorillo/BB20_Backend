using AutoMapper;
using BB20_ContentVideos.Models;
using BB20_ContentVideos.Models.DTOs;

namespace BB20_Categories;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<ContentVideoDTO, ContentVideo>().ReverseMap();
        });
        return mappingConfig;
    }
}
