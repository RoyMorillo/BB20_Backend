using AutoMapper;
using BB20_ContentAudios.Models;
using BB20_ContentAudios.Models.DTOs;

namespace BB20_Categories;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<ContentAudioDTO, ContentAudio>().ReverseMap();
        });
        return mappingConfig;
    }
}
