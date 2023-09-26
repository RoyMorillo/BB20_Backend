using BB20_Categories.DTOs;
using BB20_Categories.Enums;

namespace BB20_Categories.Repository.Contracts;

public interface ICategoryRepository
{
    public Task<List<CategoryDTO>> GetAll();
    public Task<List<CategoryDTO>> GetAllbyDisplayStatus(int displayStatus);
    public Task<CategoryDTO> GetDataById(int categoryId);
    public Task<CategoryDTO> GetAllBySearch(string categoryName);
    public Task<List<DropDownDTO>> GetAllForDropDown();
    public Task<CategoryDTO> AddAsync(CategoryDTO entity);
    public Task<CategoryDTO> UpdateAsync(CategoryDTO entity);
    public Task<CategoryDTO> RemoveAsync(int categoryId);
}
