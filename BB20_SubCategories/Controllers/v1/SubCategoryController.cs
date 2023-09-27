using BB20_SubCategories.Models.DTOs;
using BB20_SubCategories.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BB20_SubCategories.Controllers.v1;

/// <summary>
/// CRUD Operations on category table in database.
/// </summary>
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class SubCategoryController : ControllerBase
{
    private readonly ISubCategoryRepository _subCategoryRepository;

    public SubCategoryController(ISubCategoryRepository subCategoryRepository)
    {
        _subCategoryRepository = subCategoryRepository;
    }

    /// <summary>
    /// Get all sub categories only
    /// </summary>
    /// <returns>List of sub categories only</returns>
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<List<SubCategoryDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [Route("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        ResponseDTO<DataDTO<List<SubCategoryDTO>>> response = new ResponseDTO<DataDTO<List<SubCategoryDTO>>>();
        DataDTO<List<SubCategoryDTO>> data = new DataDTO<List<SubCategoryDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.SubCategories = await _subCategoryRepository.GetAll();

            if (data.SubCategories.Count > 0)
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
    /// Get all sub categories with its interior categories
    /// </summary>
    /// <returns>List of sub categories with its interior categories</returns>
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<List<SubCategoryTreeDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [Route("GetAllTree")]
    public async Task<IActionResult> GetAllTree()
    {
        ResponseDTO<DataDTO<List<SubCategoryTreeDTO>>> response = new ResponseDTO<DataDTO<List<SubCategoryTreeDTO>>>();
        DataDTO<List<SubCategoryTreeDTO>> data = new DataDTO<List<SubCategoryTreeDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.SubCategories = await _subCategoryRepository.GetAllTree();

            if (data.SubCategories.Count > 0)
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
    /// Get a sub category by its ID
    /// </summary>
    /// <returns>sub category info</returns>
    [HttpGet("GetDataById/{subCategoryId}", Name = nameof(GetDataById))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<SubCategoryDTO>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetDataById(int subCategoryId)
    {
        ResponseDTO<DataDTO<SubCategoryDTO>> response = new ResponseDTO<DataDTO<SubCategoryDTO>>();
        DataDTO<SubCategoryDTO> data = new DataDTO<SubCategoryDTO>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.SubCategories = await _subCategoryRepository.GetDataById(subCategoryId);

            if (data.SubCategories != null)
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
    /// Get a list sub category by its Category ID
    /// </summary>
    /// <returns>sub category list info</returns>
    [HttpGet("GetDataByCategoryId/{categoryId}", Name = nameof(GetDataByCategoryId))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<List<SubCategoryDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetDataByCategoryId(int categoryId)
    {
        ResponseDTO<DataDTO<List<SubCategoryDTO>>> response = new ResponseDTO<DataDTO<List<SubCategoryDTO>>>();
        DataDTO<List<SubCategoryDTO>> data = new DataDTO<List<SubCategoryDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.SubCategories = await _subCategoryRepository.GetDataByCategoryId(categoryId);

            if (data.SubCategories != null)
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
    /// Get the list of all sub categories available and ready for dropdown in the front end
    /// </summary>
    /// <returns>Return Code and Description of the sub categories</returns>
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
            dropDown = await _subCategoryRepository.GetAllForDropDown();

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
