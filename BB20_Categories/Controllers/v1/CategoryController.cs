using Microsoft.AspNetCore.Mvc;

namespace BB20_Categories.Controllers.v1;

/// <summary>
/// CRUD Operations on category table in database.
/// </summary>
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class CategoryController : ControllerBase
{
    /// <summary>
    /// just testing
    /// </summary>
    /// <returns>Correcto</returns>
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(string))]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [Route("Index")]
    public IActionResult Index()
    {
        return Ok("Con Ocelot");
    }
}
