USE [BB20_Content]
GO
/****** Object:  Table [dbo].[Content]    Script Date: 27/9/2023 6:11:04 p. m. ******/
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
	[Icon] [nvarchar](max) NULL,
	[LinkUrl1] [nvarchar](500) NULL,
	[LinkUrl2] [nvarchar](500) NULL,
	[LinkUrl3] [nvarchar](500) NULL,
	[LinkTittle1] [nvarchar](75) NULL,
	[LinkTittle2] [nvarchar](75) NULL,
	[LinkTittle3] [nvarchar](75) NULL,
	[OpenNewWindows] [bit] NOT NULL,
	[Share] [bit] NOT NULL,
	[SelectImage1] [nvarchar](max) NULL,
	[SelectImage2] [nvarchar](max) NULL,
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
SET IDENTITY_INSERT [dbo].[Content] ON 
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (1, N'BauHaus Door Hanger', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:35:40.1178349' AS DateTime2), CAST(N'2023-09-27T17:35:40.1178762' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (2, N'Linear Just Listed Postcard 4.25 x 6', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:36:36.7461056' AS DateTime2), CAST(N'2023-09-27T17:36:36.7461069' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (3, N'Bauhaus Just Listed Brochure', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:37:08.7106390' AS DateTime2), CAST(N'2023-09-27T17:37:08.7106402' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (4, N'Bauhaus Open House Social Media Post', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:37:42.8119313' AS DateTime2), CAST(N'2023-09-27T17:37:42.8119332' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (5, N'Bauhaus Social Media Story', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:38:08.1254271' AS DateTime2), CAST(N'2023-09-27T17:38:08.1254291' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (6, N'Low Inventory Prospecting Letter', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:39:04.2060107' AS DateTime2), CAST(N'2023-09-27T17:39:04.2060117' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (7, N'Bauhaus Home Showing Checklist', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:39:30.7846194' AS DateTime2), CAST(N'2023-09-27T17:39:30.7846209' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (8, N'Linear Just Listed Postcard 5.5 x 8.5', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:40:03.1229535' AS DateTime2), CAST(N'2023-09-27T17:40:03.1229548' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (9, N'Linear Home Showing Checklist', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:41:10.1437630' AS DateTime2), CAST(N'2023-09-27T17:41:10.1437643' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (10, N'Active Listing Kit', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:41:29.2779621' AS DateTime2), CAST(N'2023-09-27T17:41:29.2779636' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (11, N'Listing Presentation Kit', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:41:47.1320658' AS DateTime2), CAST(N'2023-09-27T17:41:47.1320676' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (12, N'Bauhaus Just Listed Social Post', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:43:00.1265871' AS DateTime2), CAST(N'2023-09-27T17:43:00.1265882' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (13, N'Bauhaus Open House Welcome Sign', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:43:33.4604840' AS DateTime2), CAST(N'2023-09-27T17:43:33.4604857' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (14, N'Linear Open House Welcome Sign', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:43:47.1154172' AS DateTime2), CAST(N'2023-09-27T17:43:47.1154182' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (15, N'Linear Just Listed Brochure', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:44:20.1361751' AS DateTime2), CAST(N'2023-09-27T17:44:20.1361767' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (16, N'Royal Blue Listing Door Hanger', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:44:39.3631722' AS DateTime2), CAST(N'2023-09-27T17:44:39.3631738' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (17, N'Royal Blue Listing Postcard', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:44:56.0283671' AS DateTime2), CAST(N'2023-09-27T17:44:56.0283683' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (18, N'Bauhaus Just Listed Social Story', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:45:16.3765493' AS DateTime2), CAST(N'2023-09-27T17:45:16.3765506' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (19, N'Linear Open House Sign In Sheet', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:45:43.1102309' AS DateTime2), CAST(N'2023-09-27T17:45:43.1102322' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (20, N'Linear Open House Comparison Chart', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:46:00.4266401' AS DateTime2), CAST(N'2023-09-27T17:46:00.4266411' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (21, N'Linear Just Listed Story', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:46:19.3762464' AS DateTime2), CAST(N'2023-09-27T17:46:19.3762472' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (22, N'Linear Just Listed Social Post', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:46:58.5354748' AS DateTime2), CAST(N'2023-09-27T17:46:58.5354761' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (23, N'Linear Open House Door Hanger', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:47:21.5313920' AS DateTime2), CAST(N'2023-09-27T17:47:21.5313931' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (24, N'Linear Open House Postcard 4.25x6', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:47:39.6849151' AS DateTime2), CAST(N'2023-09-27T17:47:39.6849162' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (25, N'Linear Open House Postcard 5.5x8.5', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:47:52.4806873' AS DateTime2), CAST(N'2023-09-27T17:47:52.4806887' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (26, N'Bauhouse Open House Flyer', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:48:23.2440228' AS DateTime2), CAST(N'2023-09-27T17:48:23.2440243' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (27, N'Linear Just Listed Flyer', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:48:53.0150991' AS DateTime2), CAST(N'2023-09-27T17:48:53.0151003' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (28, N'Linear Open House Flyer', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:49:25.4900949' AS DateTime2), CAST(N'2023-09-27T17:49:25.4900965' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (29, N'Royal Blue Thank You Card', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:49:47.3267785' AS DateTime2), CAST(N'2023-09-27T17:49:47.3267799' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (30, N'Linear Open House Kids Activity Sheet', NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 0, CAST(N'2023-09-27T17:50:27.3960984' AS DateTime2), CAST(N'2023-09-27T17:50:27.3961000' AS DateTime2), 0)
GO
INSERT [dbo].[Content] ([ContentID], [Title], [PrettyUrl], [Subtittle], [DisplayStatus], [Headline], [Author], [DocumentDate], [Teaser], [STTIcon], [STTOnlyHomePage], [STTTitle], [STTButtonText], [STTButtonLink], [MainText], [MetaDescription], [Icon], [LinkUrl1], [LinkUrl2], [LinkUrl3], [LinkTittle1], [LinkTittle2], [LinkTittle3], [OpenNewWindows], [Share], [SelectImage1], [SelectImage2], [SpanImageAcross], [AlignLeft], [WrapTextAroundImages], [ANSNotification], [CreatedDate], [UpdatedDate], [DeleteFlag]) VALUES (31, N'Borrar2', N'string', N'string', 0, N'string', N'string', CAST(N'2023-09-27T21:53:40.4570000' AS DateTime2), N'string', N'string', 1, N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'string', 1, 1, N'string', N'string', 1, 1, 1, 0, CAST(N'2023-09-27T17:50:53.6843663' AS DateTime2), CAST(N'2023-09-27T18:05:02.2138505' AS DateTime2), 1)
GO
SET IDENTITY_INSERT [dbo].[Content] OFF
GO
/****** Object:  Index [IX_Content]    Script Date: 27/9/2023 6:11:04 p. m. ******/
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
