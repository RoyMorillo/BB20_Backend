using AutoMapper;
using BB20_Content.Models;
using BB20_Content.Models.DTOs;
using BB20_Content.Repository.Contracts;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace BB20_Content.Repository.Services;

public class ContentRepository : IContentRepository
{
    private readonly BB20_ContentContext _context;
    private readonly IMapper _mapper;

    public ContentRepository(BB20_ContentContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<ContentDTO>> GetAll()
    {
        List<Content> contents = await _context.Contents
                                    .Where(x => x.DeleteFlag == false)
                                    .Select(s => new Content
                                    {
                                        ContentId = s.ContentId,
                                        Title = s.Title,
                                        DisplayStatus = s.DisplayStatus,
                                        PrettyUrl = s.PrettyUrl,
                                        Subtittle = s.Subtittle,
                                        Headline = s.Headline,
                                        Author = s.Author,
                                        DocumentDate = s.DocumentDate,
                                        Teaser = s.Teaser,
                                        Stticon = s.Stticon,
                                        SttonlyHomePage = s.SttonlyHomePage,
                                        Stttitle = s.Stttitle,
                                        SttbuttonText = s.SttbuttonText,
                                        SttbuttonLink = s.SttbuttonLink,
                                        MainText = s.MainText,
                                        MetaDescription = s.MetaDescription,
                                        Icon = s.Icon,
                                        LinkUrl1 = s.LinkUrl1,
                                        LinkUrl2 = s.LinkUrl2,
                                        LinkUrl3 = s.LinkUrl3,
                                        LinkTittle1 = s.LinkTittle1,
                                        LinkTittle2 = s.LinkTittle2,
                                        LinkTittle3 = s.LinkTittle3,
                                        OpenNewWindows = s.OpenNewWindows,
                                        Share = s.Share,
                                        SelectImage1 = s.SelectImage1,
                                        SelectImage2 = s.SelectImage2,
                                        SpanImageAcross = s.SpanImageAcross,
                                        AlignLeft = s.AlignLeft,
                                        WrapTextAroundImages = s.WrapTextAroundImages,
                                        Ansnotification = s.Ansnotification
                                    })
                                    .AsNoTracking()
                                    .ToListAsync();

        return _mapper.Map<List<ContentDTO>>(contents);
    }

    public async Task<ContentDTO> GetDataById(int contentId)
    {
        Content content = await _context.Contents
                                    .Where(x => x.DeleteFlag == false && x.ContentId == contentId)
                                    .Select(s => new Content
                                    {
                                        ContentId = s.ContentId,
                                        Title = s.Title,
                                        DisplayStatus = s.DisplayStatus,
                                        PrettyUrl = s.PrettyUrl,
                                        Subtittle = s.Subtittle,
                                        Headline = s.Headline,
                                        Author = s.Author,
                                        DocumentDate = s.DocumentDate,
                                        Teaser = s.Teaser,
                                        Stticon = s.Stticon,
                                        SttonlyHomePage = s.SttonlyHomePage,
                                        Stttitle = s.Stttitle,
                                        SttbuttonText = s.SttbuttonText,
                                        SttbuttonLink = s.SttbuttonLink,
                                        MainText = s.MainText,
                                        MetaDescription = s.MetaDescription,
                                        Icon = s.Icon,
                                        LinkUrl1 = s.LinkUrl1,
                                        LinkUrl2 = s.LinkUrl2,
                                        LinkUrl3 = s.LinkUrl3,
                                        LinkTittle1 = s.LinkTittle1,
                                        LinkTittle2 = s.LinkTittle2,
                                        LinkTittle3 = s.LinkTittle3,
                                        OpenNewWindows = s.OpenNewWindows,
                                        Share = s.Share,
                                        SelectImage1 = s.SelectImage1,
                                        SelectImage2 = s.SelectImage2,
                                        SpanImageAcross = s.SpanImageAcross,
                                        AlignLeft = s.AlignLeft,
                                        WrapTextAroundImages = s.WrapTextAroundImages,
                                        Ansnotification = s.Ansnotification
                                    })
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync();

        return _mapper.Map<ContentDTO>(content);
    }

    public async Task<List<ContentDTO>> GetAllByTitle(string title)
    {
        var predicate = PredicateBuilder.New<Content>();

        predicate = predicate.And(x => x.DeleteFlag.Equals(false));
        predicate = predicate.And(x => x.Title.Contains(title));

        List<Content> contents = await _context.Contents
                            .Where(predicate)
                            .Select(s => new Content
                            {
                                ContentId = s.ContentId,
                                Title = s.Title,
                                DisplayStatus = s.DisplayStatus,
                                PrettyUrl = s.PrettyUrl,
                                Subtittle = s.Subtittle,
                                Headline = s.Headline,
                                Author = s.Author,
                                DocumentDate = s.DocumentDate,
                                Teaser = s.Teaser,
                                Stticon = s.Stticon,
                                SttonlyHomePage = s.SttonlyHomePage,
                                Stttitle = s.Stttitle,
                                SttbuttonText = s.SttbuttonText,
                                SttbuttonLink = s.SttbuttonLink,
                                MainText = s.MainText,
                                MetaDescription = s.MetaDescription,
                                Icon = s.Icon,
                                LinkUrl1 = s.LinkUrl1,
                                LinkUrl2 = s.LinkUrl2,
                                LinkUrl3 = s.LinkUrl3,
                                LinkTittle1 = s.LinkTittle1,
                                LinkTittle2 = s.LinkTittle2,
                                LinkTittle3 = s.LinkTittle3,
                                OpenNewWindows = s.OpenNewWindows,
                                Share = s.Share,
                                SelectImage1 = s.SelectImage1,
                                SelectImage2 = s.SelectImage2,
                                SpanImageAcross = s.SpanImageAcross,
                                AlignLeft = s.AlignLeft,
                                WrapTextAroundImages = s.WrapTextAroundImages,
                                Ansnotification = s.Ansnotification
                            })
                            .AsNoTracking()
                            .ToListAsync();

        return _mapper.Map<List<ContentDTO>>(contents);

    }

    public async Task<List<DropDownDTO>> GetAllForDropDown()
    {
        List<Content> contents = await _context.Contents
                                    .Where(x => x.DeleteFlag == false)
                                    .Select(s => new Content
                                    {
                                        ContentId = s.ContentId,
                                        Title = s.Title,
                                        DisplayStatus = s.DisplayStatus,
                                        PrettyUrl = s.PrettyUrl,
                                        Subtittle = s.Subtittle,
                                        Headline = s.Headline,
                                        Author = s.Author,
                                        DocumentDate = s.DocumentDate,
                                        Teaser = s.Teaser,
                                        Stticon = s.Stticon,
                                        SttonlyHomePage = s.SttonlyHomePage,
                                        Stttitle = s.Stttitle,
                                        SttbuttonText = s.SttbuttonText,
                                        SttbuttonLink = s.SttbuttonLink,
                                        MainText = s.MainText,
                                        MetaDescription = s.MetaDescription,
                                        Icon = s.Icon,
                                        LinkUrl1 = s.LinkUrl1,
                                        LinkUrl2 = s.LinkUrl2,
                                        LinkUrl3 = s.LinkUrl3,
                                        LinkTittle1 = s.LinkTittle1,
                                        LinkTittle2 = s.LinkTittle2,
                                        LinkTittle3 = s.LinkTittle3,
                                        OpenNewWindows = s.OpenNewWindows,
                                        Share = s.Share,
                                        SelectImage1 = s.SelectImage1,
                                        SelectImage2 = s.SelectImage2,
                                        SpanImageAcross = s.SpanImageAcross,
                                        AlignLeft = s.AlignLeft,
                                        WrapTextAroundImages = s.WrapTextAroundImages,
                                        Ansnotification = s.Ansnotification
                                    })
                                    .AsNoTracking()
                                    .ToListAsync();

        return _mapper.Map<List<DropDownDTO>>(contents);
    }

    public Task<int> AddAsync(ContentDTO entity)
    {
        try
        {
            Content content = _mapper.Map<ContentDTO, Content>(entity);

            content.DeleteFlag = false;
            content.CreatedDate = DateTime.Now;
            content.UpdatedDate = DateTime.Now;

            _context.Contents.Add(content);
            _context.SaveChanges();

            return Task.FromResult(content.ContentId);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> UpdateAsync(ContentDTO entity)
    {
        try
        {
            Content content = _mapper.Map<ContentDTO, Content>(entity);

            Content contentFromDb = _context.Contents.Where(x => x.ContentId == content.ContentId && x.DeleteFlag == false).AsNoTracking().FirstOrDefault();

            if (contentFromDb != null)
            {
                content.CreatedDate = contentFromDb.CreatedDate;
                content.UpdatedDate = DateTime.Now;
                content.DeleteFlag = false;
                content.RowVersion = contentFromDb.RowVersion;

                _context.Contents.Update(content);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> RemoveAsync(int contentId)
    {
        try
        {
            Content content = _context.Contents.Find(contentId);

            if (content == null)
            {
                return false;
            }

            content.UpdatedDate = DateTime.Now;
            content.DeleteFlag = true;

            _context.Contents.Update(content);
            await _context.SaveChangesAsync();

            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
