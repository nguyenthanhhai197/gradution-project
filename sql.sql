USE [eLearning]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/7/2021 6:10:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 5/7/2021 6:10:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[Id] [uniqueidentifier] NOT NULL,
	[Username] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Role] [int] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 5/7/2021 6:10:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Order] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Group] [int] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[TeacherId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exam]    Script Date: 5/7/2021 6:10:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exam](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Exam] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Files]    Script Date: 5/7/2021 6:10:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Files](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[FilePath] [nvarchar](max) NULL,
	[FileType] [int] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Files] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lessions]    Script Date: 5/7/2021 6:10:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lessions](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[CourseId] [uniqueidentifier] NOT NULL,
	[VideoUrl] [nvarchar](max) NULL,
	[Content] [nvarchar](max) NULL,
	[Teacher] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Lessions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 5/7/2021 6:10:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[Id] [uniqueidentifier] NOT NULL,
	[LessionId] [uniqueidentifier] NULL,
	[Content] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[ExamId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentLessions]    Script Date: 5/7/2021 6:10:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentLessions](
	[Id] [uniqueidentifier] NOT NULL,
	[LessionId] [uniqueidentifier] NOT NULL,
	[StudentId] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_StudentLessions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 5/7/2021 6:10:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [uniqueidentifier] NOT NULL,
	[Username] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Dob] [datetime2](7) NOT NULL,
	[School] [nvarchar](max) NULL,
	[Class] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 5/7/2021 6:10:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Dob] [datetime2](7) NOT NULL,
	[Gender] [bit] NULL,
	[Avatar] [nvarchar](max) NULL,
	[Degree] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210505020428___Init', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210505033552___AddTeacher', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210505035821___RemoveColumn', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210505101607___AddTableExam', N'5.0.5')
GO
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Role], [CreatedAt], [UpdatedAt]) VALUES (N'b1377636-a591-4431-a8a9-2ed7a156c494', N'admin', N'admin', 1, CAST(N'2021-05-05T10:08:10.4500000' AS DateTime2), CAST(N'2021-05-05T10:08:10.4500000' AS DateTime2))
GO
INSERT [dbo].[Teacher] ([Id], [Name], [Dob], [Gender], [Avatar], [Degree], [CreatedAt], [UpdatedAt]) VALUES (N'2feed881-a3b6-4da2-8e0e-07b2413bf9ab', N'Nguyễn Thúy Hằng', CAST(N'2021-05-07T17:58:11.9700000' AS DateTime2), 1, N'', N'ThS', CAST(N'2021-05-07T17:58:11.9700000' AS DateTime2), CAST(N'2021-05-07T17:58:11.9700000' AS DateTime2))
INSERT [dbo].[Teacher] ([Id], [Name], [Dob], [Gender], [Avatar], [Degree], [CreatedAt], [UpdatedAt]) VALUES (N'9485822d-d291-4f4b-86fd-3d42c0de5582', N'Nguyễn Xuân Sơn', CAST(N'2021-05-07T17:58:11.9700000' AS DateTime2), 1, N'', N'ThS', CAST(N'2021-05-07T17:58:11.9700000' AS DateTime2), CAST(N'2021-05-07T17:58:11.9700000' AS DateTime2))
INSERT [dbo].[Teacher] ([Id], [Name], [Dob], [Gender], [Avatar], [Degree], [CreatedAt], [UpdatedAt]) VALUES (N'2fbb8b29-e09a-4525-b805-70ae8b733bfb', N'Phạm Quang Thanh', CAST(N'2021-05-07T17:58:11.9733333' AS DateTime2), 1, N'', N'ThS', CAST(N'2021-05-07T17:58:11.9733333' AS DateTime2), CAST(N'2021-05-07T17:58:11.9733333' AS DateTime2))
INSERT [dbo].[Teacher] ([Id], [Name], [Dob], [Gender], [Avatar], [Degree], [CreatedAt], [UpdatedAt]) VALUES (N'2e2d349e-a4fa-4040-bcc6-945a15977687', N'Nguyễn Đức Hạnh', CAST(N'2021-05-07T17:58:11.9733333' AS DateTime2), 1, N'', N'ThS', CAST(N'2021-05-07T17:58:11.9733333' AS DateTime2), CAST(N'2021-05-07T17:58:11.9733333' AS DateTime2))
INSERT [dbo].[Teacher] ([Id], [Name], [Dob], [Gender], [Avatar], [Degree], [CreatedAt], [UpdatedAt]) VALUES (N'091e35e3-6d69-4775-b442-b988c3ec23dc', N'Đoàn Văn Sơn', CAST(N'2021-05-07T17:48:41.5700000' AS DateTime2), 1, N'', N'ThS', CAST(N'2021-05-07T17:48:41.5700000' AS DateTime2), CAST(N'2021-05-07T17:48:41.5700000' AS DateTime2))
GO
ALTER TABLE [dbo].[Courses] ADD  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [TeacherId]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Teacher_TeacherId] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teacher] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Teacher_TeacherId]
GO
ALTER TABLE [dbo].[Lessions]  WITH CHECK ADD  CONSTRAINT [FK_Lessions_Courses_CourseId] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Lessions] CHECK CONSTRAINT [FK_Lessions_Courses_CourseId]
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD  CONSTRAINT [FK_Questions_Exam_ExamId] FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exam] ([Id])
GO
ALTER TABLE [dbo].[Questions] CHECK CONSTRAINT [FK_Questions_Exam_ExamId]
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD  CONSTRAINT [FK_Questions_Lessions_LessionId] FOREIGN KEY([LessionId])
REFERENCES [dbo].[Lessions] ([Id])
GO
ALTER TABLE [dbo].[Questions] CHECK CONSTRAINT [FK_Questions_Lessions_LessionId]
GO
ALTER TABLE [dbo].[StudentLessions]  WITH CHECK ADD  CONSTRAINT [FK_StudentLessions_Lessions_LessionId] FOREIGN KEY([LessionId])
REFERENCES [dbo].[Lessions] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentLessions] CHECK CONSTRAINT [FK_StudentLessions_Lessions_LessionId]
GO
ALTER TABLE [dbo].[StudentLessions]  WITH CHECK ADD  CONSTRAINT [FK_StudentLessions_Students_StudentId] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentLessions] CHECK CONSTRAINT [FK_StudentLessions_Students_StudentId]
GO
