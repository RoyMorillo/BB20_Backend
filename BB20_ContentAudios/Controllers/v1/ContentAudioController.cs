using Microsoft.AspNetCore.Mvc;
using BB20_ContentAudios.Repository.Contracts;
using BB20_ContentAudios.Models.DTOs;

namespace BB20_ContentAudios.Controllers.v1;

/// <summary>
/// CRUD Operations on content audio table in database.
/// </summary>
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class ContentAudioController : ControllerBase
{
    private readonly IContentAudioRepository _contentAudioRepository;

    public ContentAudioController(IContentAudioRepository contentAudioRepository)
    {
        _contentAudioRepository = contentAudioRepository;
    }

    /// <summary>
    /// Get all content audio only
    /// </summary>
    /// <returns>List of content audio only</returns>
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<List<ContentAudioDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [Route("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        ResponseDTO<DataDTO<List<ContentAudioDTO>>> response = new ResponseDTO<DataDTO<List<ContentAudioDTO>>>();
        DataDTO<List<ContentAudioDTO>> data = new DataDTO<List<ContentAudioDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.ContentAudios = await _contentAudioRepository.GetAll();

            if (data.ContentAudios.Count > 0)
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
    /// Get a content audio by its ID
    /// </summary>
    /// <returns>content audio info</returns>
    [HttpGet("GetDataById/{contentAudioId}", Name = nameof(GetDataById))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<ContentAudioDTO>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetDataById(int contentAudioId)
    {
        ResponseDTO<DataDTO<ContentAudioDTO>> response = new ResponseDTO<DataDTO<ContentAudioDTO>>();
        DataDTO<ContentAudioDTO> data = new DataDTO<ContentAudioDTO>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.ContentAudios = await _contentAudioRepository.GetDataById(contentAudioId);

            if (data.ContentAudios != null)
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
    /// Get a content audio by its content ID
    /// </summary>
    /// <returns>content audio info</returns>
    [HttpGet("GetAllByContentId/{contentId}", Name = nameof(GetAllByContentId))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<List<ContentAudioDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetAllByContentId(int contentId)
    {
        ResponseDTO<DataDTO<List<ContentAudioDTO>>> response = new ResponseDTO<DataDTO<List<ContentAudioDTO>>>();
        DataDTO<List<ContentAudioDTO>> data = new DataDTO<List<ContentAudioDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.ContentAudios = await _contentAudioRepository.GetAllByContentId(contentId);

            if (data.ContentAudios != null)
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
    /// This endpoint is for the creation of a content audio, you can create one content audio at a time.
    /// </summary>
    /// <param name="contentAudioDTO">content audio you want to create</param>
    /// <returns>One recored with the content audio created and its Id.</returns>
    [HttpPost("Create", Name = nameof(Create))]
    [ProducesResponseType(201, Type = typeof(int))]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Create([FromBody] ContentAudioDTO contentAudioDTO)
    {
        ResponseDTO<DataDTO<int>> response = new ResponseDTO<DataDTO<int>>();
        DataDTO<int> datos = new DataDTO<int>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (contentAudioDTO == null)
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
            datos.ContentAudios = await _contentAudioRepository.AddAsync(contentAudioDTO);

            if (datos.ContentAudios > 0)
            {
                response.success = true;
                response.error = error;
                response.data = datos;

                return CreatedAtRoute(
                        routeName: nameof(Create),
                        routeValues: new { id = datos.ContentAudios.ToString() },
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
    /// This endpoint is for the update of a content audio, you can update one content audio at a time.
    /// </summary>
    /// <param name="contentAudioDTO">content audio to update</param>
    /// <returns>Do not return content audio only http code 204</returns>
    [HttpPut("Update", Name = nameof(Update))]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Update([FromBody] ContentAudioDTO contentAudioDTO)
    {
        ResponseDTO<bool> response = new ResponseDTO<bool>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (contentAudioDTO == null)
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
            bool result = await _contentAudioRepository.UpdateAsync(contentAudioDTO);

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
    /// This endpoint is for the logically delete a content audio, you can delete one content audio at a time.
    /// </summary>
    /// <param name="contentAudioId"> Id of the content audio to delete, this value is uuid</param>
    /// <returns>No content audio only http code 204</returns>
    [HttpDelete("Delete/{contentAudioId}", Name = nameof(Delete))]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Delete(int contentAudioId)
    {
        ResponseDTO<bool> response = new ResponseDTO<bool>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (contentAudioId <= 0)
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
            bool result = await _contentAudioRepository.RemoveAsync(contentAudioId);

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
