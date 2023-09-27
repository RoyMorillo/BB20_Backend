USE [BB20_Content]
GO
/****** Object:  Table [dbo].[Content]    Script Date: 27/9/2023 2:13:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Content](
	[ContentID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](75) NOT NULL,
	[PrettyUrl] [nvarchar](500) NULL,
	[Subtittle] [nvarchar](100) NULL,
	[DisplayStatus] [int] NOT NULL,
	[Headline] [nvarchar](100) NULL,
	[Author] [nvarchar](100) NULL,
	[DocumentDate] [datetime2](7) NULL,
	[Teaser] [nvarchar](500) NULL,
	[STTIcon] [nvarchar](max) NULL,
	[STTOnlyHomePage] [bit] NOT NULL,
	[STTTitle] [nvarchar](75) NULL,
	[STTButtonText] [nvarchar](75) NULL,
	[STTButtonLink] [nvarchar](75) NULL,
	[MainText] [nvarchar](500) NULL,
	[MetaDescription] [nvarchar](500) NULL,
	[Icon] [varbinary](max) NULL,
	[LinkUrl1] [nvarchar](500) NULL,
	[LinkUrl2] [nvarchar](500) NULL,
	[LinkUrl3] [nvarchar](500) NULL,
	[LinkTittle1] [nvarchar](75) NULL,
	[LinkTittle2] [nvarchar](75) NULL,
	[LinkTittle3] [nvarchar](75) NULL,
	[OpenNewWindows] [bit] NOT NULL,
	[Share] [bit] NOT NULL,
	[SelectImage1] [varbinary](max) NULL,
	[SelectImage2] [varbinary](max) NULL,
	[SpanImageAcross] [bit] NOT NULL,
	[AlignLeft] [bit] NOT NULL,
	[WrapTextAroundImages] [bit] NOT NULL,
	[ANSNotification] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Content] PRIMARY KEY CLUSTERED 
(
	[ContentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Content]    Script Date: 27/9/2023 2:13:20 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Content] ON [dbo].[Content]
(
	[ContentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Content] ADD  CONSTRAINT [DF_Content_DisplayStatus]  DEFAULT ((0)) FOR [DisplayStatus]
GO
ALTER TABLE [dbo].[Content] ADD  CONSTRAINT [DF_Content_STTOnlyHomePage]  DEFAULT ((0)) FOR [STTOnlyHomePage]
GO
ALTER TABLE [dbo].[Content] ADD  CONSTRAINT [DF_Content_OpenNewWindows]  DEFAULT ((0)) FOR [OpenNewWindows]
GO
ALTER TABLE [dbo].[Content] ADD  CONSTRAINT [DF_Content_Share]  DEFAULT ((0)) FOR [Share]
GO
ALTER TABLE [dbo].[Content] ADD  CONSTRAINT [DF_Content_SpanImageAcross]  DEFAULT ((0)) FOR [SpanImageAcross]
GO
ALTER TABLE [dbo].[Content] ADD  CONSTRAINT [DF_Content_AlignLeft]  DEFAULT ((1)) FOR [AlignLeft]
GO
ALTER TABLE [dbo].[Content] ADD  CONSTRAINT [DF_Content_WrapTextAroundImages]  DEFAULT ((0)) FOR [WrapTextAroundImages]
GO
ALTER TABLE [dbo].[Content] ADD  CONSTRAINT [DF_Content_ANSNotification]  DEFAULT ((0)) FOR [ANSNotification]
GO
ALTER TABLE [dbo].[Content] ADD  CONSTRAINT [DF_Content_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Content] ADD  CONSTRAINT [DF_Content_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[Content] ADD  CONSTRAINT [DF_Content_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the content' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'ContentID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Name of Content' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ontent PrettyURL' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'PrettyUrl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Subtittle of content' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'Subtittle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Status of the category (display = 0 or hidden = 1)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'DisplayStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Headline of content' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'Headline'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Author of content' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'Author'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the creation of the content' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'DocumentDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Long Teaser of Content' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'Teaser'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Teaser thumbnail icon' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'STTIcon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Teaser thumbnail if only use on home page (0=yes and 1=no)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'STTOnlyHomePage'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Teaser thumbnail title' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'STTTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Teaser thumbnail Botton text' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'STTButtonText'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Teaser thumbnail Botton Link' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'STTButtonLink'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Main text description of content' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'MainText'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'meta text description of content' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'MetaDescription'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Content Icon ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'Icon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'URL of Content files' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'LinkUrl1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'URL of Content files' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'LinkUrl2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'URL of Content files' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'LinkUrl3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Link of Content files' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'LinkTittle1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Link of Content files' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'LinkTittle2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Link of Content files' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'LinkTittle3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Open in New Windows' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'OpenNewWindows'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Share' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'Share'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Span Image Across' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'SpanImageAcross'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Align Left, if 1 = true, 0 = false then is align right' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'AlignLeft'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Wrap Text Around Images' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'WrapTextAroundImages'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'App notifications Section => 0-On, 1-Off, 2-High Priority' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'ANSNotification'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the creation of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the update of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'UpdatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If the row is logicaly deleted (0 = false and 1 = true)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'DeleteFlag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'This field is for the management of the concurrency' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Content', @level2type=N'COLUMN',@level2name=N'RowVersion'
GO
