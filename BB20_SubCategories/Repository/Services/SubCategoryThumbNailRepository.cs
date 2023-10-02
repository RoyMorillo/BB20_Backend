using AutoMapper;
using BB20_SubCategories.Models;
using BB20_SubCategories.Models.DTOs;
using BB20_SubCategories.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BB20_SubCategories.Repository.Services;

public class SubCategoryThumbNailRepository : ISubCategoryThumbNailRepository
{

    private readonly BB20_SubCategoriesContext _context;
    private readonly IMapper _mapper;

    public SubCategoryThumbNailRepository(BB20_SubCategoriesContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<SubCategoryThumbNailDTO>> GetDataBySubCategoryId(int subCategoryId)
    {
        List<SubCategoryThumbNail> subCategoriesTN = await _context.SubCategoryThumbNails
                                            .Where(x => x.DeleteFlag == false && x.SubCategoryId == subCategoryId)
                                            .AsNoTracking()
                                            .ToListAsync();

        return _mapper.Map<List<SubCategoryThumbNailDTO>>(subCategoriesTN);
    }

    public async Task<int> AddAsync(SubCategoryThumbNailDTO entity)
    {
        try
        {
            SubCategoryThumbNail subCategoriesTN = _mapper.Map<SubCategoryThumbNailDTO, SubCategoryThumbNail>(entity);

            subCategoriesTN.DeleteFlag = false;
            subCategoriesTN.CreatedDate = DateTime.Now;
            subCategoriesTN.UpdatedDate = DateTime.Now;

            _context.SubCategoryThumbNails.Add(subCategoriesTN);
            await _context.SaveChangesAsync();

            return subCategoriesTN.ThumbNailId;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> UpdateAsync(SubCategoryThumbNailDTO entity)
    {
        try
        {
            SubCategoryThumbNail subCategoriesTN = _mapper.Map<SubCategoryThumbNailDTO, SubCategoryThumbNail>(entity);

            subCategoriesTN.UpdatedDate = DateTime.Now;
            subCategoriesTN.DeleteFlag = false;

            _context.SubCategoryThumbNails.Update(subCategoriesTN);
            await _context.SaveChangesAsync();
            return true;

        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> RemoveAsync(int subCategoryThumbNailID)
    {
        try
        {
            SubCategoryThumbNail? subCategoriesTN = _context.SubCategoryThumbNails
                                .Where(x => x.ThumbNailId == subCategoryThumbNailID)
                                .FirstOrDefault();

            if (subCategoriesTN == null)
            {
                return false;
            }

            subCategoriesTN.UpdatedDate = DateTime.Now;
            subCategoriesTN.DeleteFlag = true;

            _context.SubCategoryThumbNails.Update(subCategoriesTN);
            await _context.SaveChangesAsync();

            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
