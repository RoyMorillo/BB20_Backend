using Microsoft.AspNetCore.Mvc;
using BB20_ContentVideos.Repository.Contracts;
using BB20_ContentVideos.Models.DTOs;

namespace BB20_ContentVideos.Controllers.v1;

/// <summary>
/// CRUD Operations on content video table in database.
/// </summary>
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class ContentVideoController : ControllerBase
{
    private readonly IContentVideoRepository _contentVideoRepository;

    public ContentVideoController(IContentVideoRepository contentVideoRepository)
    {
        _contentVideoRepository = contentVideoRepository;
    }

    /// <summary>
    /// Get all content video only
    /// </summary>
    /// <returns>List of content video only</returns>
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<List<ContentVideoDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [Route("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        ResponseDTO<DataDTO<List<ContentVideoDTO>>> response = new ResponseDTO<DataDTO<List<ContentVideoDTO>>>();
        DataDTO<List<ContentVideoDTO>> data = new DataDTO<List<ContentVideoDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.ContentVideos = await _contentVideoRepository.GetAll();

            if (data.ContentVideos.Count > 0)
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
    /// Get a content video by its ID
    /// </summary>
    /// <returns>content video info</returns>
    [HttpGet("GetDataById/{contentVideoId}", Name = nameof(GetDataById))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<ContentVideoDTO>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetDataById(int contentVideoId)
    {
        ResponseDTO<DataDTO<ContentVideoDTO>> response = new ResponseDTO<DataDTO<ContentVideoDTO>>();
        DataDTO<ContentVideoDTO> data = new DataDTO<ContentVideoDTO>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.ContentVideos = await _contentVideoRepository.GetDataById(contentVideoId);

            if (data.ContentVideos != null)
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
    /// Get a content video by its content ID
    /// </summary>
    /// <returns>content video info</returns>
    [HttpGet("GetAllByContentId/{contentId}", Name = nameof(GetAllByContentId))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<List<ContentVideoDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetAllByContentId(int contentId)
    {
        ResponseDTO<DataDTO<List<ContentVideoDTO>>> response = new ResponseDTO<DataDTO<List<ContentVideoDTO>>>();
        DataDTO<List<ContentVideoDTO>> data = new DataDTO<List<ContentVideoDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.ContentVideos = await _contentVideoRepository.GetAllByContentId(contentId);

            if (data.ContentVideos != null)
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
    /// This endpoint is for the creation of a content video, you can create one content video at a time.
    /// </summary>
    /// <param name="contentVideoDTO">content video you want to create</param>
    /// <returns>One recored with the content video created and its Id.</returns>
    [HttpPost("Create", Name = nameof(Create))]
    [ProducesResponseType(201, Type = typeof(int))]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Create([FromBody] ContentVideoDTO contentVideoDTO)
    {
        ResponseDTO<DataDTO<int>> response = new ResponseDTO<DataDTO<int>>();
        DataDTO<int> datos = new DataDTO<int>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (contentVideoDTO == null)
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
            datos.ContentVideos = await _contentVideoRepository.AddAsync(contentVideoDTO);

            if (datos.ContentVideos > 0)
            {
                response.success = true;
                response.error = error;
                response.data = datos;

                return CreatedAtRoute(
                        routeName: nameof(Create),
                        routeValues: new { id = datos.ContentVideos.ToString() },
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
    /// This endpoint is for the update of a content video, you can update one content video at a time.
    /// </summary>
    /// <param name="contentVideoDTO">content video to update</param>
    /// <returns>Do not return content video only http code 204</returns>
    [HttpPut("Update", Name = nameof(Update))]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Update([FromBody] ContentVideoDTO contentVideoDTO)
    {
        ResponseDTO<bool> response = new ResponseDTO<bool>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (contentVideoDTO == null)
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
            bool result = await _contentVideoRepository.UpdateAsync(contentVideoDTO);

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
    /// This endpoint is for the logically delete a content video, you can delete one content video at a time.
    /// </summary>
    /// <param name="contentVideoId"> Id of the content video to delete, this value is uuid</param>
    /// <returns>No content video only http code 204</returns>
    [HttpDelete("Delete/{contentVideoId}", Name = nameof(Delete))]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Delete(int contentVideoId)
    {
        ResponseDTO<bool> response = new ResponseDTO<bool>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (contentVideoId <= 0)
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
            bool result = await _contentVideoRepository.RemoveAsync(contentVideoId);

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
