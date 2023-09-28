using BB20_ContentFiles.Models.DTOs;

namespace BB20_ContentFiles.Repository.Contracts;

public interface IContentFileRepository
{
    public Task<List<ContentFileDTO>> GetAll();
    public Task<ContentFileDTO> GetDataById(int contentFileId);
    public Task<List<ContentFileDTO>> GetAllByContentId(int contentId);
    public Task<int> AddAsync(ContentFileDTO entity);
    public Task<bool> UpdateAsync(ContentFileDTO entity);
    public Task<bool> RemoveAsync(int contentFileId);
}
