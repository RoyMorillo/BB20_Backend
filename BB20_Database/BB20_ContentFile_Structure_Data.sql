USE [BB20_ContentFile]
GO
/****** Object:  Table [dbo].[ContentFile]    Script Date: 26/9/2023 8:29:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContentFile](
	[ContentFileID] [int] IDENTITY(1,1) NOT NULL,
	[ContentID] [int] NOT NULL,
	[AssociatedFiles] [varbinary](max) NULL,
	[ShowTerms] [bit] NOT NULL,
	[AssociatedFileTitle] [nvarchar](75) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_ContentFile] PRIMARY KEY CLUSTERED 
(
	[ContentFileID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ContentFile] ADD  CONSTRAINT [DF_ContentFile_ShowTerms]  DEFAULT ((0)) FOR [ShowTerms]
GO
ALTER TABLE [dbo].[ContentFile] ADD  CONSTRAINT [DF_ContentFile_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[ContentFile] ADD  CONSTRAINT [DF_ContentFile_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[ContentFile] ADD  CONSTRAINT [DF_ContentFile_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentFile', @level2type=N'COLUMN',@level2name=N'ContentFileID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the content Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentFile', @level2type=N'COLUMN',@level2name=N'ContentID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'es tipo archivo .zip, pdf, doc' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentFile', @level2type=N'COLUMN',@level2name=N'AssociatedFiles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'if the terms are displayed' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentFile', @level2type=N'COLUMN',@level2name=N'ShowTerms'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Title of Content files' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentFile', @level2type=N'COLUMN',@level2name=N'AssociatedFileTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the creation of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentFile', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the update of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentFile', @level2type=N'COLUMN',@level2name=N'UpdatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If the row is logicaly deleted (0 = false and 1 = true)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentFile', @level2type=N'COLUMN',@level2name=N'DeleteFlag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'This field is for the management of the concurrency' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentFile', @level2type=N'COLUMN',@level2name=N'RowVersion'
GO
