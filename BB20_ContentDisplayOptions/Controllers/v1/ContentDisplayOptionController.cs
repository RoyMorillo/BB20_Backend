using BB20_ContentDisplayOptions.Repository.Contracts;
using BB20_ContentDisplayOptions.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using BB20_SubCategories.Models.DTOs;

namespace BB20_ContentDisplayOptions.Controllers.v1;

/// <summary>
/// CRUD Operations on content display option table in database.
/// </summary>
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class ContentDisplayOptionController : ControllerBase
{
    private readonly IContentDisplayOptionRepository _contentDisplayOptionRepository;

    public ContentDisplayOptionController(IContentDisplayOptionRepository contentDisplayOptionRepository)
    {
        _contentDisplayOptionRepository = contentDisplayOptionRepository;
    }

    /// <summary>
    /// Get all content display option only
    /// </summary>
    /// <returns>List of content display option only</returns>
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDispOptDTO<List<ContentDisplayOptionDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [Route("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        ResponseDTO<DataDispOptDTO<List<ContentDisplayOptionDTO>>> response = new ResponseDTO<DataDispOptDTO<List<ContentDisplayOptionDTO>>>();
        DataDispOptDTO<List<ContentDisplayOptionDTO>> data = new DataDispOptDTO<List<ContentDisplayOptionDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.DisplayOptions = await _contentDisplayOptionRepository.GetAll();

            if (data.DisplayOptions.Count > 0)
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
    /// Get a content display option by its ID
    /// </summary>
    /// <returns>content display option info</returns>
    [HttpGet("GetDataById/{contentDisplayOptionId}", Name = nameof(GetDataById))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDispOptDTO<ContentDisplayOptionDTO>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetDataById(int contentDisplayOptionId)
    {
        ResponseDTO<DataDispOptDTO<ContentDisplayOptionDTO>> response = new ResponseDTO<DataDispOptDTO<ContentDisplayOptionDTO>>();
        DataDispOptDTO<ContentDisplayOptionDTO> data = new DataDispOptDTO<ContentDisplayOptionDTO>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.DisplayOptions = await _contentDisplayOptionRepository.GetDataById(contentDisplayOptionId);

            if (data.DisplayOptions != null)
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
    /// Get a content display option by its content ID
    /// </summary>
    /// <returns>content display option info</returns>
    [HttpGet("GetDataByContentId/{contentId}", Name = nameof(GetDataByContentId))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDispOptDTO<List<ContentDisplayOptionDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetDataByContentId(int contentId)
    {
        ResponseDTO<DataDispOptDTO<List<ContentDisplayOptionDTO>>> response = new ResponseDTO<DataDispOptDTO<List<ContentDisplayOptionDTO>>>();
        DataDispOptDTO<List<ContentDisplayOptionDTO>> data = new DataDispOptDTO<List<ContentDisplayOptionDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.DisplayOptions = await _contentDisplayOptionRepository.GetDataByContentId(contentId);

            if (data.DisplayOptions != null)
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
    /// This endpoint is for the creation of a content display option, you can create one content display option at a time.
    /// </summary>
    /// <param name="contentDisplayOptionDTO">content display option you want to create</param>
    /// <returns>One recored with the content display option created and its Id.</returns>
    [HttpPost("Create", Name = nameof(Create))]
    [ProducesResponseType(201, Type = typeof(int))]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Create([FromBody] ContentDisplayOptionDTO contentDisplayOptionDTO)
    {
        ResponseDTO<DataDispOptDTO<int>> response = new ResponseDTO<DataDispOptDTO<int>>();
        DataDispOptDTO<int> datos = new DataDispOptDTO<int>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (contentDisplayOptionDTO == null)
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
            datos.DisplayOptions = await _contentDisplayOptionRepository.AddAsync(contentDisplayOptionDTO);

            if (datos.DisplayOptions > 0)
            {
                response.success = true;
                response.error = error;
                response.data = datos;

                return CreatedAtRoute(
                        routeName: nameof(Create),
                        routeValues: new { id = datos.DisplayOptions.ToString() },
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
    /// This endpoint is for the update of a content display option, you can update one content display option at a time.
    /// </summary>
    /// <param name="contentDisplayOptionDTO">content display option to update</param>
    /// <returns>Do not return content display option only http code 204</returns>
    [HttpPut("Update", Name = nameof(Update))]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Update([FromBody] ContentDisplayOptionDTO contentDisplayOptionDTO)
    {
        ResponseDTO<bool> response = new ResponseDTO<bool>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (contentDisplayOptionDTO == null)
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
            bool result = await _contentDisplayOptionRepository.UpdateAsync(contentDisplayOptionDTO);

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
    /// This endpoint is for the logically delete a content display option, you can delete one content display option at a time.
    /// </summary>
    /// <param name="contentDisplayOptionId"> Id of the content display option to delete, this value is int</param>
    /// <returns>No content display option only http code 204</returns>
    [HttpDelete("Delete/{contentDisplayOptionId}", Name = nameof(Delete))]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Delete(int contentDisplayOptionId)
    {
        ResponseDTO<bool> response = new ResponseDTO<bool>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (contentDisplayOptionId <= 0)
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
            bool result = await _contentDisplayOptionRepository.RemoveAsync(contentDisplayOptionId);

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
