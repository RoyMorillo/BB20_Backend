using BB20_ContentDisplayOptions.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;
using BB20_ContentDisplayOptions.Models.DTOs;
using BB20_ContentDisplayOptions.Repository.Services;
using BB20_SubCategories.Models.DTOs;

namespace BB20_ContentDisplayOptions.Controllers.v1;

/// <summary>
/// CRUD Operations on display option category table in database.
/// </summary>
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class DisplayOptionCategoryController : ControllerBase
{
    private readonly IDisplayOptionCategoryRepository _displayOptionCategoryRepository;

    public DisplayOptionCategoryController(IDisplayOptionCategoryRepository displayOptionCategoryRepository)
    {
        _displayOptionCategoryRepository = displayOptionCategoryRepository;
    }

    /// <summary>
    /// Get all content display option only
    /// </summary>
    /// <returns>List of content display option only</returns>
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDispOptCatDTO<List<DisplayOptionCategoryDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [Route("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        ResponseDTO<DataDispOptCatDTO<List<DisplayOptionCategoryDTO>>> response = new ResponseDTO<DataDispOptCatDTO<List<DisplayOptionCategoryDTO>>>();
        DataDispOptCatDTO<List<DisplayOptionCategoryDTO>> data = new DataDispOptCatDTO<List<DisplayOptionCategoryDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.DisplayOptionCategories = await _displayOptionCategoryRepository.GetAll();

            if (data.DisplayOptionCategories.Count > 0)
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
    /// Get a display option category by its ID
    /// </summary>
    /// <returns>display option category info</returns>
    [HttpGet("GetDataById/{displayOptionCategoryId}", Name = nameof(GetDataById))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDispOptCatDTO<DisplayOptionCategoryDTO>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetDataById(int displayOptionCategoryId)
    {
        ResponseDTO<DataDispOptCatDTO<DisplayOptionCategoryDTO>> response = new ResponseDTO<DataDispOptCatDTO<DisplayOptionCategoryDTO>>();
        DataDispOptCatDTO<DisplayOptionCategoryDTO> data = new DataDispOptCatDTO<DisplayOptionCategoryDTO>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.DisplayOptionCategories = await _displayOptionCategoryRepository.GetDataById(displayOptionCategoryId);

            if (data.DisplayOptionCategories != null)
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
    /// Get a display option category by its content display option ID
    /// </summary>
    /// <returns>display option category info</returns>
    [HttpGet("GetDataByContentDisplayOptionId/{displayOptionCategoryId}", Name = nameof(GetDataByContentDisplayOptionId))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDispOptCatDTO<List<DisplayOptionCategoryDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetDataByContentDisplayOptionId(int contentDisplayOptionId)
    {
        ResponseDTO<DataDispOptCatDTO<List<DisplayOptionCategoryDTO>>> response = new ResponseDTO<DataDispOptCatDTO<List<DisplayOptionCategoryDTO>>>();
        DataDispOptCatDTO<List<DisplayOptionCategoryDTO>> data = new DataDispOptCatDTO<List<DisplayOptionCategoryDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.DisplayOptionCategories = await _displayOptionCategoryRepository.GetDataByContentDisplayOptionId(contentDisplayOptionId);

            if (data.DisplayOptionCategories != null)
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
    /// This endpoint is for the creation of a display option category, you can create one display option category at a time.
    /// </summary>
    /// <param name="displayOptionCategoryDTO">display option category you want to create</param>
    /// <returns>One recored with the display option category created and its Id.</returns>
    [HttpPost("Create", Name = nameof(Create))]
    [ProducesResponseType(201, Type = typeof(int))]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Create([FromBody] DisplayOptionCategoryDTO displayOptionCategoryDTO)
    {
        ResponseDTO<DataDispOptCatDTO<int>> response = new ResponseDTO<DataDispOptCatDTO<int>>();
        DataDispOptCatDTO<int> datos = new DataDispOptCatDTO<int>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (displayOptionCategoryDTO == null)
        {
            error.message = "Parameter cannot be null";
            error.innerException = "Parameter cannot be null";

            response.success = false;
            response.error = error;
            response.data = datos;
            return BadRequest(response);
        }

        if (!ModelState.IsValid)
        {
            error.message = "Invalid Data Model";
            error.innerException = "Invalid Data Model";

            response.success = false;
            response.error = error;
            response.data = datos;
            return BadRequest(response);
        }

        try
        {
            datos.DisplayOptionCategories = await _displayOptionCategoryRepository.AddAsync(displayOptionCategoryDTO);

            if (datos.DisplayOptionCategories > 0)
            {
                response.success = true;
                response.error = error;
                response.data = datos;

                return CreatedAtRoute(
                        routeName: nameof(Create),
                        routeValues: new { id = datos.DisplayOptionCategories.ToString() },
                        value: response);
            }

            error.message = "Could not Save Data";
            error.innerException = "Could not Save Data";

            response.success = false;
            response.error = error;
            response.data = datos;
            return BadRequest(response);

        }
        catch (Exception ex)
        {
            error.message = ex.Message;
            error.innerException = ex.InnerException?.Message;

            response.success = false;
            response.error = error;
            response.data = datos;
            return BadRequest(response);
        }
    }

    /// <summary>
    /// This endpoint is for the update of a display option category, you can update one display option category at a time.
    /// </summary>
    /// <param name="displayOptionCategoryDTO">display option category to update</param>
    /// <returns>Do not return display option category only http code 204</returns>
    [HttpPut("Update", Name = nameof(Update))]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Update([FromBody] DisplayOptionCategoryDTO displayOptionCategoryDTO)
    {
        ResponseDTO<bool> response = new ResponseDTO<bool>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (displayOptionCategoryDTO == null)
        {
            error.message = "Parameter cannot be null";
            error.innerException = "Parameter cannot be null";

            response.success = false;
            response.error = error;
            response.data = false;

            return BadRequest(response);
        }

        if (!ModelState.IsValid)
        {
            error.message = "Invalid Data Model";
            error.innerException = "Invalid Data Model";

            response.success = false;
            response.error = error;
            response.data = false;

            return BadRequest(response);
        }

        try
        {
            bool result = await _displayOptionCategoryRepository.UpdateAsync(displayOptionCategoryDTO);

            if (result)
            {
                return NoContent();
            }

            response.success = false;
            response.error = error;
            response.data = false;

            return NotFound(response);
        }
        catch (Exception ex)
        {
            error.message = ex.Message;
            error.innerException = ex.InnerException?.Message;

            response.success = false;
            response.error = error;
            response.data = false;

            return BadRequest(response);
        }
    }

    /// <summary>
    /// This endpoint is for the logically delete a display option category, you can delete one content display option at a time.
    /// </summary>
    /// <param name="displayOptionCategoryId"> Id of the display option category to delete, this value is int</param>
    /// <returns>No content display option only http code 204</returns>
    [HttpDelete("Delete/{contentDisplayOptionId}", Name = nameof(Delete))]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Delete(int displayOptionCategoryId)
    {
        ResponseDTO<bool> response = new ResponseDTO<bool>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (displayOptionCategoryId <= 0)
        {
            error.message = "Parameter cannot be less than zero";
            error.innerException = "Parameter cannot be less than zero";

            response.success = false;
            response.error = error;
            response.data = false;

            return BadRequest(response);
        }

        try
        {
            bool result = await _displayOptionCategoryRepository.RemoveAsync(displayOptionCategoryId);

            if (result)
            {
                return NoContent();
            }

            response.success = false;
            response.error = null;
            response.data = false;

            return NotFound(response);
        }
        catch (Exception ex)
        {
            error.message = ex.Message;
            error.innerException = ex.InnerException?.Message;

            response.success = false;
            response.error = error;
            response.data = false;

            return BadRequest(response);
        }
    }
}
