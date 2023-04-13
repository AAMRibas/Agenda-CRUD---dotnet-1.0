CREATE TABLE [dbo].[Pessoas] (
    [ContatosID]      INT         IDENTITY (1, 1) NOT NULL,
    [Nome]            NCHAR (18) NULL,
    [Empresa]         NCHAR (18) NULL,
    [Telefone]        NCHAR (18) NULL,
    [Email]           NCHAR (18) NULL,
    [Cliente]         BIT         NULL,
    [Ultimo Contacto] DATETIME    NULL,
    PRIMARY KEY CLUSTERED ([ContatosID] ASC)
);

