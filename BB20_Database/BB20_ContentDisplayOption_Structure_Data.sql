USE [BB20_ContentDisplayOption]
GO
/****** Object:  Table [dbo].[ContentDisplayOption]    Script Date: 27/9/2023 2:16:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContentDisplayOption](
	[ContentDisplayOptionID] [int] IDENTITY(1,1) NOT NULL,
	[ContentID] [int] NOT NULL,
	[DOShowComment] [bit] NOT NULL,
	[DONewComments] [bit] NOT NULL,
	[DOHideItem] [bit] NOT NULL,
	[DODisplayItem] [bit] NOT NULL,
	[DODisplayItemWDtRng] [bit] NOT NULL,
	[DOHomeNotFeatured] [bit] NOT NULL,
	[DOHomeFeatureItem] [bit] NOT NULL,
	[DOHomeFeatureItemWDtRng] [bit] NOT NULL,
	[DOLandingNotFeatured] [bit] NOT NULL,
	[DOLandingFeatureItem] [bit] NOT NULL,
	[DOLandingFeatureItemWDtRng] [bit] NOT NULL,
	[UnlockedPost] [bit] NOT NULL,
	[EnableML5Search] [bit] NOT NULL,
	[PackageTemplate] [bit] NOT NULL,
	[PostType] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_ContentDisplayOption] PRIMARY KEY CLUSTERED 
(
	[ContentDisplayOptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DisplayOptionCategory]    Script Date: 27/9/2023 2:16:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DisplayOptionCategory](
	[ContentDisplayOptionCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[ContentDisplayOptionID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[SubCategoryID] [int] NOT NULL,
	[InteriorCategoryID] [int] NOT NULL,
	[DisplayStatus] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_DisplayOptionCategory] PRIMARY KEY CLUSTERED 
(
	[ContentDisplayOptionCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContentDisplayOption]    Script Date: 27/9/2023 2:16:58 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_ContentDisplayOption] ON [dbo].[ContentDisplayOption]
(
	[ContentDisplayOptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContentID]    Script Date: 27/9/2023 2:16:58 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_ContentID] ON [dbo].[ContentDisplayOption]
(
	[ContentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Categories]    Script Date: 27/9/2023 2:16:58 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Categories] ON [dbo].[DisplayOptionCategory]
(
	[CategoryID] ASC,
	[SubCategoryID] ASC,
	[InteriorCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DisplayOptionCategory]    Script Date: 27/9/2023 2:16:58 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_DisplayOptionCategory] ON [dbo].[DisplayOptionCategory]
(
	[ContentDisplayOptionCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_ContentDisplayOption_DOShowComment]  DEFAULT ((0)) FOR [DOShowComment]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_ContentDisplayOption_DONewComments]  DEFAULT ((0)) FOR [DONewComments]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_ContentDisplayOption_DOHideItem]  DEFAULT ((0)) FOR [DOHideItem]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_ContentDisplayOption_DODisplayItem]  DEFAULT ((0)) FOR [DODisplayItem]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_ContentDisplayOption_DODisplayItemWDtRng]  DEFAULT ((0)) FOR [DODisplayItemWDtRng]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_Table_1_DONotFeatured]  DEFAULT ((0)) FOR [DOHomeNotFeatured]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_Table_1_DOFeatureItem]  DEFAULT ((0)) FOR [DOHomeFeatureItem]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_Table_1_DOFeatureItemWDtRng]  DEFAULT ((0)) FOR [DOHomeFeatureItemWDtRng]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_Table_1_DOHomeNotFeatured1]  DEFAULT ((0)) FOR [DOLandingNotFeatured]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_Table_1_DOHomeFeatureItem1]  DEFAULT ((0)) FOR [DOLandingFeatureItem]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_Table_1_DOHomeFeatureItemWDtRng1]  DEFAULT ((0)) FOR [DOLandingFeatureItemWDtRng]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_ContentDisplayOption_UnlockedPost]  DEFAULT ((0)) FOR [UnlockedPost]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_ContentDisplayOption_EnableML5Search]  DEFAULT ((0)) FOR [EnableML5Search]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_ContentDisplayOption_PackageTemplate]  DEFAULT ((0)) FOR [PackageTemplate]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_ContentDisplayOption_PostType]  DEFAULT ((0)) FOR [PostType]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_ContentDisplayOption_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_ContentDisplayOption_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[ContentDisplayOption] ADD  CONSTRAINT [DF_ContentDisplayOption_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
ALTER TABLE [dbo].[DisplayOptionCategory] ADD  CONSTRAINT [DF_DisplayOptionCategory_DisplayStatus]  DEFAULT ((0)) FOR [DisplayStatus]
GO
ALTER TABLE [dbo].[DisplayOptionCategory] ADD  CONSTRAINT [DF_DisplayOptionCategory_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[DisplayOptionCategory] ADD  CONSTRAINT [DF_DisplayOptionCategory_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[DisplayOptionCategory] ADD  CONSTRAINT [DF_DisplayOptionCategory_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
ALTER TABLE [dbo].[DisplayOptionCategory]  WITH CHECK ADD  CONSTRAINT [FK_DisplayOptionCategory_ContentDisplayOption] FOREIGN KEY([ContentDisplayOptionID])
REFERENCES [dbo].[ContentDisplayOption] ([ContentDisplayOptionID])
GO
ALTER TABLE [dbo].[DisplayOptionCategory] CHECK CONSTRAINT [FK_DisplayOptionCategory_ContentDisplayOption]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'ContentDisplayOptionID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the table content' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'ContentID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Display options if comments are displayed' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'DOShowComment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Display options if new comments can be made' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'DONewComments'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Hide Item' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'DOHideItem'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Display Item' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'DODisplayItem'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Display Item Within Date Range' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'DODisplayItemWDtRng'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Not Featured (Home Page)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'DOHomeNotFeatured'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Feature Item (Home Page)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'DOHomeFeatureItem'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Feature Item Within Date Range (Home Page)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'DOHomeFeatureItemWDtRng'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Not Featured (Landing Page)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'DOLandingNotFeatured'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Feature Item (Landing Page)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'DOLandingFeatureItem'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Feature Item Within Date Range (Landing Page)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'DOLandingFeatureItemWDtRng'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'UnlockedPost' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'UnlockedPost'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Enable ML5 Search' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'EnableML5Search'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Package Template' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'PackageTemplate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Post Type => 0-Template, 1-Page, 2-Static Document, 3-External URL' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'PostType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the creation of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the update of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'UpdatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If the row is logicaly deleted (0 = false and 1 = true)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'DeleteFlag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'This field is for the management of the concurrency' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ContentDisplayOption', @level2type=N'COLUMN',@level2name=N'RowVersion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id of the table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DisplayOptionCategory', @level2type=N'COLUMN',@level2name=N'ContentDisplayOptionCategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the table Content Display Option' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DisplayOptionCategory', @level2type=N'COLUMN',@level2name=N'ContentDisplayOptionID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the category table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DisplayOptionCategory', @level2type=N'COLUMN',@level2name=N'CategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the sub category table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DisplayOptionCategory', @level2type=N'COLUMN',@level2name=N'SubCategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the interior category table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DisplayOptionCategory', @level2type=N'COLUMN',@level2name=N'InteriorCategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Status of the category (display = 0 or hidden = 1)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DisplayOptionCategory', @level2type=N'COLUMN',@level2name=N'DisplayStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the creation of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DisplayOptionCategory', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the update of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DisplayOptionCategory', @level2type=N'COLUMN',@level2name=N'UpdatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If the row is logicaly deleted (0 = false and 1 = true)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DisplayOptionCategory', @level2type=N'COLUMN',@level2name=N'DeleteFlag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'This field is for the management of the concurrency' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DisplayOptionCategory', @level2type=N'COLUMN',@level2name=N'RowVersion'
GO
