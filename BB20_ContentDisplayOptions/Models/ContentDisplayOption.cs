using System;
using System.Collections.Generic;

namespace BB20_ContentDisplayOptions.Models
{
    public partial class ContentDisplayOption
    {
        public ContentDisplayOption()
        {
            DisplayOptionCategories = new HashSet<DisplayOptionCategory>();
        }

        /// <summary>
        /// ID of the table
        /// </summary>
        public int ContentDisplayOptionId { get; set; }
        /// <summary>
        /// ID of the table content
        /// </summary>
        public int ContentId { get; set; }
        /// <summary>
        /// Display options if comments are displayed
        /// </summary>
        public bool DoshowComment { get; set; }
        /// <summary>
        /// Display options if new comments can be made
        /// </summary>
        public bool DonewComments { get; set; }
        /// <summary>
        /// Hide Item
        /// </summary>
        public bool DohideItem { get; set; }
        /// <summary>
        /// Display Item
        /// </summary>
        public bool DodisplayItem { get; set; }
        /// <summary>
        /// Display Item Within Date Range
        /// </summary>
        public bool DodisplayItemWdtRng { get; set; }
        /// <summary>
        /// Not Featured (Home Page)
        /// </summary>
        public bool DohomeNotFeatured { get; set; }
        /// <summary>
        /// Feature Item (Home Page)
        /// </summary>
        public bool DohomeFeatureItem { get; set; }
        /// <summary>
        /// Feature Item Within Date Range (Home Page)
        /// </summary>
        public bool DohomeFeatureItemWdtRng { get; set; }
        /// <summary>
        /// Not Featured (Landing Page)
        /// </summary>
        public bool DolandingNotFeatured { get; set; }
        /// <summary>
        /// Feature Item (Landing Page)
        /// </summary>
        public bool DolandingFeatureItem { get; set; }
        /// <summary>
        /// Feature Item Within Date Range (Landing Page)
        /// </summary>
        public bool DolandingFeatureItemWdtRng { get; set; }
        /// <summary>
        /// UnlockedPost
        /// </summary>
        public bool UnlockedPost { get; set; }
        /// <summary>
        /// Enable ML5 Search
        /// </summary>
        public bool EnableMl5search { get; set; }
        /// <summary>
        /// Package Template
        /// </summary>
        public bool PackageTemplate { get; set; }
        /// <summary>
        /// Post Type =&gt; 0-Template, 1-Page, 2-Static Document, 3-External URL
        /// </summary>
        public int? PostType { get; set; }
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

        public virtual ICollection<DisplayOptionCategory> DisplayOptionCategories { get; set; }
    }
}
