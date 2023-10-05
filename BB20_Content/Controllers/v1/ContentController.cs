using BB20_Content.Authorization;
using BB20_Content.Models.DTOs;
using BB20_Content.Repository.Contracts;
using BB20_Content.SecurityModels.Enum;
using Microsoft.AspNetCore.Mvc;

namespace BB20_Content.Controllers.v1;

/// <summary>
/// CRUD Operations on content table in database.
/// </summary>
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class ContentController : ControllerBase
{
    private readonly IContentRepository _contentRepository;

    public ContentController(IContentRepository contentRepository)
    {
        _contentRepository = contentRepository;
    }

    /// <summary>
    /// Get all content only
    /// </summary>
    /// <returns>List of content only</returns>
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<List<ContentDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [Route("GetAll")]
    [Authorize(Role.Admin, Role.User)]
    public async Task<IActionResult> GetAll()
    {
        ResponseDTO<DataDTO<List<ContentDTO>>> response = new ResponseDTO<DataDTO<List<ContentDTO>>>();
        DataDTO<List<ContentDTO>> data = new DataDTO<List<ContentDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.Contents = await _contentRepository.GetAll();

            if (data.Contents.Count > 0)
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
    /// Get a content by its ID
    /// </summary>
    /// <returns>content info</returns>
    [HttpGet("GetDataById/{contentId}", Name = nameof(GetDataById))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<ContentDTO>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [Authorize(Role.Admin, Role.User)]
    public async Task<IActionResult> GetDataById(int contentId)
    {
        ResponseDTO<DataDTO<ContentDTO>> response = new ResponseDTO<DataDTO<ContentDTO>>();
        DataDTO<ContentDTO> data = new DataDTO<ContentDTO>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.Contents = await _contentRepository.GetDataById(contentId);

            if (data.Contents != null)
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
    /// Get a content by its title
    /// </summary>
    /// <returns>content list info</returns>
    [HttpGet("GetAllByTitle/{title}", Name = nameof(GetAllByTitle))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<List<ContentDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [Authorize(Role.Admin, Role.User)]
    public async Task<IActionResult> GetAllByTitle(string title)
    {
        ResponseDTO<DataDTO<List<ContentDTO>>> response = new ResponseDTO<DataDTO<List<ContentDTO>>>();
        DataDTO<List<ContentDTO>> data = new DataDTO<List<ContentDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.Contents = await _contentRepository.GetAllByTitle(title);

            if (data.Contents.Count > 0)
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
    /// Get the list of all contents available and ready for dropdown in the front end
    /// </summary>
    /// <returns>Return Code and Description of the contents</returns>
    [HttpGet("GetForDropDown", Name = nameof(GetForDropDown))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<List<DropDownDTO>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [Authorize(Role.Admin, Role.User)]
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
            dropDown = await _contentRepository.GetAllForDropDown();

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

    /// <summary>
    /// This endpoint is for the creation of a content, you can create one content at a time.
    /// </summary>
    /// <param name="contentDTO">content you want to create</param>
    /// <returns>One recored with the content created and its Id.</returns>
    [HttpPost("Create", Name = nameof(Create))]
    [ProducesResponseType(201, Type = typeof(int))]
    [ProducesResponseType(400)]
    [Authorize(Role.Admin)]
    public async Task<IActionResult> Create([FromBody] ContentDTO contentDTO)
    {
        ResponseDTO<DataDTO<int>> response = new ResponseDTO<DataDTO<int>>();
        DataDTO<int> datos = new DataDTO<int>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (contentDTO == null)
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
            datos.Contents = await _contentRepository.AddAsync(contentDTO);

            if (datos.Contents > 0)
            {
                response.success = true;
                response.error = error;
                response.data = datos;

                return CreatedAtRoute(
                        routeName: nameof(Create),
                        routeValues: new { id = datos.Contents.ToString() },
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
    /// This endpoint is for the update of a content, you can update one content at a time.
    /// </summary>
    /// <param name="contentDTO">content to update</param>
    /// <returns>Do not return content only http code 204</returns>
    [HttpPut("Update", Name = nameof(Update))]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [Authorize(Role.Admin)]
    public async Task<IActionResult> Update([FromBody] ContentDTO contentDTO)
    {
        ResponseDTO<bool> response = new ResponseDTO<bool>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (contentDTO == null)
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
            bool result = await _contentRepository.UpdateAsync(contentDTO);

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
    /// This endpoint is for the logically delete a content, you can delete one content at a time.
    /// </summary>
    /// <param name="contentId"> Id of the content to delete, this value is uuid</param>
    /// <returns>No content only http code 204</returns>
    [HttpDelete("Delete/{contentId}", Name = nameof(Delete))]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [Authorize(Role.Admin)]
    public async Task<IActionResult> Delete(int contentId)
    {
        ResponseDTO<bool> response = new ResponseDTO<bool>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (contentId <= 0)
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
            bool result = await _contentRepository.RemoveAsync(contentId);

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