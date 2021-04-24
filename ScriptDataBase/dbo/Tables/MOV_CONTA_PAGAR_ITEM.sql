﻿CREATE TABLE [dbo].[MOV_CONTA_PAGAR_ITEM] (
    [ID_MOV_CONTA_ITEM]     INT        IDENTITY (1, 1) NOT NULL,
    [CODIGO_CONTA_PAGAR]    INT        NOT NULL,
    [CODIGO_CONTA_BANCO]    INT        NOT NULL,
    [VALOR_PARCELA_PAGAR]   FLOAT (53) NOT NULL,
    [DATA_PAGAMENTO_PAGAR]  DATETIME   NOT NULL,
    [DATA_VENCIMENTO_PAGAR] DATETIME   NOT NULL,
    [NUMERO_PARCELA_PAGAR]  INT        NOT NULL,
    CONSTRAINT [PK_MOV_CONTA_PAGAR_ITEM] PRIMARY KEY CLUSTERED ([ID_MOV_CONTA_ITEM] ASC),
    CONSTRAINT [FK_MOV_CONTA_PAGAR_ITEM_CAD_CONTA_BANCO] FOREIGN KEY ([CODIGO_CONTA_BANCO]) REFERENCES [dbo].[CAD_CONTA_BANCO] ([ID_CONTA_BANCO]),
    CONSTRAINT [FK_MOV_CONTA_PAGAR_ITEM_MOV_CONTA_PAGAR] FOREIGN KEY ([CODIGO_CONTA_PAGAR]) REFERENCES [dbo].[MOV_CONTA_PAGAR] ([ID_CONTA_PAGAR])
);
