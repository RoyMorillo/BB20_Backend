using BB20_ContentDisplayOptions.Models.DTOs;

namespace BB20_ContentDisplayOptions.Repository.Contracts;

public interface IContentDisplayOptionRepository
{
    public Task<List<ContentDisplayOptionDTO>> GetAll();
    public Task<ContentDisplayOptionDTO> GetDataById(int contentDisplayOptionId);
    public Task<List<ContentDisplayOptionDTO>> GetDataByContentId(int contentId);
    public Task<int> AddAsync(ContentDisplayOptionDTO entity);
    public Task<bool> UpdateAsync(ContentDisplayOptionDTO entity);
    public Task<bool> RemoveAsync(int contentDisplayOptionId);
}
