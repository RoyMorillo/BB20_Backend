using System;
using System.Collections.Generic;

namespace BB20_ContentDisplayOptions.Models
{
    public partial class DisplayOptionCategory
    {
        /// <summary>
        /// Id of the table
        /// </summary>
        public int ContentDisplayOptionCategoryId { get; set; }
        /// <summary>
        /// ID of the table Content Display Option
        /// </summary>
        public int ContentDisplayOptionId { get; set; }
        /// <summary>
        /// ID of the category table
        /// </summary>
        public int? CategoryId { get; set; }
        /// <summary>
        /// ID of the sub category table
        /// </summary>
        public int? SubCategoryId { get; set; }
        /// <summary>
        /// ID of the interior category table
        /// </summary>
        public int? InteriorCategoryId { get; set; }
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

        public virtual ContentDisplayOption ContentDisplayOption { get; set; }
    }
}
