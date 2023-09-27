USE [BB20_InteriorCategories]
GO
/****** Object:  Table [dbo].[InteriorCategory]    Script Date: 27/9/2023 2:12:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InteriorCategory](
	[InteriorCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[SubCategoryID] [int] NOT NULL,
	[Name] [nvarchar](75) NOT NULL,
	[DisplayStatus] [int] NOT NULL,
	[Icon] [nvarchar](max) NULL,
	[CategoryLandPageDesc] [nvarchar](max) NULL,
	[CategoryLandPageHead] [nvarchar](max) NULL,
	[SubCategoryLandPageDesc] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
	[SEOTitle] [nvarchar](50) NULL,
	[SEOPrettyURL] [nvarchar](500) NULL,
	[SEODescMetadata] [nvarchar](1500) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_InteriorCategory] PRIMARY KEY CLUSTERED 
(
	[InteriorCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[InteriorCategory] ON 
GO
INSERT [dbo].[InteriorCategory] ([InteriorCategoryID], [CategoryID], [SubCategoryID], [Name], [DisplayStatus], [Icon], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (1, 2, 1, N'Listing', 0, N'https://gmbb20.s3.amazonaws.com/Interior/Captura+de+pantalla+2023-09-26+111128.png', NULL, NULL, NULL, 0, NULL, NULL, NULL, CAST(N'2023-09-26T18:21:26.2800000' AS DateTime2), CAST(N'2023-09-26T18:21:26.2800000' AS DateTime2), 0)
GO
INSERT [dbo].[InteriorCategory] ([InteriorCategoryID], [CategoryID], [SubCategoryID], [Name], [DisplayStatus], [Icon], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (2, 2, 1, N'Open House', 0, N'https://gmbb20.s3.amazonaws.com/Interior/openhouse.jpg', NULL, NULL, NULL, 0, NULL, NULL, NULL, CAST(N'2023-09-26T18:22:09.3433333' AS DateTime2), CAST(N'2023-09-26T18:22:09.3433333' AS DateTime2), 0)
GO
SET IDENTITY_INSERT [dbo].[InteriorCategory] OFF
GO
/****** Object:  Index [IX_Categories]    Script Date: 27/9/2023 2:12:26 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Categories] ON [dbo].[InteriorCategory]
(
	[SubCategoryID] ASC,
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_InteriorCategory]    Script Date: 27/9/2023 2:12:26 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_InteriorCategory] ON [dbo].[InteriorCategory]
(
	[InteriorCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[InteriorCategory] ADD  CONSTRAINT [DF_Table_1_Status]  DEFAULT ((0)) FOR [DisplayStatus]
GO
ALTER TABLE [dbo].[InteriorCategory] ADD  CONSTRAINT [DF_InteriorCategory_IsActive]  DEFAULT ((0)) FOR [IsActive]
GO
ALTER TABLE [dbo].[InteriorCategory] ADD  CONSTRAINT [DF_InteriorCategory_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[InteriorCategory] ADD  CONSTRAINT [DF_InteriorCategory_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[InteriorCategory] ADD  CONSTRAINT [DF_InteriorCategory_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the category it belongs' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'InteriorCategory', @level2type=N'COLUMN',@level2name=N'CategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the sub category this interior category belongs to' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'InteriorCategory', @level2type=N'COLUMN',@level2name=N'SubCategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Name of the interior category' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'InteriorCategory', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Status of the interior category (display = 0 or hidden = 1)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'InteriorCategory', @level2type=N'COLUMN',@level2name=N'DisplayStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Interior Category Icon' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'InteriorCategory', @level2type=N'COLUMN',@level2name=N'Icon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Main Category landing page description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'InteriorCategory', @level2type=N'COLUMN',@level2name=N'CategoryLandPageDesc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Main Category landing page Headline' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'InteriorCategory', @level2type=N'COLUMN',@level2name=N'CategoryLandPageHead'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sub category landing page description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'InteriorCategory', @level2type=N'COLUMN',@level2name=N'SubCategoryLandPageDesc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If the category is in active status (0 = active and 1 = Inactive)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'InteriorCategory', @level2type=N'COLUMN',@level2name=N'IsActive'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Landing page SEO Title' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'InteriorCategory', @level2type=N'COLUMN',@level2name=N'SEOTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Landing page SEO Pretty URL' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'InteriorCategory', @level2type=N'COLUMN',@level2name=N'SEOPrettyURL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Landing page SEO Description Metadata' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'InteriorCategory', @level2type=N'COLUMN',@level2name=N'SEODescMetadata'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the creation of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'InteriorCategory', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the update of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'InteriorCategory', @level2type=N'COLUMN',@level2name=N'UpdatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If the row is logicaly deleted (0 = false and 1 = true)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'InteriorCategory', @level2type=N'COLUMN',@level2name=N'DeleteFlag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'This field is for the management of the concurrency' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'InteriorCategory', @level2type=N'COLUMN',@level2name=N'RowVersion'
GO
