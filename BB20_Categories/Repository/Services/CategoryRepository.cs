using AutoMapper;
using BB20_Categories.Models;
using BB20_Categories.Models.DTOs;
using BB20_Categories.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Net.Http.Headers;

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
                                            .AsNoTracking()
                                            .ToListAsync();

        return _mapper.Map<List<CategoryDTO>>(categories);
    }

    public async Task<List<CategoryTreeDTO>> GetAllTree()
    {
        var subCategoryList = GetSubCategories();

        List<Category> Categories = await _context.Categories
                                    .Where(x => x.DeleteFlag == false)
                                    .AsNoTracking()
                                    .ToListAsync();

        var CategoryTree = _mapper.Map<List<CategoryTreeDTO>>(Categories);

        for (int i = 0; i < CategoryTree.Count; i++)
        {
            var subCatList = subCategoryList.Where(x => x.CategoryId == CategoryTree[i].CategoryId).ToList();

            CategoryTree[i].SubCategories = subCatList;
        }

        return CategoryTree;
    }

    public async Task<List<DropDownDTO>> GetAllForDropDown()
    {
        List<Category> categories = await _context.Categories
                                    .Where(x => x.DeleteFlag == false)
                                    .Select(s => new Category { CategoryId = s.CategoryId, Name = s.Name })
                                    .AsNoTracking()
                                    .ToListAsync();

        return _mapper.Map<List<DropDownDTO>>(categories);
    }

    public async Task<CategoryDTO> GetDataById(int categoryId)
    {
        Category? categories = await _context.Categories
                                            .Where(x => x.DeleteFlag == false && x.CategoryId == categoryId)
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync();

        return _mapper.Map<CategoryDTO>(categories);
    }

    public async Task<int> AddAsync(CategoryDTO entity)
    {
        try
        {
            Category category = _mapper.Map<CategoryDTO, Category>(entity);

            category.DeleteFlag = false;
            category.CreatedDate = DateTime.Now;
            category.UpdatedDate = DateTime.Now;

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return category.CategoryId;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> UpdateAsync(CategoryDTO entity)
    {
        try
        {
            Category category = _mapper.Map<CategoryDTO, Category>(entity);

            category.UpdatedDate = DateTime.Now;
            category.DeleteFlag = false;

            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            return true;

        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> RemoveAsync(int categoryId)
    {
        try
        {
            Category category = _context.Categories
                                .Where(x => x.CategoryId == categoryId)
                                .FirstOrDefault();

            if (category == null)
            {
                return false;
            }

            category.UpdatedDate = DateTime.Now;
            category.DeleteFlag = true;

            _context.Categories.Update(category);
            await _context.SaveChangesAsync();

            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }

    private List<SubCategoryTreeDTO> GetSubCategories()
    {
        var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("Microservices.json");

        IConfiguration _configuration = builder.Build();

        string BaseAddress = _configuration.GetValue<string>("Microservices:subCategory:BaseUrl").ToString();
        string EndPoint = _configuration.GetValue<string>("Microservices:subCategory:EndPoint").ToString();
        string URI = BaseAddress + EndPoint;

        HttpClient client = new HttpClient();

        client.BaseAddress = new Uri(BaseAddress);
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        try
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, URI);
            var responseMessage = client.Send(requestMessage);
            responseMessage.EnsureSuccessStatusCode();
            var responseContent = responseMessage.Content.ReadAsStringAsync().Result;

            var Response = JsonConvert.DeserializeObject<ResponseDTO<SubCategoryDataDTO<List<SubCategoryTreeDTO>>>>(responseContent);

            return Response.data.SubCategories;
        }
        catch (HttpRequestException)
        {
            List<SubCategoryTreeDTO> interiorCategoryDTOs = new List<SubCategoryTreeDTO>();
            return interiorCategoryDTOs;
        }
    }
}
