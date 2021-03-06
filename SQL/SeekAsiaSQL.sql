CREATE DATABASE WOLFCOMTechnicalTest
GO
USE [WOLFCOMTechnicalTest]
GO
/****** Object:  Table [dbo].[CustomerPromotion]    Script Date: 4/10/2019 9:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerPromotion](
	[PromotionId] [bigint] IDENTITY(1000,1) NOT NULL,
	[UserTypeId] [bigint] NOT NULL,
	[ProductCode] [bigint] NOT NULL,
	[PromotionFormula] [nvarchar](max) NULL,
	[PromotionPrice] [decimal](15, 2) NOT NULL,
	[Status] [bit] NOT NULL,
	[ExpiryDate] [datetime] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_CustomerPromotion] PRIMARY KEY CLUSTERED 
(
	[PromotionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrivilageCustomer]    Script Date: 4/10/2019 9:05:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrivilageCustomer](
	[CustomerId] [bigint] IDENTITY(1000,1) NOT NULL,
	[CustomerPrivilageName] [nvarchar](max) NOT NULL,
	[Status] [bit] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_PrivilageCustomer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductDetails]    Script Date: 4/10/2019 9:05:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductDetails](
	[ProductCode] [bigint] IDENTITY(1000,1) NOT NULL,
	[ProductId] [nvarchar](50) NOT NULL,
	[ProductName] [nvarchar](100) NOT NULL,
	[ProductPrice] [decimal](15, 2) NOT NULL,
	[ProductDescription] [nvarchar](max) NULL,
	[Status] [bit] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_ProductDetails] PRIMARY KEY CLUSTERED 
(
	[ProductCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CustomerPromotion] ON 

INSERT [dbo].[CustomerPromotion] ([PromotionId], [UserTypeId], [ProductCode], [PromotionFormula], [PromotionPrice], [Status], [ExpiryDate], [CreatedDate], [UpdatedDate]) VALUES (1000, 1000, 1000, N'{NumberofProducts}=3', CAST(179.99 AS Decimal(15, 2)), 1, CAST(N'2020-04-08T07:17:56.600' AS DateTime), CAST(N'2019-04-08T07:17:56.600' AS DateTime), CAST(N'2019-04-08T07:17:56.600' AS DateTime))
INSERT [dbo].[CustomerPromotion] ([PromotionId], [UserTypeId], [ProductCode], [PromotionFormula], [PromotionPrice], [Status], [ExpiryDate], [CreatedDate], [UpdatedDate]) VALUES (1001, 1001, 1006, N'1=1', CAST(299.99 AS Decimal(15, 2)), 1, CAST(N'2020-04-08T07:17:56.600' AS DateTime), CAST(N'2019-04-08T07:17:56.600' AS DateTime), CAST(N'2019-04-08T07:17:56.600' AS DateTime))
INSERT [dbo].[CustomerPromotion] ([PromotionId], [UserTypeId], [ProductCode], [PromotionFormula], [PromotionPrice], [Status], [ExpiryDate], [CreatedDate], [UpdatedDate]) VALUES (1004, 1002, 1007, N'{NumberofProducts}>=4', CAST(379.99 AS Decimal(15, 2)), 1, CAST(N'2020-04-08T07:17:56.600' AS DateTime), CAST(N'2019-04-08T07:17:56.600' AS DateTime), CAST(N'2019-04-08T07:17:56.600' AS DateTime))
INSERT [dbo].[CustomerPromotion] ([PromotionId], [UserTypeId], [ProductCode], [PromotionFormula], [PromotionPrice], [Status], [ExpiryDate], [CreatedDate], [UpdatedDate]) VALUES (1006, 1003, 1000, N'{NumberofProducts}=5', CAST(67.49 AS Decimal(15, 2)), 1, CAST(N'2020-04-08T07:17:56.600' AS DateTime), CAST(N'2019-04-08T07:17:56.600' AS DateTime), CAST(N'2019-04-08T07:17:56.600' AS DateTime))
INSERT [dbo].[CustomerPromotion] ([PromotionId], [UserTypeId], [ProductCode], [PromotionFormula], [PromotionPrice], [Status], [ExpiryDate], [CreatedDate], [UpdatedDate]) VALUES (1007, 1003, 1006, N'1=1', CAST(309.99 AS Decimal(15, 2)), 1, CAST(N'2020-04-08T07:17:56.600' AS DateTime), CAST(N'2019-04-08T07:17:56.600' AS DateTime), CAST(N'2019-04-08T07:17:56.600' AS DateTime))
INSERT [dbo].[CustomerPromotion] ([PromotionId], [UserTypeId], [ProductCode], [PromotionFormula], [PromotionPrice], [Status], [ExpiryDate], [CreatedDate], [UpdatedDate]) VALUES (1009, 1003, 1007, N'{NumberofProducts}>=3', CAST(389.99 AS Decimal(15, 2)), 1, CAST(N'2020-04-08T07:17:56.600' AS DateTime), CAST(N'2019-04-08T07:17:56.600' AS DateTime), CAST(N'2019-04-08T07:17:56.600' AS DateTime))
SET IDENTITY_INSERT [dbo].[CustomerPromotion] OFF
SET IDENTITY_INSERT [dbo].[PrivilageCustomer] ON 

INSERT [dbo].[PrivilageCustomer] ([CustomerId], [CustomerPrivilageName], [Status], [CreatedDate]) VALUES (1000, N'UNILIVER', 1, CAST(N'2019-04-08T07:17:56.600' AS DateTime))
INSERT [dbo].[PrivilageCustomer] ([CustomerId], [CustomerPrivilageName], [Status], [CreatedDate]) VALUES (1001, N'APPLE', 1, CAST(N'2019-04-08T07:17:56.600' AS DateTime))
INSERT [dbo].[PrivilageCustomer] ([CustomerId], [CustomerPrivilageName], [Status], [CreatedDate]) VALUES (1002, N'NIKE', 1, CAST(N'2019-04-08T07:17:56.600' AS DateTime))
INSERT [dbo].[PrivilageCustomer] ([CustomerId], [CustomerPrivilageName], [Status], [CreatedDate]) VALUES (1003, N'FORD', 1, CAST(N'2019-04-08T07:17:56.600' AS DateTime))
SET IDENTITY_INSERT [dbo].[PrivilageCustomer] OFF
SET IDENTITY_INSERT [dbo].[ProductDetails] ON 

INSERT [dbo].[ProductDetails] ([ProductCode], [ProductId], [ProductName], [ProductPrice], [ProductDescription], [Status], [CreatedDate], [UpdatedDate]) VALUES (1000, N'classic', N'Classic Ad', CAST(269.99 AS Decimal(15, 2)), N'Classic Advertisement', 1, CAST(N'2019-04-08T07:17:56.600' AS DateTime), CAST(N'2019-04-08T07:17:56.600' AS DateTime))
INSERT [dbo].[ProductDetails] ([ProductCode], [ProductId], [ProductName], [ProductPrice], [ProductDescription], [Status], [CreatedDate], [UpdatedDate]) VALUES (1006, N'standout', N'Standout Ad', CAST(322.99 AS Decimal(15, 2)), N'Standout Advertisement', 1, CAST(N'2019-04-08T07:17:56.600' AS DateTime), CAST(N'2019-04-08T07:17:56.600' AS DateTime))
INSERT [dbo].[ProductDetails] ([ProductCode], [ProductId], [ProductName], [ProductPrice], [ProductDescription], [Status], [CreatedDate], [UpdatedDate]) VALUES (1007, N'premium', N'Premium Ad', CAST(394.99 AS Decimal(15, 2)), N'Premium Advertisement', 1, CAST(N'2019-04-08T07:17:56.600' AS DateTime), CAST(N'2019-04-08T07:17:56.600' AS DateTime))
SET IDENTITY_INSERT [dbo].[ProductDetails] OFF
ALTER TABLE [dbo].[CustomerPromotion]  WITH CHECK ADD  CONSTRAINT [FK_CustomerPromotion_PrivilageCustomer] FOREIGN KEY([UserTypeId])
REFERENCES [dbo].[PrivilageCustomer] ([CustomerId])
GO
ALTER TABLE [dbo].[CustomerPromotion] CHECK CONSTRAINT [FK_CustomerPromotion_PrivilageCustomer]
GO
ALTER TABLE [dbo].[CustomerPromotion]  WITH CHECK ADD  CONSTRAINT [FK_CustomerPromotion_ProductDetails1] FOREIGN KEY([ProductCode])
REFERENCES [dbo].[ProductDetails] ([ProductCode])
GO
ALTER TABLE [dbo].[CustomerPromotion] CHECK CONSTRAINT [FK_CustomerPromotion_ProductDetails1]
GO
