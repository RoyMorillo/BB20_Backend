using AutoMapper;
using BB20_SubCategories.Models;
using BB20_SubCategories.Models.DTOs;
using BB20_SubCategories.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace BB20_SubCategories.Repository.Services;

public class SubCategoryRepository : ISubCategoryRepository
{
    private readonly BB20_SubCategoriesContext _context;
    private readonly IMapper _mapper;

    public SubCategoryRepository(BB20_SubCategoriesContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<SubCategoryDTO>> GetAll()
    {
        List<SubCategory> subCategories = await _context.SubCategories
                                            .Where(x => x.DeleteFlag == false)
                                            .Include(x => x.SubCategoryThumbNails)
                                            .AsNoTracking()
                                            .ToListAsync();

        return _mapper.Map<List<SubCategoryDTO>>(subCategories);
    }

    public async Task<List<DropDownDTO>> GetAllForDropDown()
    {
        List<SubCategory> subCategories = await _context.SubCategories
                                    .Where(x => x.DeleteFlag == false)
                                    .Select(s => new SubCategory
                                    {
                                        SubCategoryId = s.SubCategoryId,
                                        Name = s.Name
                                    })
                                    .AsNoTracking()
                                    .ToListAsync();

        return _mapper.Map<List<DropDownDTO>>(subCategories);
    }

    public async Task<List<SubCategoryTreeDTO>> GetAllTree()
    {
        var interiorCategoryList = GetInteriorCategories();

        List<SubCategory> subCategories = await _context.SubCategories
                                    .Where(x => x.DeleteFlag == false)
                                    .Include(x => x.SubCategoryThumbNails)
                                    .AsNoTracking()
                                    .ToListAsync();

        var subCategoryTree = _mapper.Map<List<SubCategoryTreeDTO>>(subCategories);

        for (int i = 0; i < subCategoryTree.Count; i++)
        {
            var intCatList = interiorCategoryList.Where(x => x.SubCategoryId == subCategoryTree[i].SubCategoryId).ToList();

            subCategoryTree[i].InteriorCategories = intCatList;
        }

        return subCategoryTree;
    }

    public async Task<List<SubCategoryDTO>> GetDataByCategoryId(int categoryId)
    {
        List<SubCategory> subCategories = await _context.SubCategories
                                            .Where(x => x.DeleteFlag == false && x.CategoryId == categoryId)
                                            .Include(x => x.SubCategoryThumbNails)
                                            .AsNoTracking()
                                            .ToListAsync();

        return _mapper.Map<List<SubCategoryDTO>>(subCategories);
    }

    public async Task<SubCategoryDTO> GetDataById(int subCategoryId)
    {
        SubCategory? subCategories = await _context.SubCategories
                                            .Where(x => x.DeleteFlag == false && x.SubCategoryId == subCategoryId)
                                            .Include(x => x.SubCategoryThumbNails)
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync();

        return _mapper.Map<SubCategoryDTO>(subCategories);
    }

    private List<InteriorCategoryDTO> GetInteriorCategories()
    {
        var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("Microservices.json");

        IConfiguration _configuration = builder.Build();

        string BaseAddress = _configuration.GetValue<string>("Microservices:InteriorCategory:BaseUrl").ToString();
        string EndPoint = _configuration.GetValue<string>("Microservices:InteriorCategory:EndPoint").ToString();
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

            var Response = JsonConvert.DeserializeObject<ResponseDTO<InteriorDataDTO<List<InteriorCategoryDTO>>>>(responseContent);

            return Response.data.InteriorCategories;
        }
        catch (HttpRequestException)
        {
            List<InteriorCategoryDTO> interiorCategoryDTOs = new List<InteriorCategoryDTO>();
            return interiorCategoryDTOs;
        }
    }
}
