﻿using BB20_SubCategories.Models.DTOs;

namespace BB20_SubCategories.Repository.Contracts;

public interface ISubCategoryRepository
{
    public Task<List<SubCategoryDTO>> GetAll();
    public Task<List<SubCategoryTreeDTO>> GetAllTree();
    public Task<SubCategoryDTO> GetDataById(int subCategoryId);
    public Task<List<SubCategoryDTO>> GetDataByCategoryId(int categoryId);
    public Task<List<DropDownDTO>> GetAllForDropDown();
    public Task<int> AddAsync(SubCategoryDTO entity);
    public Task<bool> UpdateAsync(SubCategoryDTO entity);
    public Task<bool> RemoveAsync(int subCategoryId);
}
