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
            config.CreateMap<InteriorCategoryDTO, InteriorCategory>()
                .ForMember(dest => dest.InteriorCategoryId, opt => opt.MapFrom(src => src.InteriorCategoryId))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.SubCategoryId, opt => opt.MapFrom(src => src.SubCategoryId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.DisplayStatus, opt => opt.MapFrom(src => src.DisplayStatus))
                .ForMember(dest => dest.Icon, opt => opt.MapFrom(src => src.Icon))
                .ForMember(dest => dest.CategoryLandPageDesc, opt => opt.MapFrom(src => src.CategoryLandPageDesc))
                .ForMember(dest => dest.CategoryLandPageHead, opt => opt.MapFrom(src => src.CategoryLandPageHead))
                .ForMember(dest => dest.SubCategoryLandPageDesc, opt => opt.MapFrom(src => src.SubCategoryLandPageDesc))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.Seotitle, opt => opt.MapFrom(src => src.Seotitle))
                .ForMember(dest => dest.SeoprettyUrl, opt => opt.MapFrom(src => src.SeoprettyUrl))
                .ForMember(dest => dest.SeodescMetadata, opt => opt.MapFrom(src => src.SeodescMetadata))
                .ReverseMap();

            config.CreateMap<InteriorCategory, DropDownDTO>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        });
        return mappingConfig;
    }
}
