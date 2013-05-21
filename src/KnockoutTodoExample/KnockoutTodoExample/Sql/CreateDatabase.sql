USE [Todo]

GO

CREATE TABLE [TodoItem](
	[Id] [uniqueidentifier] NOT NULL PRIMARY KEY,
	[Description] [nvarchar](512) NOT NULL,
	[IsDone] [bit] NOT NULL,
	[AddedDate] [datetime] NOT NULL)
