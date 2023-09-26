using BB20_SubCategories.Models.DTOs;

namespace BB20_SubCategories.Repository.Contracts;

public interface ISubCategoryRepository
{
    public Task<List<SubCategoryDTO>> GetAll();
    public Task<List<SubCategoryTreeDTO>> GetAllTree();
    public Task<SubCategoryDTO> GetDataById(int subCategoryId);
    public Task<List<DropDownDTO>> GetAllForDropDown();
}
