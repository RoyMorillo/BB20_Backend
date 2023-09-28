using AutoMapper;
using BB20_SubCategories.Models;
using BB20_SubCategories.Models.DTOs;

namespace BB20_SubCategories;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<SubCategoryDTO, SubCategory>().ReverseMap();

            config.CreateMap<SubCategoryTreeDTO, SubCategory>().ReverseMap();

            config.CreateMap<SubCategory, DropDownDTO>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.SubCategoryId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        });
        return mappingConfig;
    }
}
