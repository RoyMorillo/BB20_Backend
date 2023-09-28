using BB20_ContentVideos.Models.DTOs;

namespace BB20_ContentVideos.Repository.Contracts;

public interface IContentVideoRepository
{
    public Task<List<ContentVideoDTO>> GetAll();
    public Task<ContentVideoDTO> GetDataById(int contentVideoId);
    public Task<List<ContentVideoDTO>> GetAllByContentId(int contentId);
    public Task<int> AddAsync(ContentVideoDTO entity);
    public Task<bool> UpdateAsync(ContentVideoDTO entity);
    public Task<bool> RemoveAsync(int contentVideoId);
}
