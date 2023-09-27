using AutoMapper;
using BB20_Content.Models;
using BB20_Content.Models.DTOs;
using BB20_Content.Repository.Contracts;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace BB20_Content.Repository.Services;

public class ContentRepository : IContentRepository
{
    private readonly BB20_ContentContext _context;
    private readonly IMapper _mapper;

    public ContentRepository(BB20_ContentContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<ContentDTO>> GetAll()
    {
        List<Content> contents = await _context.Contents
                                    .Where(x => x.DeleteFlag == false)
                                    .AsNoTracking()
                                    .ToListAsync();

        return _mapper.Map<List<ContentDTO>>(contents);
    }

    public async Task<ContentDTO> GetDataById(int contentId)
    {
        Content content = await _context.Contents
                                    .Where(x => x.DeleteFlag == false && x.ContentId == contentId)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync();

        return _mapper.Map<ContentDTO>(content);
    }

    public async Task<List<ContentDTO>> GetAllByTitle(string title)
    {
        var predicate = PredicateBuilder.New<Content>();

        predicate = predicate.And(x => x.DeleteFlag.Equals(false));
        predicate = predicate.And(x => x.Title.Contains(title));

        List<Content> contents = await _context.Contents
                            .Where(predicate)
                            .AsNoTracking()
                            .ToListAsync();

        return _mapper.Map<List<ContentDTO>>(contents);

    }

    public async Task<List<DropDownDTO>> GetAllForDropDown()
    {
        List<Content> contents = await _context.Contents
                                    .Where(x => x.DeleteFlag == false)
                                    .Select(s => new Content
                                    {
                                        ContentId = s.ContentId,
                                        Title = s.Title
                                    })
                                    .AsNoTracking()
                                    .ToListAsync();

        return _mapper.Map<List<DropDownDTO>>(contents);
    }

    public Task<int> AddAsync(ContentDTO entity)
    {
        try
        {
            Content content = _mapper.Map<ContentDTO, Content>(entity);

            content.DeleteFlag = false;
            content.CreatedDate = DateTime.Now;
            content.UpdatedDate = DateTime.Now;

            _context.Contents.Add(content);
            _context.SaveChanges();

            return Task.FromResult(content.ContentId);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> UpdateAsync(ContentDTO entity)
    {
        try
        {
            Content content = _mapper.Map<ContentDTO, Content>(entity);

            content.UpdatedDate = DateTime.Now;
            content.DeleteFlag = false;

            _context.Contents.Update(content);
            await _context.SaveChangesAsync();
            return true;

        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> RemoveAsync(int contentId)
    {
        try
        {
            Content content = _context.Contents
                                .Where(x => x.ContentId == contentId)
                                .FirstOrDefault();

            if (content == null)
            {
                return false;
            }

            content.UpdatedDate = DateTime.Now;
            content.DeleteFlag = true;

            _context.Contents.Update(content);
            await _context.SaveChangesAsync();

            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
