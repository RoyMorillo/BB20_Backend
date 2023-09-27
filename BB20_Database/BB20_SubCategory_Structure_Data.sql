USE [BB20_SubCategories]
GO
/****** Object:  Table [dbo].[SubCategory]    Script Date: 27/9/2023 2:11:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubCategory](
	[SubCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Name] [nvarchar](75) NOT NULL,
	[DisplayStatus] [int] NOT NULL,
	[FTinHeaderAndFooter] [bit] NOT NULL,
	[FTInBannerIcon] [bit] NOT NULL,
	[FTInTitle] [bit] NOT NULL,
	[Icon] [nvarchar](max) NULL,
	[UseExternalURL] [bit] NOT NULL,
	[CategoryLandPageDesc] [nvarchar](max) NULL,
	[CategoryLandPageHead] [nvarchar](max) NULL,
	[SubCategoryLandPageDesc] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
	[Static] [bit] NOT NULL,
	[SEOTitle] [nvarchar](50) NULL,
	[SEOPrettyURL] [nvarchar](500) NULL,
	[SEODescMetadata] [nvarchar](1500) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_SubCategory] PRIMARY KEY CLUSTERED 
(
	[SubCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubCategoryThumbNail]    Script Date: 27/9/2023 2:11:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubCategoryThumbNail](
	[ThumbNailID] [int] IDENTITY(1,1) NOT NULL,
	[SubCategoryID] [int] NOT NULL,
	[Image] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_SubCategoryThumbNail] PRIMARY KEY CLUSTERED 
(
	[ThumbNailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SubCategory] ON 
GO
INSERT [dbo].[SubCategory] ([SubCategoryID], [CategoryID], [Name], [DisplayStatus], [FTinHeaderAndFooter], [FTInBannerIcon], [FTInTitle], [Icon], [UseExternalURL], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [Static], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (1, 2, N'Flyers', 0, 0, 0, 0, N'https://gmbb20.s3.amazonaws.com/home/crop_crop_Flyer_650x650.png', 0, NULL, NULL, NULL, 0, 0, NULL, NULL, NULL, CAST(N'2023-09-26T16:17:58.6366667' AS DateTime2), CAST(N'2023-09-26T16:17:58.6366667' AS DateTime2), 0)
GO
INSERT [dbo].[SubCategory] ([SubCategoryID], [CategoryID], [Name], [DisplayStatus], [FTinHeaderAndFooter], [FTInBannerIcon], [FTInTitle], [Icon], [UseExternalURL], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [Static], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (2, 2, N'PostCards', 0, 0, 0, 0, N'https://gmbb20.s3.amazonaws.com/home/crop_crop_Postcard_650x650_1.png', 0, NULL, NULL, NULL, 0, 0, NULL, NULL, NULL, CAST(N'2023-09-26T16:19:32.0100000' AS DateTime2), CAST(N'2023-09-26T16:19:32.0100000' AS DateTime2), 0)
GO
INSERT [dbo].[SubCategory] ([SubCategoryID], [CategoryID], [Name], [DisplayStatus], [FTinHeaderAndFooter], [FTInBannerIcon], [FTInTitle], [Icon], [UseExternalURL], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [Static], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (3, 2, N'Brochures', 0, 0, 0, 0, N'https://gmbb20.s3.amazonaws.com/home/crop_crop_Brochure_650x650_1.png', 0, NULL, NULL, NULL, 0, 0, NULL, NULL, NULL, CAST(N'2023-09-26T16:20:30.9133333' AS DateTime2), CAST(N'2023-09-26T16:20:30.9133333' AS DateTime2), 0)
GO
INSERT [dbo].[SubCategory] ([SubCategoryID], [CategoryID], [Name], [DisplayStatus], [FTinHeaderAndFooter], [FTInBannerIcon], [FTInTitle], [Icon], [UseExternalURL], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [Static], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (4, 2, N'Social Media', 0, 0, 0, 0, N'https://gmbb20.s3.amazonaws.com/home/crop_crop_Social_Media_650x650.png', 0, NULL, NULL, NULL, 0, 0, NULL, NULL, NULL, CAST(N'2023-09-26T16:21:19.9233333' AS DateTime2), CAST(N'2023-09-26T16:21:19.9233333' AS DateTime2), 0)
GO
INSERT [dbo].[SubCategory] ([SubCategoryID], [CategoryID], [Name], [DisplayStatus], [FTinHeaderAndFooter], [FTInBannerIcon], [FTInTitle], [Icon], [UseExternalURL], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [Static], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (5, 2, N'FaceBook Ads', 0, 0, 0, 0, N'https://gmbb20.s3.amazonaws.com/home/crop_thumb-ref3.png', 0, NULL, NULL, NULL, 0, 0, NULL, NULL, NULL, CAST(N'2023-09-26T16:22:35.9100000' AS DateTime2), CAST(N'2023-09-26T16:22:35.9100000' AS DateTime2), 0)
GO
INSERT [dbo].[SubCategory] ([SubCategoryID], [CategoryID], [Name], [DisplayStatus], [FTinHeaderAndFooter], [FTInBannerIcon], [FTInTitle], [Icon], [UseExternalURL], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [Static], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (6, 2, N'Single Property Sites', 0, 0, 0, 0, N'https://gmbb20.s3.amazonaws.com/home/crop_crop_Laptop_650x650.png', 0, NULL, NULL, NULL, 0, 0, NULL, NULL, NULL, CAST(N'2023-09-26T16:23:33.1300000' AS DateTime2), CAST(N'2023-09-26T16:23:33.1300000' AS DateTime2), 0)
GO
INSERT [dbo].[SubCategory] ([SubCategoryID], [CategoryID], [Name], [DisplayStatus], [FTinHeaderAndFooter], [FTInBannerIcon], [FTInTitle], [Icon], [UseExternalURL], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [Static], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (7, 2, N'Door Hangers', 0, 0, 0, 0, N'https://gmbb20.s3.amazonaws.com/home/crop_crop_Doorhanger_650x650.png', 0, NULL, NULL, NULL, 0, 0, NULL, NULL, NULL, CAST(N'2023-09-26T16:24:41.4800000' AS DateTime2), CAST(N'2023-09-26T16:24:41.4800000' AS DateTime2), 0)
GO
INSERT [dbo].[SubCategory] ([SubCategoryID], [CategoryID], [Name], [DisplayStatus], [FTinHeaderAndFooter], [FTInBannerIcon], [FTInTitle], [Icon], [UseExternalURL], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [Static], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (8, 2, N'Presentations', 0, 0, 0, 0, N'https://gmbb20.s3.amazonaws.com/home/crop_crop_Presentation_650x650.png', 0, NULL, NULL, NULL, 0, 0, NULL, NULL, NULL, CAST(N'2023-09-26T16:25:19.6400000' AS DateTime2), CAST(N'2023-09-26T16:25:19.6400000' AS DateTime2), 0)
GO
INSERT [dbo].[SubCategory] ([SubCategoryID], [CategoryID], [Name], [DisplayStatus], [FTinHeaderAndFooter], [FTInBannerIcon], [FTInTitle], [Icon], [UseExternalURL], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [Static], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (9, 2, N'Videos', 0, 0, 0, 0, N'https://gmbb20.s3.amazonaws.com/home/crop_crop_Video_Mockup_650x650.png', 0, NULL, NULL, NULL, 0, 0, NULL, NULL, NULL, CAST(N'2023-09-26T16:26:17.0266667' AS DateTime2), CAST(N'2023-09-26T16:26:17.0266667' AS DateTime2), 0)
GO
INSERT [dbo].[SubCategory] ([SubCategoryID], [CategoryID], [Name], [DisplayStatus], [FTinHeaderAndFooter], [FTInBannerIcon], [FTInTitle], [Icon], [UseExternalURL], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [Static], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (10, 2, N'Letter/LetterHeads', 0, 0, 0, 0, N'https://gmbb20.s3.amazonaws.com/home/crop_crop_Letter_650x650.png', 0, NULL, NULL, NULL, 0, 0, NULL, NULL, NULL, CAST(N'2023-09-26T16:26:58.0200000' AS DateTime2), CAST(N'2023-09-26T16:26:58.0200000' AS DateTime2), 0)
GO
INSERT [dbo].[SubCategory] ([SubCategoryID], [CategoryID], [Name], [DisplayStatus], [FTinHeaderAndFooter], [FTInBannerIcon], [FTInTitle], [Icon], [UseExternalURL], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [Static], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (11, 2, N'Helpful Documents', 0, 0, 0, 0, N'https://gmbb20.s3.amazonaws.com/home/crop_crop_Helpful_Docs_650x650.png', 0, NULL, NULL, NULL, 0, 0, NULL, NULL, NULL, CAST(N'2023-09-26T16:27:38.5833333' AS DateTime2), CAST(N'2023-09-26T16:27:38.5833333' AS DateTime2), 0)
GO
INSERT [dbo].[SubCategory] ([SubCategoryID], [CategoryID], [Name], [DisplayStatus], [FTinHeaderAndFooter], [FTInBannerIcon], [FTInTitle], [Icon], [UseExternalURL], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [Static], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (12, 2, N'Business Cards', 0, 0, 0, 0, N'https://gmbb20.s3.amazonaws.com/home/crop_crop_Business_Card_650x650.png', 0, NULL, NULL, NULL, 0, 0, NULL, NULL, NULL, CAST(N'2023-09-26T16:28:15.2300000' AS DateTime2), CAST(N'2023-09-26T16:28:15.2300000' AS DateTime2), 0)
GO
INSERT [dbo].[SubCategory] ([SubCategoryID], [CategoryID], [Name], [DisplayStatus], [FTinHeaderAndFooter], [FTInBannerIcon], [FTInTitle], [Icon], [UseExternalURL], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [Static], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (13, 2, N'Email Signatures', 0, 0, 0, 0, N'https://gmbb20.s3.amazonaws.com/home/crop_crop_Email_Signature_650x650.png', 0, NULL, NULL, NULL, 0, 0, NULL, NULL, NULL, CAST(N'2023-09-26T16:29:33.3100000' AS DateTime2), CAST(N'2023-09-26T16:29:33.3100000' AS DateTime2), 0)
GO
INSERT [dbo].[SubCategory] ([SubCategoryID], [CategoryID], [Name], [DisplayStatus], [FTinHeaderAndFooter], [FTInBannerIcon], [FTInTitle], [Icon], [UseExternalURL], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [Static], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (14, 2, N'NewsLetters', 0, 0, 0, 0, N'https://gmbb20.s3.amazonaws.com/home/crop_crop_Newsletter_650x650.png', 0, NULL, NULL, NULL, 0, 0, NULL, NULL, NULL, CAST(N'2023-09-26T16:30:11.5966667' AS DateTime2), CAST(N'2023-09-26T16:30:11.5966667' AS DateTime2), 0)
GO
INSERT [dbo].[SubCategory] ([SubCategoryID], [CategoryID], [Name], [DisplayStatus], [FTinHeaderAndFooter], [FTInBannerIcon], [FTInTitle], [Icon], [UseExternalURL], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [Static], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (15, 2, N'Spanish Materials', 0, 0, 0, 0, N'https://gmbb20.s3.amazonaws.com/home/crop_crop_Spanish_Marketing_650x650.png', 0, NULL, NULL, NULL, 0, 0, NULL, NULL, NULL, CAST(N'2023-09-26T16:30:49.7066667' AS DateTime2), CAST(N'2023-09-26T16:30:49.7066667' AS DateTime2), 0)
GO
INSERT [dbo].[SubCategory] ([SubCategoryID], [CategoryID], [Name], [DisplayStatus], [FTinHeaderAndFooter], [FTInBannerIcon], [FTInTitle], [Icon], [UseExternalURL], [CategoryLandPageDesc], [CategoryLandPageHead], [SubCategoryLandPageDesc], [IsActive], [Static], [SEOTitle], [SEOPrettyURL], [SEODescMetadata], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (16, 2, N'eXp Soluutions', 0, 0, 0, 0, N'https://gmbb20.s3.amazonaws.com/home/crop_eXp_Solutions_650x650.png', 0, NULL, NULL, NULL, 0, 0, NULL, NULL, NULL, CAST(N'2023-09-26T16:31:48.4633333' AS DateTime2), CAST(N'2023-09-26T16:31:48.4633333' AS DateTime2), 0)
GO
SET IDENTITY_INSERT [dbo].[SubCategory] OFF
GO
/****** Object:  Index [IX_Category]    Script Date: 27/9/2023 2:11:46 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Category] ON [dbo].[SubCategory]
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SubCategory]    Script Date: 27/9/2023 2:11:46 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_SubCategory] ON [dbo].[SubCategory]
(
	[SubCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SubCategoryID]    Script Date: 27/9/2023 2:11:46 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_SubCategoryID] ON [dbo].[SubCategoryThumbNail]
(
	[SubCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SubCategoryThumbNail]    Script Date: 27/9/2023 2:11:46 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_SubCategoryThumbNail] ON [dbo].[SubCategoryThumbNail]
(
	[ThumbNailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[SubCategory] ADD  CONSTRAINT [DF_SubCategory_Status]  DEFAULT ((0)) FOR [DisplayStatus]
GO
ALTER TABLE [dbo].[SubCategory] ADD  CONSTRAINT [DF_SubCategory_FTinHeadAndFoot]  DEFAULT ((0)) FOR [FTinHeaderAndFooter]
GO
ALTER TABLE [dbo].[SubCategory] ADD  CONSTRAINT [DF_SubCategory_FTInBannerIc]  DEFAULT ((0)) FOR [FTInBannerIcon]
GO
ALTER TABLE [dbo].[SubCategory] ADD  CONSTRAINT [DF_SubCategory_FTInTitle]  DEFAULT ((0)) FOR [FTInTitle]
GO
ALTER TABLE [dbo].[SubCategory] ADD  CONSTRAINT [DF_SubCategory_UseExternalURL]  DEFAULT ((0)) FOR [UseExternalURL]
GO
ALTER TABLE [dbo].[SubCategory] ADD  CONSTRAINT [DF_SubCategory_IsActive]  DEFAULT ((0)) FOR [IsActive]
GO
ALTER TABLE [dbo].[SubCategory] ADD  CONSTRAINT [DF_SubCategory_Static]  DEFAULT ((0)) FOR [Static]
GO
ALTER TABLE [dbo].[SubCategory] ADD  CONSTRAINT [DF_SubCategory_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[SubCategory] ADD  CONSTRAINT [DF_SubCategory_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[SubCategory] ADD  CONSTRAINT [DF_SubCategory_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
ALTER TABLE [dbo].[SubCategoryThumbNail] ADD  CONSTRAINT [DF_SubCategoryThumbNail_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[SubCategoryThumbNail] ADD  CONSTRAINT [DF_SubCategoryThumbNail_UpdatedDate]  DEFAULT (getdate()) FOR [UpdatedDate]
GO
ALTER TABLE [dbo].[SubCategoryThumbNail] ADD  CONSTRAINT [DF_SubCategoryThumbNail_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
ALTER TABLE [dbo].[SubCategoryThumbNail]  WITH CHECK ADD  CONSTRAINT [FK_SubCategoryThumbNail_SubCategory] FOREIGN KEY([SubCategoryID])
REFERENCES [dbo].[SubCategory] ([SubCategoryID])
GO
ALTER TABLE [dbo].[SubCategoryThumbNail] CHECK CONSTRAINT [FK_SubCategoryThumbNail_SubCategory]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the sub category' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'SubCategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the category this sub category belongs to' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'CategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Name of the sub category' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Status of the sub category (display = 0 or hidden = 1)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'DisplayStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Feature In header and footer' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'FTinHeaderAndFooter'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Feature in the banner icons section' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'FTInBannerIcon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Feature in the titles section' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'FTInTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sub Category Icon' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'Icon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Use external url' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'UseExternalURL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Main Category landing page description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'CategoryLandPageDesc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Main Category landing page Headline' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'CategoryLandPageHead'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sub category landing page description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'SubCategoryLandPageDesc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If the category is in active status (0 = active and 1 = Inactive)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'IsActive'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If the sub category is static' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'Static'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Landing page SEO Title' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'SEOTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Landing page SEO Pretty URL' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'SEOPrettyURL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Landing page SEO Description Metadata' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'SEODescMetadata'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the creation of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the update of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'UpdatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If the row is logicaly deleted (0 = false and 1 = true)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'DeleteFlag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'This field is for the management of the concurrency' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategory', @level2type=N'COLUMN',@level2name=N'RowVersion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id of the sub category thumb nail' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategoryThumbNail', @level2type=N'COLUMN',@level2name=N'ThumbNailID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the sub category it belongs' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategoryThumbNail', @level2type=N'COLUMN',@level2name=N'SubCategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Image' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategoryThumbNail', @level2type=N'COLUMN',@level2name=N'Image'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the creation of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategoryThumbNail', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime of the update of the row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategoryThumbNail', @level2type=N'COLUMN',@level2name=N'UpdatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If the row is logicaly deleted (0 = false and 1 = true)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategoryThumbNail', @level2type=N'COLUMN',@level2name=N'DeleteFlag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'This field is for the management of the concurrency' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SubCategoryThumbNail', @level2type=N'COLUMN',@level2name=N'RowVersion'
GO
