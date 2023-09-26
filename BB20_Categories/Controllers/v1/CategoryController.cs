using BB20_Categories.Models.DTOs;
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
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<List<CategoryDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [Route("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        ResponseDTO<DataDTO<List<CategoryDTO>>> response = new ResponseDTO<DataDTO<List<CategoryDTO>>>();
        DataDTO<List<CategoryDTO>> data = new DataDTO<List<CategoryDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
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
            error.innerException = ex.InnerException?.Message;

            response.success = false;
            response.error = error;
            response.data = data;

            return BadRequest(response);
        }
    }

    /// <summary>
    /// Get a category by its ID
    /// </summary>
    /// <returns>category info</returns>
    [HttpGet("GetDataById/{categoryId}", Name = nameof(GetDataById))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<CategoryDTO>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetDataById(int categoryId)
    {
        ResponseDTO<DataDTO<CategoryDTO>> response = new ResponseDTO<DataDTO<CategoryDTO>>();
        DataDTO<CategoryDTO> data = new DataDTO<CategoryDTO>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.Categories = await _categoryRepository.GetDataById(categoryId);

            if (data.Categories != null)
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
            error.innerException = ex.InnerException?.Message;

            response.success = false;
            response.error = error;
            response.data = data;

            return BadRequest(response);
        }
    }

    /// <summary>
    /// Get the list of all categories available and ready for dropdown in the front end
    /// </summary>
    /// <returns>Return Code and Description of the categories</returns>
    [HttpGet("GetForDropDown", Name = nameof(GetForDropDown))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<List<DropDownDTO>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetForDropDown()
    {
        ResponseDTO<List<DropDownDTO>> response = new ResponseDTO<List<DropDownDTO>>();
        List<DropDownDTO> dropDown = new List<DropDownDTO>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            dropDown = await _categoryRepository.GetAllForDropDown();

            if (dropDown.Count > 0)
            {
                response.success = true;
                response.error = error;
                response.data = dropDown;

                return Ok(response);
            }

            response.success = true;
            response.error = error;
            response.data = dropDown;

            return NotFound(response);
        }
        catch (Exception ex)
        {
            error.message = ex.Message;
            error.innerException = ex.InnerException?.Message;

            response.success = false;
            response.error = error;
            response.data = dropDown;

            return BadRequest(response);
        }
    }
}
