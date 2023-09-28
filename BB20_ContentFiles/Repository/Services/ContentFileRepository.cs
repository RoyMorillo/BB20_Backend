using AutoMapper;
using BB20_ContentFiles.Models;
using BB20_ContentFiles.Models.DTOs;
using BB20_ContentFiles.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BB20_ContentFiles.Repository.Services;

public class ContentFileRepository : IContentFileRepository
{
    private readonly BB20_ContentFileContext _context;
    private readonly IMapper _mapper;

    public ContentFileRepository(BB20_ContentFileContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<ContentFileDTO>> GetAll()
    {
        List<ContentFile> contentFiles = await _context.ContentFiles
                                    .Where(x => x.DeleteFlag == false)
                                    .AsNoTracking()
                                    .ToListAsync();

        return _mapper.Map<List<ContentFileDTO>>(contentFiles);
    }

    public async Task<ContentFileDTO> GetDataById(int contentFileId)
    {
        ContentFile contentFile = await _context.ContentFiles
                                    .Where(x => x.DeleteFlag == false && x.ContentFileId == contentFileId)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync();

        return _mapper.Map<ContentFileDTO>(contentFile);
    }

    public async Task<List<ContentFileDTO>> GetAllByContentId(int contentId)
    {
        List<ContentFile> contentFiles = await _context.ContentFiles
                                    .Where(x => x.DeleteFlag == false && x.ContentId == contentId)
                                    .AsNoTracking()
                                    .ToListAsync();

        return _mapper.Map<List<ContentFileDTO>>(contentFiles);
    }

    public Task<int> AddAsync(ContentFileDTO entity)
    {
        try
        {
            ContentFile contentFile = _mapper.Map<ContentFileDTO, ContentFile>(entity);

            contentFile.DeleteFlag = false;
            contentFile.CreatedDate = DateTime.Now;
            contentFile.UpdatedDate = DateTime.Now;

            _context.ContentFiles.Add(contentFile);
            _context.SaveChanges();

            return Task.FromResult(contentFile.ContentFileId);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> UpdateAsync(ContentFileDTO entity)
    {
        try
        {
            ContentFile contentFile = _mapper.Map<ContentFileDTO, ContentFile>(entity);

            contentFile.UpdatedDate = DateTime.Now;
            contentFile.DeleteFlag = false;

            _context.ContentFiles.Update(contentFile);
            await _context.SaveChangesAsync();
            return true;

        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> RemoveAsync(int contentFileId)
    {
        try
        {
            ContentFile contentFile = _context.ContentFiles
                                .Where(x => x.ContentFileId == contentFileId)
                                .FirstOrDefault();

            if (contentFile == null)
            {
                return false;
            }

            contentFile.UpdatedDate = DateTime.Now;
            contentFile.DeleteFlag = true;

            _context.ContentFiles.Update(contentFile);
            await _context.SaveChangesAsync();

            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
