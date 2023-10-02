using Microsoft.AspNetCore.Mvc;
using BB20_SubCategories.Models.DTOs;
using BB20_SubCategories.Repository.Contracts;
using BB20_SubCategories.Repository.Services;

namespace BB20_SubCategories.Controllers.v1;

/// <summary>
/// CRUD Operations on category table in database.
/// </summary>
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class SubCategoryThumbNailController : ControllerBase
{
    private readonly ISubCategoryThumbNailRepository _subCategoryTNRepository;

    public SubCategoryThumbNailController(ISubCategoryThumbNailRepository subCategoryTNRepository)
    {
        _subCategoryTNRepository = subCategoryTNRepository;
    }

    /// <summary>
    /// Get a list sub category thumb nail by its Category ID
    /// </summary>
    /// <returns>sub category thumb nail list info</returns>
    [HttpGet("GetDataBySubCategoryId/{categoryId}", Name = nameof(GetDataBySubCategoryId))]
    [ProducesResponseType(200, Type = typeof(ResponseDTO<DataThumbDTO<List<SubCategoryThumbNailDTO>>>))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetDataBySubCategoryId(int subCategoryId)
    {
        ResponseDTO<DataThumbDTO<List<SubCategoryThumbNailDTO>>> response = new ResponseDTO<DataThumbDTO<List<SubCategoryThumbNailDTO>>>();
        DataThumbDTO<List<SubCategoryThumbNailDTO>> data = new DataThumbDTO<List<SubCategoryThumbNailDTO>>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        try
        {
            data.SubCategoryThumbNails = await _subCategoryTNRepository.GetDataBySubCategoryId(subCategoryId);

            if (data.SubCategoryThumbNails != null)
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
    /// This endpoint is for the creation of a subcategory thumb nail, you can create one subcategory thumb nail at a time.
    /// </summary>
    /// <param name="subCategoryThumbNailDTO">subcategory thumb nail you want to create</param>
    /// <returns>One recored with the subcategory thumb nail created and its Id.</returns>
    [HttpPost("Create", Name = nameof(Create))]
    [ProducesResponseType(201, Type = typeof(int))]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Create([FromBody] SubCategoryThumbNailDTO subCategoryThumbNailDTO)
    {
        ResponseDTO<DataThumbDTO<int>> response = new ResponseDTO<DataThumbDTO<int>>();
        DataThumbDTO<int> datos = new DataThumbDTO<int>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (subCategoryThumbNailDTO == null)
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
            datos.SubCategoryThumbNails = await _subCategoryTNRepository.AddAsync(subCategoryThumbNailDTO);

            if (datos.SubCategoryThumbNails > 0)
            {
                response.success = true;
                response.error = error;
                response.data = datos;

                return CreatedAtRoute(
                        routeName: nameof(Create),
                        routeValues: new { id = datos.SubCategoryThumbNails.ToString() },
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
    /// This endpoint is for the update of a subcategory thumb nail, you can update one subcategory thumb nail at a time.
    /// </summary>
    /// <param name="subCategoryThumbNailDTO">subcategory thumb nail to update</param>
    /// <returns>Do not return subcategory thumb nail only http code 204</returns>
    [HttpPut("Update", Name = nameof(Update))]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Update([FromBody] SubCategoryThumbNailDTO subCategoryThumbNailDTO)
    {
        ResponseDTO<bool> response = new ResponseDTO<bool>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (subCategoryThumbNailDTO == null)
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
            bool result = await _subCategoryTNRepository.UpdateAsync(subCategoryThumbNailDTO);

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
    /// This endpoint is for the logically delete a subcategory thumb nail, you can delete one subcategory thumb nail at a time.
    /// </summary>
    /// <param name="SubcategoryTNID"> Id of the subcategory thumb nail to delete, this value is int</param>
    /// <returns>No subcategory only http code 204</returns>
    [HttpDelete("Delete/{subCategoryId}", Name = nameof(Delete))]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Delete(int SubcategoryTNID)
    {
        ResponseDTO<bool> response = new ResponseDTO<bool>();

        ErrorDTO error = new()
        {
            innerException = string.Empty,
            message = string.Empty
        };

        if (SubcategoryTNID <= 0)
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
            bool result = await _subCategoryTNRepository.RemoveAsync(SubcategoryTNID);

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
