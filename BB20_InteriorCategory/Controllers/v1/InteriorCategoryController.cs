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
    /// Get a list of interior categories by its subCategoryID
    /// </summary>
    /// <returns>interior category info</returns>
    [HttpGet("GetDataBySubCategoryId/{subCategoryId}", Name = nameof(GetDataBySubCategoryId))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataDTO<List<InteriorCategoryDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetDataBySubCategoryId(int subCategoryId)
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
            data.InteriorCategories = await _interiorCategoryRepository.GetDataBySubCategoryId(subCategoryId);

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

    /// <summary>
    /// This endpoint is for the creation of a interior category, you can create one category at a time.
    /// </summary>
    /// <param name="interiorCategoryDTO">interior category you want to create</param>
    /// <returns>One recored with the interior category created and its Id.</returns>
    [HttpPost("Create", Name = nameof(Create))]
    [ProducesResponseType(201, Type = typeof(int))]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Create([FromBody] InteriorCategoryDTO interiorCategoryDTO)
    {
        ResponseDTO<DataDTO<int>> response = new ResponseDTO<DataDTO<int>>();
        DataDTO<int> datos = new DataDTO<int>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (interiorCategoryDTO == null)
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
            datos.InteriorCategories = await _interiorCategoryRepository.AddAsync(interiorCategoryDTO);

            if (datos.InteriorCategories > 0)
            {
                response.success = true;
                response.error = error;
                response.data = datos;

                return CreatedAtRoute(
                        routeName: nameof(Create),
                        routeValues: new { id = datos.InteriorCategories.ToString() },
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
    /// This endpoint is for the update of a interior category, you can update one category at a time.
    /// </summary>
    /// <param name="interiorCategoryDTO">interior category to update</param>
    /// <returns>Do not return interior category only http code 204</returns>
    [HttpPut("Update", Name = nameof(Update))]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Update([FromBody] InteriorCategoryDTO interiorCategoryDTO)
    {
        ResponseDTO<bool> response = new ResponseDTO<bool>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (interiorCategoryDTO == null)
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
            bool result = await _interiorCategoryRepository.UpdateAsync(interiorCategoryDTO);

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
    /// This endpoint is for the logically delete a interior category, you can delete one interior category at a time.
    /// </summary>
    /// <param name="interiorCategoryID"> Id of the interior category to delete, this value is int</param>
    /// <returns>No interior category only http code 204</returns>
    [HttpDelete("Delete/{categoryID}", Name = nameof(Delete))]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Delete(int interiorCategoryID)
    {
        ResponseDTO<bool> response = new ResponseDTO<bool>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (interiorCategoryID <= 0)
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
            bool result = await _interiorCategoryRepository.RemoveAsync(interiorCategoryID);

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
