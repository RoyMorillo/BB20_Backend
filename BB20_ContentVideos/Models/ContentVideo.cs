using System;
using System.Collections.Generic;

namespace BB20_ContentVideos.Models
{
    public partial class ContentVideo
    {
        /// <summary>
        /// ID of the table
        /// </summary>
        public int ContentVideoId { get; set; }
        /// <summary>
        /// ID of the content table
        /// </summary>
        public int ContentId { get; set; }
        /// <summary>
        /// Video file
        /// </summary>
        public string Videofiles { get; set; }
        /// <summary>
        /// Video Width
        /// </summary>
        public int? Videowidth { get; set; }
        /// <summary>
        /// Video height
        /// </summary>
        public int? Videoheight { get; set; }
        /// <summary>
        /// If the video should self-start
        /// </summary>
        public bool Videoautostart { get; set; }
        /// <summary>
        /// If the video should be repeated
        /// </summary>
        public bool Videoloop { get; set; }
        /// <summary>
        /// Video image
        /// </summary>
        public string Videoicon { get; set; }
        /// <summary>
        /// Video caption
        /// </summary>
        public string Videocaption { get; set; }
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
