USE [BB20_ContentAudio]
GO
/****** Object:  Table [dbo].[ContentAudio]    Script Date: 27/9/2023 2:14:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContentAudio](
	[ContentAudioID] [int] IDENTITY(1,1) NOT NULL,
	[ContentID] [int] NOT NULL,
	[AUDIOFile] [varbinary](max) NULL,
	[AUDIOArtist] [nvarchar](75) NULL,
	[AUDIOHideInfo] [bit] NOT NULL,
	[AUDIOAutoStart] [bit] NOT NULL,
	[AUDIOLoop] [bit] NOT NULL,
	[AUDIOAnimation] [bit] NOT NULL,
	[AUDIOValume] [int] NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_ContentAudio] PRIMARY KEY CLUSTERED 
(
	[ContentAudioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_ContentAudio]    Script Date: 27/9/2023 2:14:44 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_ContentAudio] ON [dbo].[ContentAudio]
(
	[ContentAudioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContentID]    Script Date: 27/9/2023 2:14:44 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_ContentID] ON [dbo].[ContentAudio]
(
	[ContentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ContentAudio] ADD  CONSTRAINT [DF_ContentAudio_AUDIOHideInfo]  DEFAULT ((0)) FOR [AUDIOHideInfo]
GO
ALTER TABLE [dbo].[ContentAudio] ADD  CONSTRAINT [DF_ContentAudio_AUDIOAutoStart]  DEFAULT ((0)) FOR [AUDIOAutoStart]
GO
ALTER TABLE [dbo].[ContentAudio] ADD  CONSTRAINT [DF_ContentAudio_AUDIOLoop]  DEFAULT ((0)) FOR [AUDIOLoop]
GO
ALTER TABLE [dbo].[ContentAudio] ADD  CONSTRAINT [DF_ContentAudio_AUDIOAnimation]  DEFAULT ((0)) FOR [AUDIOAnimation]
GO
ALTER TABLE [dbo].[ContentAudio] ADD  CONSTRAINT [DF_ContentAudio_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[ContentAudio] ADD  CONSTRAINT [DF_ContentAudio_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[ContentAudio] ADD  CONSTRAINT [DF_ContentAudio_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id of the table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentAudio', @level2type=N'COLUMN',@level2name=N'ContentAudioID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the content table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentAudio', @level2type=N'COLUMN',@level2name=N'ContentID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Audio File' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentAudio', @level2type=N'COLUMN',@level2name=N'AUDIOFile'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Audio Artist' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentAudio', @level2type=N'COLUMN',@level2name=N'AUDIOArtist'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'if the audio should be hidden' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentAudio', @level2type=N'COLUMN',@level2name=N'AUDIOHideInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'if the audio should auto-start' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentAudio', @level2type=N'COLUMN',@level2name=N'AUDIOAutoStart'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'if the audio should be repeated' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentAudio', @level2type=N'COLUMN',@level2name=N'AUDIOLoop'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'if the audio must have animation' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentAudio', @level2type=N'COLUMN',@level2name=N'AUDIOAnimation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'initial audio volume' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentAudio', @level2type=N'COLUMN',@level2name=N'AUDIOValume'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the creation of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentAudio', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the update of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentAudio', @level2type=N'COLUMN',@level2name=N'UpdatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If the row is logicaly deleted (0 = false and 1 = true)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentAudio', @level2type=N'COLUMN',@level2name=N'DeleteFlag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'This field is for the management of the concurrency' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentAudio', @level2type=N'COLUMN',@level2name=N'RowVersion'
GO
