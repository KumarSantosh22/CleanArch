CREATE TABLE [dbo].[StripeCustomer] (
    [Id]        VARCHAR (50)     NOT NULL,
    [Name]      VARCHAR (50)     NOT NULL,
    [UserId]    UNIQUEIDENTIFIER NULL,
    [IsActive]  BIT              CONSTRAINT [DF_StripeCustomer_IsActive] DEFAULT ((1)) NOT NULL,
    [CreatedOn] DATETIME2 (7)    CONSTRAINT [DF_StripeCustomer_CreatedOn] DEFAULT (getutcdate()) NOT NULL,
    [CreatedBy] VARCHAR (50)     CONSTRAINT [DF_StripeCustomer_CreatedBy] DEFAULT ('SYSTEM') NULL,
    CONSTRAINT [PK_StripeCustomer] PRIMARY KEY CLUSTERED ([Id] ASC)
);

