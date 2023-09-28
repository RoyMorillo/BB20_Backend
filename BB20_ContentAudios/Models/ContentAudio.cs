using System;
using System.Collections.Generic;

namespace BB20_ContentAudios.Models
{
    public partial class ContentAudio
    {
        /// <summary>
        /// Id of the table
        /// </summary>
        public int ContentAudioId { get; set; }
        /// <summary>
        /// ID of the content table
        /// </summary>
        public int ContentId { get; set; }
        /// <summary>
        /// Audio File
        /// </summary>
        public string Audiofile { get; set; }
        /// <summary>
        /// Audio Artist
        /// </summary>
        public string Audioartist { get; set; }
        /// <summary>
        /// if the audio should be hidden
        /// </summary>
        public bool AudiohideInfo { get; set; }
        /// <summary>
        /// if the audio should auto-start
        /// </summary>
        public bool AudioautoStart { get; set; }
        /// <summary>
        /// if the audio should be repeated
        /// </summary>
        public bool Audioloop { get; set; }
        /// <summary>
        /// if the audio must have animation
        /// </summary>
        public bool Audioanimation { get; set; }
        /// <summary>
        /// initial audio volume
        /// </summary>
        public int? Audiovalume { get; set; }
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
