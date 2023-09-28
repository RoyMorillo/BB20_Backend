using AutoMapper;
using BB20_ContentAudios.Models;
using BB20_ContentAudios.Models.DTOs;
using BB20_ContentAudios.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BB20_ContentAudios.Repository.Services;

public class ContentAudioRepository : IContentAudioRepository
{
    private readonly BB20_ContentAudioContext _context;
    private readonly IMapper _mapper;

    public ContentAudioRepository(BB20_ContentAudioContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<ContentAudioDTO>> GetAll()
    {
        List<ContentAudio> contentAudios = await _context.ContentAudios
                                    .Where(x => x.DeleteFlag == false)
                                    .AsNoTracking()
                                    .ToListAsync();

        return _mapper.Map<List<ContentAudioDTO>>(contentAudios);
    }

    public async Task<ContentAudioDTO> GetDataById(int contentAudioId)
    {
        ContentAudio contentAudio = await _context.ContentAudios
                                    .Where(x => x.DeleteFlag == false && x.ContentAudioId == contentAudioId)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync();

        return _mapper.Map<ContentAudioDTO>(contentAudio);
    }

    public async Task<List<ContentAudioDTO>> GetAllByContentId(int contentId)
    {
        List<ContentAudio> contentAudios = await _context.ContentAudios
                                    .Where(x => x.DeleteFlag == false && x.ContentId == contentId)
                                    .AsNoTracking()
                                    .ToListAsync();

        return _mapper.Map<List<ContentAudioDTO>>(contentAudios);
    }

    public Task<int> AddAsync(ContentAudioDTO entity)
    {
        try
        {
            ContentAudio contentAudio = _mapper.Map<ContentAudioDTO, ContentAudio>(entity);

            contentAudio.DeleteFlag = false;
            contentAudio.CreatedDate = DateTime.Now;
            contentAudio.UpdatedDate = DateTime.Now;

            _context.ContentAudios.Add(contentAudio);
            _context.SaveChanges();

            return Task.FromResult(contentAudio.ContentAudioId);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> UpdateAsync(ContentAudioDTO entity)
    {
        try
        {
            ContentAudio contentAudio = _mapper.Map<ContentAudioDTO, ContentAudio>(entity);

            contentAudio.UpdatedDate = DateTime.Now;
            contentAudio.DeleteFlag = false;

            _context.ContentAudios.Update(contentAudio);
            await _context.SaveChangesAsync();
            return true;

        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> RemoveAsync(int contentAudioId)
    {
        try
        {
            ContentAudio contentAudio = _context.ContentAudios
                                .Where(x => x.ContentAudioId == contentAudioId)
                                .FirstOrDefault();

            if (contentAudio == null)
            {
                return false;
            }

            contentAudio.UpdatedDate = DateTime.Now;
            contentAudio.DeleteFlag = true;

            _context.ContentAudios.Update(contentAudio);
            await _context.SaveChangesAsync();

            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
