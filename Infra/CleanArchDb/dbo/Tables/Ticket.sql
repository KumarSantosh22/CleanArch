CREATE TABLE [dbo].[Ticket] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [Name]      VARCHAR (50)     NULL,
    [UserId]    UNIQUEIDENTIFIER NULL,
    [CreatedOn] DATETIME2 (7)    CONSTRAINT [DF_Ticket_CreatedOn] DEFAULT (getutcdate()) NOT NULL,
    [CreatedBy] VARCHAR (50)     CONSTRAINT [DF_Ticket_CreatedBy] DEFAULT ('SYSTEM') NULL,
    [UpdatedOn] DATETIME2 (7)    NULL,
    [UpdatedBy] VARCHAR (50)     CONSTRAINT [DF_Ticket_UpdatedBy] DEFAULT ('SYSTEM') NULL,
    [IsActive]  BIT              CONSTRAINT [DF_Ticket_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED ([Id] ASC)
);



