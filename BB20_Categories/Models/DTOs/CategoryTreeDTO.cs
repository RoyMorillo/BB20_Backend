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
    public string Name { get; set; }
    /// <summary>
    /// Status of the category (display = 0 or hidden = 1)
    /// </summary>
    public int DisplayStatus { get; set; }
    /// <summary>
    /// DateTime of the creation of the row
    /// </summary>
    public DateTime CreatedDate { get; set; }
    /// <summary>
    /// DateTime of the update of the row
    /// </summary>
    public DateTime UpdatedDate { get; set; }
    /// <summary>
    /// If the row is logicaly deleted (0 = false and 1 = true)
    /// </summary>
    public bool DeleteFlag { get; set; }
    /// <summary>
    /// This field is for the management of the concurrency
    /// </summary>
    public byte[] RowVersion { get; set; }
    public List<SubCategoryTreeDTO> SubCategories { get; set; }
}
