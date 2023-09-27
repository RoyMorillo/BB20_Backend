namespace BB20_Content.Models.DTOs;

public class ContentDTO
{
    /// <summary>
    /// ID of the content
    /// </summary>
    public int ContentId { get; set; }
    /// <summary>
    /// Name of Content
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// ontent PrettyURL
    /// </summary>
    public string PrettyUrl { get; set; }
    /// <summary>
    /// Subtittle of content
    /// </summary>
    public string Subtittle { get; set; }
    /// <summary>
    /// Status of the category (display = 0 or hidden = 1)
    /// </summary>
    public int DisplayStatus { get; set; }
    /// <summary>
    /// Headline of content
    /// </summary>
    public string Headline { get; set; }
    /// <summary>
    /// Author of content
    /// </summary>
    public string Author { get; set; }
    /// <summary>
    /// DateTime of the creation of the content
    /// </summary>
    public DateTime? DocumentDate { get; set; }
    /// <summary>
    /// Long Teaser of Content
    /// </summary>
    public string Teaser { get; set; }
    /// <summary>
    /// Teaser thumbnail icon
    /// </summary>
    public string Stticon { get; set; }
    /// <summary>
    /// Teaser thumbnail if only use on home page (0=yes and 1=no)
    /// </summary>
    public bool SttonlyHomePage { get; set; }
    /// <summary>
    /// Teaser thumbnail title
    /// </summary>
    public string Stttitle { get; set; }
    /// <summary>
    /// Teaser thumbnail Botton text
    /// </summary>
    public string SttbuttonText { get; set; }
    /// <summary>
    /// Teaser thumbnail Botton Link
    /// </summary>
    public string SttbuttonLink { get; set; }
    /// <summary>
    /// Main text description of content
    /// </summary>
    public string MainText { get; set; }
    /// <summary>
    /// meta text description of content
    /// </summary>
    public string MetaDescription { get; set; }
    /// <summary>
    /// Content Icon 
    /// </summary>
    public string Icon { get; set; }
    /// <summary>
    /// URL of Content files
    /// </summary>
    public string LinkUrl1 { get; set; }
    /// <summary>
    /// URL of Content files
    /// </summary>
    public string LinkUrl2 { get; set; }
    /// <summary>
    /// URL of Content files
    /// </summary>
    public string LinkUrl3 { get; set; }
    /// <summary>
    /// Link of Content files
    /// </summary>
    public string LinkTittle1 { get; set; }
    /// <summary>
    /// Link of Content files
    /// </summary>
    public string LinkTittle2 { get; set; }
    /// <summary>
    /// Link of Content files
    /// </summary>
    public string LinkTittle3 { get; set; }
    /// <summary>
    /// Open in New Windows
    /// </summary>
    public bool OpenNewWindows { get; set; }
    /// <summary>
    /// Share
    /// </summary>
    public bool Share { get; set; }
    public string SelectImage1 { get; set; }
    public string SelectImage2 { get; set; }
    /// <summary>
    /// Span Image Across
    /// </summary>
    public bool SpanImageAcross { get; set; }
    /// <summary>
    /// Align Left, if 1 = true, 0 = false then is align right
    /// </summary>
    public bool? AlignLeft { get; set; }
    /// <summary>
    /// Wrap Text Around Images
    /// </summary>
    public bool WrapTextAroundImages { get; set; }
    /// <summary>
    /// App notifications Section =&gt; 0-On, 1-Off, 2-High Priority
    /// </summary>
    public int Ansnotification { get; set; }
    /// <summary>
    /// DateTime of the creation of the row
    /// </summary>
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
