using System;
using System.Collections.Generic;

namespace BB20_InteriorCategories.Models
{
    public partial class InteriorCategory
    {
        public int InteriorCategoryId { get; set; }
        /// <summary>
        /// ID of the category it belongs
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// ID of the sub category this interior category belongs to
        /// </summary>
        public int SubCategoryId { get; set; }
        /// <summary>
        /// Name of the interior category
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Status of the interior category (display = 0 or hidden = 1)
        /// </summary>
        public int DisplayStatus { get; set; }
        /// <summary>
        /// Interior Category Icon
        /// </summary>
        public string? Icon { get; set; }
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
        public byte[]? RowVersion { get; set; }
    }
}
