namespace BB20_Categories.Models.DTOs;

public class CategoryTreeDTO
{
    /// <summary>
    /// ID of the category
    /// </summary>
    public int CategoryId { get; set; }
    /// <summary>
    /// Name of the category
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Status of the category (display = 0 or hidden = 1)
    /// </summary>
    public int DisplayStatus { get; set; }
    public List<SubCategoryTreeDTO> SubCategories { get; set; }
}
