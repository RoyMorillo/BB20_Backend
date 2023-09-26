using BB20_InteriorCategories.Models.DTOs;
using BB20_InteriorCategories.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BB20_InteriorCategories.Controllers.v1;

/// <summary>
/// CRUD Operations on interior category table in database.
/// </summary>
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class InteriorCategoryController : ControllerBase
{
    private readonly IinteriorCategoryRepository _interiorCategoryRepository;

    public InteriorCategoryController(IinteriorCategoryRepository interiorCategoryRepository)
    {
        _interiorCategoryRepository = interiorCategoryRepository;
    }

    /// <summary>
    /// Get all interior categories only
    /// </summary>
    /// <returns>List of interior categories only</returns>
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<List<InteriorCategoryDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [Route("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        ResponseDTO<DataDTO<List<InteriorCategoryDTO>>> response = new ResponseDTO<DataDTO<List<InteriorCategoryDTO>>>();
        DataDTO<List<InteriorCategoryDTO>> data = new DataDTO<List<InteriorCategoryDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.InteriorCategories = await _interiorCategoryRepository.GetAll();

            if (data.InteriorCategories.Count > 0)
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
    /// Get an interior category by its ID
    /// </summary>
    /// <returns>interior category info</returns>
    [HttpGet("GetDataById/{interiorCategoryId}", Name = nameof(GetDataById))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<InteriorCategoryDTO>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetDataById(int interiorCategoryId)
    {
        ResponseDTO<DataDTO<InteriorCategoryDTO>> response = new ResponseDTO<DataDTO<InteriorCategoryDTO>>();
        DataDTO<InteriorCategoryDTO> data = new DataDTO<InteriorCategoryDTO>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.InteriorCategories = await _interiorCategoryRepository.GetDataById(interiorCategoryId);

            if (data.InteriorCategories != null)
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
    /// Get the list of all interior categories available and ready for dropdown in the front end
    /// </summary>
    /// <returns>Return Code and Description of the interior categories</returns>
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
            dropDown = await _interiorCategoryRepository.GetAllForDropDown();

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
