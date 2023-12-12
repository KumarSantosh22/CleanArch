CREATE TABLE [dbo].[Appuser] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Username]    VARCHAR (50)     NULL,
    [Password]    VARCHAR (50)     NULL,
    [Email]       VARCHAR (50)     NOT NULL,
    [Name]        VARCHAR (50)     NULL,
    [PhoneNumber] VARCHAR (20)     NULL,
    [FirstName]   VARCHAR (50)     NULL,
    [LastName]    VARCHAR (50)     NULL,
    [Roles]       VARCHAR (50)     NULL,
    [Claims]      VARCHAR (50)     NULL,
    [CreatedOn]   DATETIME2 (7)    CONSTRAINT [DF_Appuser_CreatedOn] DEFAULT (getutcdate()) NOT NULL,
    [CreatedBy]   VARCHAR (50)     NULL,
    [UpdateOn]    DATETIME2 (7)    NULL,
    [UpdateBy]    VARCHAR (50)     NULL,
    [IsActive]    BIT              CONSTRAINT [DF_Appuser_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Appuser] PRIMARY KEY CLUSTERED ([Id] ASC)
);

