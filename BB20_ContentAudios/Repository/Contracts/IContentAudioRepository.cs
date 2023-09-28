using BB20_ContentAudios.Models.DTOs;

namespace BB20_ContentAudios.Repository.Contracts;

public interface IContentAudioRepository
{
    public Task<List<ContentAudioDTO>> GetAll();
    public Task<ContentAudioDTO> GetDataById(int contentAudioId);
    public Task<List<ContentAudioDTO>> GetAllByContentId(int contentId);
    public Task<int> AddAsync(ContentAudioDTO entity);
    public Task<bool> UpdateAsync(ContentAudioDTO entity);
    public Task<bool> RemoveAsync(int contentAudioId);
}
