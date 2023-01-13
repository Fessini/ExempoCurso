


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PR_ATUALIZA_CONTA_PAGAR_ITEM]
	-- Add the parameters for the stored procedure here
	@ID_MOV_CONTA_ITEM INT,
	@CODIGO_CONTA_PAGAR INT,
	@CODIGO_CONTA_BANCO INT = NULL,
	@VALOR_PARCELA_PAGAR FLOAT,
	@DATA_PAGAMENTO_PAGAR DATETIME = NULL,
	@DATA_VENCIMENTO_PAGAR DATETIME,
	@NUMERO_PARCELA_PAGAR INT,
	@VALOR_PAGO FLOAT = NULL

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE MOV_CONTA_PAGAR_ITEM SET
		CODIGO_CONTA_PAGAR = @CODIGO_CONTA_PAGAR,
		CODIGO_CONTA_BANCO = @CODIGO_CONTA_BANCO,
		VALOR_PARCELA_PAGAR = @VALOR_PARCELA_PAGAR,
		DATA_PAGAMENTO_PAGAR = @DATA_PAGAMENTO_PAGAR,
		DATA_VENCIMENTO_PAGAR = @DATA_VENCIMENTO_PAGAR,
		NUMERO_PARCELA_PAGAR = @NUMERO_PARCELA_PAGAR,
		VALOR_PAGO = @VALOR_PAGO
	WHERE ID_MOV_CONTA_ITEM = @ID_MOV_CONTA_ITEM


END