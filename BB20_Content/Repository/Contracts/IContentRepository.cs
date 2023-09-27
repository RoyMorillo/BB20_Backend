using BB20_Content.Models.DTOs;

namespace BB20_Content.Repository.Contracts;

public interface IContentRepository
{
    public Task<List<ContentDTO>> GetAll();
    public Task<ContentDTO> GetDataById(int contentId);
    public Task<List<DropDownDTO>> GetAllForDropDown();
    public Task<List<ContentDTO>> GetAllByTitle(string title);
    public Task<int> AddAsync(ContentDTO entity);
    public Task<bool> UpdateAsync(ContentDTO entity);
    public Task<bool> RemoveAsync(int contentId);
}
