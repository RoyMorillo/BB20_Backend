using BB20_ContentDisplayOptions.Models.DTOs;

namespace BB20_ContentDisplayOptions.Repository.Contracts;

public interface IDisplayOptionCategoryRepository
{
    public Task<List<DisplayOptionCategoryDTO>> GetAll();
    public Task<DisplayOptionCategoryDTO> GetDataById(int displayOptionCategoryId);
    public Task<List<DisplayOptionCategoryDTO>> GetDataByContentDisplayOptionId(int contentDisplayOptionId);
    public Task<int> AddAsync(DisplayOptionCategoryDTO entity);
    public Task<bool> UpdateAsync(DisplayOptionCategoryDTO entity);
    public Task<bool> RemoveAsync(int displayOptionCategoryId);
}
