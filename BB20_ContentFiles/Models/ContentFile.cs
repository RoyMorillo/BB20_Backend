using System;
using System.Collections.Generic;

namespace BB20_ContentFiles.Models
{
    public partial class ContentFile
    {
        /// <summary>
        /// ID of the table
        /// </summary>
        public int ContentFileId { get; set; }
        /// <summary>
        /// ID of the content Table
        /// </summary>
        public int ContentId { get; set; }
        /// <summary>
        /// es tipo archivo .zip, pdf, doc
        /// </summary>
        public string AssociatedFiles { get; set; }
        /// <summary>
        /// if the terms are displayed
        /// </summary>
        public bool ShowTerms { get; set; }
        /// <summary>
        /// Title of Content files
        /// </summary>
        public string AssociatedFileTitle { get; set; }
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
    }
}
