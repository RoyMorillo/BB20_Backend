using AutoMapper;
using BB20_InteriorCategories.Models;
using BB20_InteriorCategories.Models.DTOs;
using BB20_InteriorCategories.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BB20_InteriorCategories.Repository.Services;

public class InteriorCategoryRepository : IinteriorCategoryRepository
{
    private readonly BB20_InteriorCategoriesContext _context;
    private readonly IMapper _mapper;

    public InteriorCategoryRepository(BB20_InteriorCategoriesContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<InteriorCategoryDTO>> GetAll()
    {
        List<InteriorCategory> interiorCategories = await _context.InteriorCategories
                                            .Where(x => x.DeleteFlag == false)
                                            .Select(s => new InteriorCategory
                                            {
                                                InteriorCategoryId = s.InteriorCategoryId,
                                                SubCategoryId = s.SubCategoryId,
                                                CategoryId = s.CategoryId,
                                                Name = s.Name,
                                                DisplayStatus = s.DisplayStatus,
                                                Icon = s.Icon,
                                                CategoryLandPageDesc = s.CategoryLandPageDesc,
                                                CategoryLandPageHead = s.CategoryLandPageHead,
                                                SubCategoryLandPageDesc = s.SubCategoryLandPageDesc,
                                                IsActive = s.IsActive,
                                                Seotitle = s.Seotitle,
                                                SeoprettyUrl = s.SeoprettyUrl,
                                                SeodescMetadata = s.SeodescMetadata
                                            })
                                            .AsNoTracking()
                                            .ToListAsync();

        return _mapper.Map<List<InteriorCategoryDTO>>(interiorCategories);
    }

    public async Task<List<DropDownDTO>> GetAllForDropDown()
    {
        List<InteriorCategory> interiorCategories = await _context.InteriorCategories
                                    .Where(x => x.DeleteFlag == false)
                                    .Select(s => new InteriorCategory
                                    {
                                        InteriorCategoryId = s.InteriorCategoryId,
                                        Name = s.Name
                                    })
                                    .AsNoTracking()
                                    .ToListAsync();

        return _mapper.Map<List<DropDownDTO>>(interiorCategories);
    }

    public async Task<InteriorCategoryDTO> GetDataById(int interiorCategoryId)
    {
        InteriorCategory? interiorCategories = await _context.InteriorCategories
                                            .Where(x => x.DeleteFlag == false && x.InteriorCategoryId == interiorCategoryId)
                                            .Select(s => new InteriorCategory
                                            {
                                                InteriorCategoryId = s.InteriorCategoryId,
                                                SubCategoryId = s.SubCategoryId,
                                                CategoryId = s.CategoryId,
                                                Name = s.Name,
                                                DisplayStatus = s.DisplayStatus,
                                                Icon = s.Icon,
                                                CategoryLandPageDesc = s.CategoryLandPageDesc,
                                                CategoryLandPageHead = s.CategoryLandPageHead,
                                                SubCategoryLandPageDesc = s.SubCategoryLandPageDesc,
                                                IsActive = s.IsActive,
                                                Seotitle = s.Seotitle,
                                                SeoprettyUrl = s.SeoprettyUrl,
                                                SeodescMetadata = s.SeodescMetadata
                                            })
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync();

        return _mapper.Map<InteriorCategoryDTO>(interiorCategories);
    }

    public async Task<List<InteriorCategoryDTO>> GetDataBySubCategoryId(int subCategoryId)
    {
        List<InteriorCategory> interiorCategories = await _context.InteriorCategories
                                    .Where(x => x.DeleteFlag == false && x.SubCategoryId == subCategoryId)
                                    .Select(s => new InteriorCategory
                                    {
                                        InteriorCategoryId = s.InteriorCategoryId,
                                        SubCategoryId = s.SubCategoryId,
                                        CategoryId = s.CategoryId,
                                        Name = s.Name,
                                        DisplayStatus = s.DisplayStatus,
                                        Icon = s.Icon,
                                        CategoryLandPageDesc = s.CategoryLandPageDesc,
                                        CategoryLandPageHead = s.CategoryLandPageHead,
                                        SubCategoryLandPageDesc = s.SubCategoryLandPageDesc,
                                        IsActive = s.IsActive,
                                        Seotitle = s.Seotitle,
                                        SeoprettyUrl = s.SeoprettyUrl,
                                        SeodescMetadata = s.SeodescMetadata
                                    })
                                    .AsNoTracking()
                                    .ToListAsync();

        return _mapper.Map<List<InteriorCategoryDTO>>(interiorCategories);
    }
}
