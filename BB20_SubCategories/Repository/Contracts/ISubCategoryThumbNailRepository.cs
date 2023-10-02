using BB20_SubCategories.Models.DTOs;

namespace BB20_SubCategories.Repository.Contracts;

public interface ISubCategoryThumbNailRepository
{
    public Task<List<SubCategoryThumbNailDTO>> GetDataBySubCategoryId(int subCategoryId);
    public Task<int> AddAsync(SubCategoryThumbNailDTO entity);
    public Task<bool> UpdateAsync(SubCategoryThumbNailDTO entity);
    public Task<bool> RemoveAsync(int subCategoryThumbNailID);
}
