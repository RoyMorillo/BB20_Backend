using AutoMapper;
using BB20_ContentVideos.Models;
using BB20_ContentVideos.Models.DTOs;
using BB20_ContentVideos.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BB20_ContentVideos.Repository.Services;

public class ContentVideoRepository : IContentVideoRepository
{
    private readonly BB20_ContentVideoContext _context;
    private readonly IMapper _mapper;

    public ContentVideoRepository(BB20_ContentVideoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<ContentVideoDTO>> GetAll()
    {
        List<ContentVideo> contentVideos = await _context.ContentVideos
                                    .Where(x => x.DeleteFlag == false)
                                    .AsNoTracking()
                                    .ToListAsync();

        return _mapper.Map<List<ContentVideoDTO>>(contentVideos);
    }

    public async Task<ContentVideoDTO> GetDataById(int contentVideoId)
    {
        ContentVideo contentVideo = await _context.ContentVideos
                                    .Where(x => x.DeleteFlag == false && x.ContentVideoId == contentVideoId)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync();

        return _mapper.Map<ContentVideoDTO>(contentVideo);
    }

    public async Task<List<ContentVideoDTO>> GetAllByContentId(int contentId)
    {
        List<ContentVideo> contentVideos = await _context.ContentVideos
                                    .Where(x => x.DeleteFlag == false && x.ContentId == contentId)
                                    .AsNoTracking()
                                    .ToListAsync();

        return _mapper.Map<List<ContentVideoDTO>>(contentVideos);
    }

    public Task<int> AddAsync(ContentVideoDTO entity)
    {
        try
        {
            ContentVideo contentVideo = _mapper.Map<ContentVideoDTO, ContentVideo>(entity);

            contentVideo.DeleteFlag = false;
            contentVideo.CreatedDate = DateTime.Now;
            contentVideo.UpdatedDate = DateTime.Now;

            _context.ContentVideos.Add(contentVideo);
            _context.SaveChanges();

            return Task.FromResult(contentVideo.ContentVideoId);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> UpdateAsync(ContentVideoDTO entity)
    {
        try
        {
            ContentVideo contentVideo = _mapper.Map<ContentVideoDTO, ContentVideo>(entity);

            contentVideo.UpdatedDate = DateTime.Now;
            contentVideo.DeleteFlag = false;

            _context.ContentVideos.Update(contentVideo);
            await _context.SaveChangesAsync();
            return true;

        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> RemoveAsync(int contentVideoId)
    {
        try
        {
            ContentVideo contentVideo = _context.ContentVideos
                                .Where(x => x.ContentVideoId == contentVideoId)
                                .FirstOrDefault();

            if (contentVideo == null)
            {
                return false;
            }

            contentVideo.UpdatedDate = DateTime.Now;
            contentVideo.DeleteFlag = true;

            _context.ContentVideos.Update(contentVideo);
            await _context.SaveChangesAsync();

            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
