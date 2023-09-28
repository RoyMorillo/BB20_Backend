using BB20_ContentFiles.Models.DTOs;
using BB20_ContentFiles.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BB20_ContentFiles.Controllers.v1;

/// <summary>
/// CRUD Operations on content file table in database.
/// </summary>
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class ContentFileController : ControllerBase
{
    private readonly IContentFileRepository _contentFileRepository;

    public ContentFileController(IContentFileRepository contentFileRepository)
    {
        _contentFileRepository = contentFileRepository;
    }

    /// <summary>
    /// Get all content file only
    /// </summary>
    /// <returns>List of content file only</returns>
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<List<ContentFileDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [Route("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        ResponseDTO<DataDTO<List<ContentFileDTO>>> response = new ResponseDTO<DataDTO<List<ContentFileDTO>>>();
        DataDTO<List<ContentFileDTO>> data = new DataDTO<List<ContentFileDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.ContentFiles = await _contentFileRepository.GetAll();

            if (data.ContentFiles.Count > 0)
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
    /// Get a content file by its ID
    /// </summary>
    /// <returns>content file info</returns>
    [HttpGet("GetDataById/{contentFileId}", Name = nameof(GetDataById))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<ContentFileDTO>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetDataById(int contentFileId)
    {
        ResponseDTO<DataDTO<ContentFileDTO>> response = new ResponseDTO<DataDTO<ContentFileDTO>>();
        DataDTO<ContentFileDTO> data = new DataDTO<ContentFileDTO>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.ContentFiles = await _contentFileRepository.GetDataById(contentFileId);

            if (data.ContentFiles != null)
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
    /// Get a content file by its content ID
    /// </summary>
    /// <returns>content file info</returns>
    [HttpGet("GetAllByContentId/{contentId}", Name = nameof(GetAllByContentId))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<List<ContentFileDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetAllByContentId(int contentId)
    {
        ResponseDTO<DataDTO<List<ContentFileDTO>>> response = new ResponseDTO<DataDTO<List<ContentFileDTO>>>();
        DataDTO<List<ContentFileDTO>> data = new DataDTO<List<ContentFileDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.ContentFiles = await _contentFileRepository.GetAllByContentId(contentId);

            if (data.ContentFiles != null)
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
    /// This endpoint is for the creation of a content file, you can create one content file at a time.
    /// </summary>
    /// <param name="contentFileDTO">content file you want to create</param>
    /// <returns>One recored with the content file created and its Id.</returns>
    [HttpPost("Create", Name = nameof(Create))]
    [ProducesResponseType(201, Type = typeof(int))]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Create([FromBody] ContentFileDTO contentFileDTO)
    {
        ResponseDTO<DataDTO<int>> response = new ResponseDTO<DataDTO<int>>();
        DataDTO<int> datos = new DataDTO<int>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (contentFileDTO == null)
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
            datos.ContentFiles = await _contentFileRepository.AddAsync(contentFileDTO);

            if (datos.ContentFiles > 0)
            {
                response.success = true;
                response.error = error;
                response.data = datos;

                return CreatedAtRoute(
                        routeName: nameof(Create),
                        routeValues: new { id = datos.ContentFiles.ToString() },
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
    /// This endpoint is for the update of a content file, you can update one content file at a time.
    /// </summary>
    /// <param name="contentFileDTO">content file to update</param>
    /// <returns>Do not return content file only http code 204</returns>
    [HttpPut("Update", Name = nameof(Update))]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Update([FromBody] ContentFileDTO contentFileDTO)
    {
        ResponseDTO<bool> response = new ResponseDTO<bool>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (contentFileDTO == null)
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
            bool result = await _contentFileRepository.UpdateAsync(contentFileDTO);

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
    /// This endpoint is for the logically delete a content file, you can delete one content file at a time.
    /// </summary>
    /// <param name="contentFileId"> Id of the content file to delete, this value is uuid</param>
    /// <returns>No content file only http code 204</returns>
    [HttpDelete("Delete/{contentFileId}", Name = nameof(Delete))]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Delete(int contentFileId)
    {
        ResponseDTO<bool> response = new ResponseDTO<bool>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (contentFileId <= 0)
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
            bool result = await _contentFileRepository.RemoveAsync(contentFileId);

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
