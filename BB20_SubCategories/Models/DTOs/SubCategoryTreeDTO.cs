namespace BB20_SubCategories.Models.DTOs;

public class SubCategoryTreeDTO
{
    /// <summary>
    /// ID of the sub category
    /// </summary>
    public int SubCategoryId { get; set; }
    /// <summary>
    /// ID of the category this sub category belongs to
    /// </summary>
    public int CategoryId { get; set; }
    /// <summary>
    /// Name of the sub category
    /// </summary>
    public string Name { get; set; } = null!;
    /// <summary>
    /// Status of the sub category (display = 0 or hidden = 1)
    /// </summary>
    public int DisplayStatus { get; set; }
    /// <summary>
    /// Feature In header and footer
    /// </summary>
    public bool FtinHeaderAndFooter { get; set; }
    /// <summary>
    /// Feature in the banner icons section
    /// </summary>
    public bool FtinBannerIcon { get; set; }
    /// <summary>
    /// Feature in the titles section
    /// </summary>
    public bool FtinTitle { get; set; }
    /// <summary>
    /// Sub Category Icon
    /// </summary>
    public string? Icon { get; set; }
    /// <summary>
    /// Use external url
    /// </summary>
    public bool UseExternalUrl { get; set; }
    /// <summary>
    /// Main Category landing page description
    /// </summary>
    public string? CategoryLandPageDesc { get; set; }
    /// <summary>
    /// Main Category landing page Headline
    /// </summary>
    public string? CategoryLandPageHead { get; set; }
    /// <summary>
    /// Sub category landing page description
    /// </summary>
    public string? SubCategoryLandPageDesc { get; set; }
    /// <summary>
    /// If the category is in active status (0 = active and 1 = Inactive)
    /// </summary>
    public bool IsActive { get; set; }
    /// <summary>
    /// If the sub category is static
    /// </summary>
    public bool Static { get; set; }
    /// <summary>
    /// Landing page SEO Title
    /// </summary>
    public string? Seotitle { get; set; }
    /// <summary>
    /// Landing page SEO Pretty URL
    /// </summary>
    public string? SeoprettyUrl { get; set; }
    /// <summary>
    /// Landing page SEO Description Metadata
    /// </summary>
    public string? SeodescMetadata { get; set; }

    public List<InteriorCategoryDTO> InteriorCategories { get; set; }
}
