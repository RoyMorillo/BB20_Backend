using AutoMapper;
using BB20_ContentFiles.Models;
using BB20_ContentFiles.Models.DTOs;

namespace BB20_Categories;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<ContentFileDTO, ContentFile>().ReverseMap();
        });
        return mappingConfig;
    }
}
