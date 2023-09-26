using BB20_Categories.DTOs;
using BB20_Categories.Repository.Contracts;

namespace BB20_Categories.Repository.Services;

public class CategoryRepository : ICategoryRepository
{
    public Task<CategoryDTO> AddAsync(CategoryDTO entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<CategoryDTO>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<List<CategoryDTO>> GetAllbyDisplayStatus(int displayStatus)
    {
        throw new NotImplementedException();
    }

    public Task<CategoryDTO> GetAllBySearch(string categoryName)
    {
        throw new NotImplementedException();
    }

    public Task<List<DropDownDTO>> GetAllForDropDown()
    {
        throw new NotImplementedException();
    }

    public Task<CategoryDTO> GetDataById(int categoryId)
    {
        throw new NotImplementedException();
    }

    public Task<CategoryDTO> RemoveAsync(int categoryId)
    {
        throw new NotImplementedException();
    }

    public Task<CategoryDTO> UpdateAsync(CategoryDTO entity)
    {
        throw new NotImplementedException();
    }
}
