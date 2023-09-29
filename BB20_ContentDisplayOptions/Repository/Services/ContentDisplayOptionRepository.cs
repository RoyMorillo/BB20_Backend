using AutoMapper;
using BB20_ContentDisplayOptions.Models;
using BB20_ContentDisplayOptions.Models.DTOs;
using BB20_ContentDisplayOptions.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BB20_ContentDisplayOptions.Repository.Services;

public class ContentDisplayOptionRepository : IContentDisplayOptionRepository
{
    private readonly BB20_ContentDisplayOptionContext _context;
    private readonly IMapper _mapper;

    public ContentDisplayOptionRepository(BB20_ContentDisplayOptionContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<ContentDisplayOptionDTO>> GetAll()
    {
        List<ContentDisplayOption> contentDisplayOptions = await _context.ContentDisplayOptions
                                            .Where(x => x.DeleteFlag == false)
                                            .Include(x => x.DisplayOptionCategories)
                                            .AsNoTracking()
                                            .ToListAsync();

        return _mapper.Map<List<ContentDisplayOptionDTO>>(contentDisplayOptions);
    }

    public async Task<ContentDisplayOptionDTO> GetDataById(int contentDisplayOptionId)
    {
        ContentDisplayOption? contentDisplayOption = await _context.ContentDisplayOptions
                                            .Where(x => x.DeleteFlag == false && x.ContentDisplayOptionId == contentDisplayOptionId)
                                            .Include(x => x.DisplayOptionCategories)
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync();

        return _mapper.Map<ContentDisplayOptionDTO>(contentDisplayOption);
    }

    public async Task<List<ContentDisplayOptionDTO>> GetDataByContentId(int contentId)
    {
        List<ContentDisplayOption> contentDisplayOptions = await _context.ContentDisplayOptions
                                            .Where(x => x.DeleteFlag == false && x.ContentId == contentId)
                                            .Include(x => x.DisplayOptionCategories)
                                            .AsNoTracking()
                                            .ToListAsync();

        return _mapper.Map<List<ContentDisplayOptionDTO>>(contentDisplayOptions);
    }

    public async Task<int> AddAsync(ContentDisplayOptionDTO entity)
    {
        try
        {
            ContentDisplayOption contentDisplayOption = _mapper.Map<ContentDisplayOptionDTO, ContentDisplayOption>(entity);

            contentDisplayOption.DeleteFlag = false;
            contentDisplayOption.CreatedDate = DateTime.Now;
            contentDisplayOption.UpdatedDate = DateTime.Now;

            _context.ContentDisplayOptions.Add(contentDisplayOption);
            await _context.SaveChangesAsync();

            return contentDisplayOption.ContentDisplayOptionId;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> UpdateAsync(ContentDisplayOptionDTO entity)
    {
        try
        {
            ContentDisplayOption contentDisplayOption = _mapper.Map<ContentDisplayOptionDTO, ContentDisplayOption>(entity);

            contentDisplayOption.UpdatedDate = DateTime.Now;
            contentDisplayOption.DeleteFlag = false;

            _context.ContentDisplayOptions.Update(contentDisplayOption);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> RemoveAsync(int contentDisplayOptionId)
    {
        try
        {
            ContentDisplayOption contentDisplayOption = _context.ContentDisplayOptions
                                .Where(x => x.ContentDisplayOptionId == contentDisplayOptionId)
                                .FirstOrDefault();

            if (contentDisplayOption == null)
            {
                return false;
            }

            contentDisplayOption.UpdatedDate = DateTime.Now;
            contentDisplayOption.DeleteFlag = true;

            _context.ContentDisplayOptions.Update(contentDisplayOption);
            await _context.SaveChangesAsync();

            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
