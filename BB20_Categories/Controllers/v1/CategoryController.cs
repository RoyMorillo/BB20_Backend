using BB20_Categories.DTOs;
using BB20_Categories.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BB20_Categories.Controllers.v1;

/// <summary>
/// CRUD Operations on category table in database.
/// </summary>
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class CategoryController : ControllerBase
{

    private readonly ICategoryRepository _categoryRepository;

    public CategoryController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    /// <summary>
    /// Get all categories only
    /// </summary>
    /// <returns>List of categories only</returns>
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<CategoryDTO>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [Route("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        ResponseDTO<DataDTO<List<CategoryDTO>>> response = new ResponseDTO<DataDTO<List<CategoryDTO>>>();
        DataDTO<List<CategoryDTO>> data = new DataDTO<List<CategoryDTO>>();

        ErrorDTO error = new()
        {
            reason = string.Empty,
            message = string.Empty
        };

        try
        {
            data.Categories = await _categoryRepository.GetAll();

            if (data.Categories.Count > 0)
            {
                response.success = true;
                response.error = error;
                response.data = data;
                return Ok(response);
            }

            response.success = true;
            response.error = error;
            response.data = data;

            return NotFound(response);
        }
        catch (Exception ex)
        {
            error.message = ex.Message;
            error.reason = ex.InnerException?.Message;

            response.success = false;
            response.error = error;
            response.data = data;

            return BadRequest(response);
        }
    }
}
