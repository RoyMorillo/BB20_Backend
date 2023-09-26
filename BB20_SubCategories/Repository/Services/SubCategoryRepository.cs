using AutoMapper;
using BB20_SubCategories.Models;
using BB20_SubCategories.Models.DTOs;
using BB20_SubCategories.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BB20_SubCategories.Repository.Services;

public class SubCategoryRepository : ISubCategoryRepository
{
    private readonly BB20_SubCategoriesContext _context;
    private readonly IMapper _mapper;

    public SubCategoryRepository(BB20_SubCategoriesContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<SubCategoryDTO>> GetAll()
    {
        List<SubCategory> subCategories = await _context.SubCategories
                                            .Where(x => x.DeleteFlag == false)
                                            .Include(x => x.SubCategoryThumbNails)
                                            .Select(s => new SubCategory
                                            {
                                                SubCategoryId = s.SubCategoryId,
                                                CategoryId = s.CategoryId,
                                                Name = s.Name,
                                                DisplayStatus = s.DisplayStatus,
                                                FtinHeaderAndFooter = s.FtinHeaderAndFooter,
                                                FtinBannerIcon = s.FtinBannerIcon,
                                                FtinTitle = s.FtinTitle,
                                                Icon = s.Icon,
                                                UseExternalUrl = s.UseExternalUrl,
                                                CategoryLandPageDesc = s.CategoryLandPageDesc,
                                                CategoryLandPageHead = s.CategoryLandPageHead,
                                                SubCategoryLandPageDesc = s.SubCategoryLandPageDesc,
                                                IsActive = s.IsActive,
                                                Static = s.Static,
                                                Seotitle = s.Seotitle,
                                                SeoprettyUrl = s.SeoprettyUrl,
                                                SeodescMetadata = s.SeodescMetadata
                                            })
                                            .AsNoTracking()
                                            .ToListAsync();

        return _mapper.Map<List<SubCategoryDTO>>(subCategories);
    }

    public async Task<List<DropDownDTO>> GetAllForDropDown()
    {
        List<SubCategory> subCategories = await _context.SubCategories
                                    .Where(x => x.DeleteFlag == false)
                                    .Select(s => new SubCategory
                                    {
                                        SubCategoryId = s.SubCategoryId,
                                        Name = s.Name
                                    })
                                    .AsNoTracking()
                                    .ToListAsync();

        return _mapper.Map<List<DropDownDTO>>(subCategories);
    }

    public Task<List<SubCategoryDTO>> GetAllTree()
    {
        throw new NotImplementedException();
    }

    public async Task<SubCategoryDTO> GetDataById(int subCategoryId)
    {
        SubCategory? subCategories = await _context.SubCategories
                                            .Where(x => x.DeleteFlag == false && x.SubCategoryId == subCategoryId)
                                            .Include(x => x.SubCategoryThumbNails)
                                            .Select(s => new SubCategory
                                            {
                                                SubCategoryId = s.SubCategoryId,
                                                CategoryId = s.CategoryId,
                                                Name = s.Name,
                                                DisplayStatus = s.DisplayStatus,
                                                FtinHeaderAndFooter = s.FtinHeaderAndFooter,
                                                FtinBannerIcon = s.FtinBannerIcon,
                                                FtinTitle = s.FtinTitle,
                                                Icon = s.Icon,
                                                UseExternalUrl = s.UseExternalUrl,
                                                CategoryLandPageDesc = s.CategoryLandPageDesc,
                                                CategoryLandPageHead = s.CategoryLandPageHead,
                                                SubCategoryLandPageDesc = s.SubCategoryLandPageDesc,
                                                IsActive = s.IsActive,
                                                Static = s.Static,
                                                Seotitle = s.Seotitle,
                                                SeoprettyUrl = s.SeoprettyUrl,
                                                SeodescMetadata = s.SeodescMetadata
                                            })
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync();

        return _mapper.Map<SubCategoryDTO>(subCategories);
    }
}
