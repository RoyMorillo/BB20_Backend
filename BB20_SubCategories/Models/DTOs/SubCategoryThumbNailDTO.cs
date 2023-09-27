namespace BB20_SubCategories.Models.DTOs;

public class SubCategoryThumbNailDTO
{
    /// <summary>
    /// Id of the sub category thumb nail
    /// </summary>
    public int ThumbNailId { get; set; }
    /// <summary>
    /// ID of the sub category it belongs
    /// </summary>
    public int SubCategoryId { get; set; }
    /// <summary>
    /// Image
    /// </summary>
    public string? Image { get; set; }

    public virtual SubCategory SubCategory { get; set; } = null!;
}
