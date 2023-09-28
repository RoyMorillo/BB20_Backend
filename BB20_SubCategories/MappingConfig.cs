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

            config.CreateMap<SubCategoryTreeDTO, SubCategory>()
                .ForMember(dest => dest.SubCategoryId, opt => opt.MapFrom(src => src.SubCategoryId))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.DisplayStatus, opt => opt.MapFrom(src => src.DisplayStatus))
                .ForMember(dest => dest.FtinHeaderAndFooter, opt => opt.MapFrom(src => src.FtinHeaderAndFooter))
                .ForMember(dest => dest.FtinBannerIcon, opt => opt.MapFrom(src => src.FtinBannerIcon))
                .ForMember(dest => dest.FtinTitle, opt => opt.MapFrom(src => src.FtinTitle))
                .ForMember(dest => dest.Icon, opt => opt.MapFrom(src => src.Icon))
                .ForMember(dest => dest.UseExternalUrl, opt => opt.MapFrom(src => src.UseExternalUrl))
                .ForMember(dest => dest.CategoryLandPageDesc, opt => opt.MapFrom(src => src.CategoryLandPageDesc))
                .ForMember(dest => dest.CategoryLandPageHead, opt => opt.MapFrom(src => src.CategoryLandPageHead))
                .ForMember(dest => dest.SubCategoryLandPageDesc, opt => opt.MapFrom(src => src.SubCategoryLandPageDesc))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.Static, opt => opt.MapFrom(src => src.Static))
                .ForMember(dest => dest.Seotitle, opt => opt.MapFrom(src => src.Seotitle))
                .ForMember(dest => dest.SeoprettyUrl, opt => opt.MapFrom(src => src.SeoprettyUrl))
                .ForMember(dest => dest.SeodescMetadata, opt => opt.MapFrom(src => src.SeodescMetadata))
                .ReverseMap();

            config.CreateMap<SubCategory, DropDownDTO>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.SubCategoryId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        });
        return mappingConfig;
    }
}
