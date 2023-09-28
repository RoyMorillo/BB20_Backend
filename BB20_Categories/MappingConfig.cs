using AutoMapper;
using BB20_Categories.Models;
using BB20_Categories.Models.DTOs;

namespace BB20_Categories;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<CategoryDTO, Category>().ReverseMap();

            config.CreateMap<CategoryTreeDTO, Category>().ReverseMap();

            config.CreateMap<Category, DropDownDTO>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        });
        return mappingConfig;
    }
}
