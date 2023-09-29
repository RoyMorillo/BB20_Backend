using AutoMapper;
using BB20_ContentDisplayOptions.Models;
using BB20_ContentDisplayOptions.Models.DTOs;
using BB20_ContentDisplayOptions.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BB20_ContentDisplayOptions.Repository.Services;

public class DisplayOptionCategoryRepository : IDisplayOptionCategoryRepository
{

    private readonly BB20_ContentDisplayOptionContext _context;
    private readonly IMapper _mapper;

    public DisplayOptionCategoryRepository(BB20_ContentDisplayOptionContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<DisplayOptionCategoryDTO>> GetAll()
    {
        List<DisplayOptionCategory> displayOptionCategories = await _context.DisplayOptionCategories
                                            .Where(x => x.DeleteFlag == false)
                                            .AsNoTracking()
                                            .ToListAsync();

        return _mapper.Map<List<DisplayOptionCategoryDTO>>(displayOptionCategories);
    }

    public async Task<DisplayOptionCategoryDTO> GetDataById(int displayOptionCategoryId)
    {
        DisplayOptionCategory? displayOptionCategory = await _context.DisplayOptionCategories
                                            .Where(x => x.DeleteFlag == false && x.ContentDisplayOptionCategoryId == displayOptionCategoryId)
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync();

        return _mapper.Map<DisplayOptionCategoryDTO>(displayOptionCategory);
    }

    public async Task<List<DisplayOptionCategoryDTO>> GetDataByContentDisplayOptionId(int contentDisplayOptionId)
    {
        List<DisplayOptionCategory> displayOptionCategories = await _context.DisplayOptionCategories
                                            .Where(x => x.DeleteFlag == false && x.ContentDisplayOptionId == contentDisplayOptionId)
                                            .AsNoTracking()
                                            .ToListAsync();

        return _mapper.Map<List<DisplayOptionCategoryDTO>>(displayOptionCategories);
    }

    public async Task<int> AddAsync(DisplayOptionCategoryDTO entity)
    {
        try
        {
            DisplayOptionCategory displayOptionCategory = _mapper.Map<DisplayOptionCategoryDTO, DisplayOptionCategory>(entity);

            displayOptionCategory.DeleteFlag = false;
            displayOptionCategory.CreatedDate = DateTime.Now;
            displayOptionCategory.UpdatedDate = DateTime.Now;

            _context.DisplayOptionCategories.Add(displayOptionCategory);
            await _context.SaveChangesAsync();

            return displayOptionCategory.ContentDisplayOptionCategoryId;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> UpdateAsync(DisplayOptionCategoryDTO entity)
    {
        try
        {
            DisplayOptionCategory displayOptionCategory = _mapper.Map<DisplayOptionCategoryDTO, DisplayOptionCategory>(entity);

            displayOptionCategory.UpdatedDate = DateTime.Now;
            displayOptionCategory.DeleteFlag = false;

            _context.DisplayOptionCategories.Update(displayOptionCategory);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> RemoveAsync(int displayOptionCategoryId)
    {
        try
        {
            DisplayOptionCategory displayOptionCategory = _context.DisplayOptionCategories
                                .Where(x => x.ContentDisplayOptionCategoryId == displayOptionCategoryId)
                                .FirstOrDefault();

            if (displayOptionCategory == null)
            {
                return false;
            }

            displayOptionCategory.UpdatedDate = DateTime.Now;
            displayOptionCategory.DeleteFlag = true;

            _context.DisplayOptionCategories.Update(displayOptionCategory);
            await _context.SaveChangesAsync();

            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }

}
