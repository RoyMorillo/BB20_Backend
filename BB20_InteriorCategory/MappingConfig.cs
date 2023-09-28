using AutoMapper;
using BB20_InteriorCategories.Models;
using BB20_InteriorCategories.Models.DTOs;

namespace BB20_Categories;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<InteriorCategoryDTO, InteriorCategory>().ReverseMap();

            config.CreateMap<InteriorCategory, DropDownDTO>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        });
        return mappingConfig;
    }
}
