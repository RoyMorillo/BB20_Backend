using BB20_InteriorCategories.Models.DTOs;

namespace BB20_InteriorCategories.Repository.Contracts;

public interface IinteriorCategoryRepository
{
    public Task<List<InteriorCategoryDTO>> GetAll();
    public Task<InteriorCategoryDTO> GetDataById(int interiorCategoryId);
    public Task<List<DropDownDTO>> GetAllForDropDown();
}
