﻿

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PR_ATUALIZA_CONTA_RECEBER_ITEM]
	-- Add the parameters for the stored procedure here
	@ID_MOV_CONTA_ITEM INT,
	@CODIGO_CONTA_BANCO INT = NULL,
	@VALOR_PARCELA_RECEBER FLOAT,
	@DATA_PAGAMENTO_RECEBER DATETIME = NULL,
	@DATA_VENCIMENTO_RECEBER DATETIME,
	@NUMERO_PARCELA_RECEBER INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE MOV_CONTA_RECEBER_ITEM SET
		CODIGO_CONTA_BANCO = @CODIGO_CONTA_BANCO,
		VALOR_PARCELA_RECEBER = @VALOR_PARCELA_RECEBER,
		DATA_PAGAMENTO_RECEBER = @DATA_PAGAMENTO_RECEBER,
		DATA_VENCIMENTO_RECEBER = @DATA_VENCIMENTO_RECEBER,
		NUMERO_PARCELA_RECEBER = @NUMERO_PARCELA_RECEBER
	WHERE ID_MOV_CONTA_ITEM = @ID_MOV_CONTA_ITEM


END