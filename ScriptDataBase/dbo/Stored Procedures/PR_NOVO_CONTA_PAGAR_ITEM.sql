
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PR_NOVO_CONTA_PAGAR_ITEM]
	-- Add the parameters for the stored procedure here
	@CODIGO_CONTA_PAGAR INT,
	@CODIGO_CONTA_BANCO INT = NULL,
	@VALOR_PARCELA_PAGAR FLOAT,
	@DATA_PAGAMENTO_PAGAR DATETIME = NULL,
	@DATA_VENCIMENTO_PAGAR DATETIME,
	@NUMERO_PARCELA_PAGAR INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO MOV_CONTA_PAGAR_ITEM (
		CODIGO_CONTA_PAGAR,
		CODIGO_CONTA_BANCO,
		VALOR_PARCELA_PAGAR,
		DATA_PAGAMENTO_PAGAR,
		DATA_VENCIMENTO_PAGAR,
		NUMERO_PARCELA_PAGAR)
	VALUES (
		@CODIGO_CONTA_PAGAR,
		@CODIGO_CONTA_BANCO,
		@VALOR_PARCELA_PAGAR,
		@DATA_PAGAMENTO_PAGAR,
		@DATA_VENCIMENTO_PAGAR,
		@NUMERO_PARCELA_PAGAR)


END