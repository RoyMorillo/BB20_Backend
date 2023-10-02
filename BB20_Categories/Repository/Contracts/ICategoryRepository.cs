using BB20_Categories.Models.DTOs;

namespace BB20_Categories.Repository.Contracts;

public interface ICategoryRepository
{
    public Task<List<CategoryDTO>> GetAll();
    public Task<List<CategoryTreeDTO>> GetAllTree();
    public Task<CategoryDTO> GetDataById(int categoryId);
    public Task<List<DropDownDTO>> GetAllForDropDown();
    public Task<int> AddAsync(CategoryDTO entity);
    public Task<bool> UpdateAsync(CategoryDTO entity);
    public Task<bool> RemoveAsync(int categoryId);
}
