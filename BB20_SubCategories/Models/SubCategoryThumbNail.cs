using System;
using System.Collections.Generic;

namespace BB20_SubCategories.Models
{
    public partial class SubCategoryThumbNail
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

        public virtual SubCategory SubCategory { get; set; } = null!;
    }
}
