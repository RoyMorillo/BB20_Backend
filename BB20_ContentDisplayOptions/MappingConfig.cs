using AutoMapper;
using BB20_ContentDisplayOptions.Models;
using BB20_ContentDisplayOptions.Models.DTOs;

namespace BB20_SubCategories;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<ContentDisplayOptionDTO, ContentDisplayOption>().ReverseMap();

            config.CreateMap<DisplayOptionCategoryDTO, DisplayOptionCategory>().ReverseMap();
        });
        return mappingConfig;
    }
}
