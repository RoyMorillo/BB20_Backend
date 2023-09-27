USE [BB20_ContentVideo]
GO
/****** Object:  Table [dbo].[ContentVideo]    Script Date: 27/9/2023 2:19:48 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContentVideo](
	[ContentVideoID] [int] IDENTITY(1,1) NOT NULL,
	[ContentID] [int] NOT NULL,
	[VIDEOFiles] [nvarchar](max) NULL,
	[VIDEOWidth] [int] NULL,
	[VIDEOHeight] [int] NULL,
	[VIDEOAutostart] [bit] NULL,
	[VIDEOLoop] [bit] NOT NULL,
	[VIDEOIcon] [nvarchar](max) NULL,
	[VIDEOCaption] [nvarchar](500) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_ContentVideo] PRIMARY KEY CLUSTERED 
(
	[ContentVideoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_ContentID]    Script Date: 27/9/2023 2:19:48 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_ContentID] ON [dbo].[ContentVideo]
(
	[ContentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContentVideo]    Script Date: 27/9/2023 2:19:48 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_ContentVideo] ON [dbo].[ContentVideo]
(
	[ContentVideoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ContentVideo] ADD  CONSTRAINT [DF_ContentVideo_VIDEOLoop]  DEFAULT ((0)) FOR [VIDEOLoop]
GO
ALTER TABLE [dbo].[ContentVideo] ADD  CONSTRAINT [DF_ContentVideo_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[ContentVideo] ADD  CONSTRAINT [DF_ContentVideo_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[ContentVideo] ADD  CONSTRAINT [DF_ContentVideo_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentVideo', @level2type=N'COLUMN',@level2name=N'ContentVideoID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the content table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentVideo', @level2type=N'COLUMN',@level2name=N'ContentID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Video file' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentVideo', @level2type=N'COLUMN',@level2name=N'VIDEOFiles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Video Width' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentVideo', @level2type=N'COLUMN',@level2name=N'VIDEOWidth'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Video height' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentVideo', @level2type=N'COLUMN',@level2name=N'VIDEOHeight'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If the video should self-start' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentVideo', @level2type=N'COLUMN',@level2name=N'VIDEOAutostart'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If the video should be repeated' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentVideo', @level2type=N'COLUMN',@level2name=N'VIDEOLoop'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Video image' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentVideo', @level2type=N'COLUMN',@level2name=N'VIDEOIcon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Video caption' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentVideo', @level2type=N'COLUMN',@level2name=N'VIDEOCaption'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the creation of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentVideo', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the update of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentVideo', @level2type=N'COLUMN',@level2name=N'UpdatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If the row is logicaly deleted (0 = false and 1 = true)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentVideo', @level2type=N'COLUMN',@level2name=N'DeleteFlag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'This field is for the management of the concurrency' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentVideo', @level2type=N'COLUMN',@level2name=N'RowVersion'
GO
