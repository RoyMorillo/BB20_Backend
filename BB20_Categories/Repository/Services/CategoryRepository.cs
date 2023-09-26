using AutoMapper;
using BB20_Categories.Models;
using BB20_Categories.Models.DTOs;
using BB20_Categories.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BB20_Categories.Repository.Services;

public class CategoryRepository : ICategoryRepository
{
    private readonly BB20_CategoriesContext _context;
    private readonly IMapper _mapper;

    public CategoryRepository(BB20_CategoriesContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<CategoryDTO>> GetAll()
    {
        List<Category> categories = await _context.Categories
                                            .Where(x => x.DeleteFlag == false)
                                            .Select(s => new Category { CategoryId = s.CategoryId, Name = s.Name, DisplayStatus = s.DisplayStatus })
                                            .AsNoTracking()
                                            .ToListAsync();

        return _mapper.Map<List<CategoryDTO>>(categories);
    }

    public Task<List<CategoryDTO>> GetAllTree()
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

    public Task<CategoryDTO> AddAsync(CategoryDTO entity)
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
