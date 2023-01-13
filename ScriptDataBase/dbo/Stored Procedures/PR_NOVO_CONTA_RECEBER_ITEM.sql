-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE PR_NOVO_CONTA_RECEBER_ITEM
	-- Add the parameters for the stored procedure here
	@CODIGO_CONTA_RECEBER INT,
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
	INSERT INTO MOV_CONTA_RECEBER_ITEM (
		CODIGO_CONTA_RECEBER,
		CODIGO_CONTA_BANCO,
		VALOR_PARCELA_RECEBER,
		DATA_PAGAMENTO_RECEBER,
		DATA_VENCIMENTO_RECEBER,
		NUMERO_PARCELA_RECEBER)
	VALUES (
		@CODIGO_CONTA_RECEBER,
		@CODIGO_CONTA_BANCO,
		@VALOR_PARCELA_RECEBER,
		@DATA_PAGAMENTO_RECEBER,
		@DATA_VENCIMENTO_RECEBER,
		@NUMERO_PARCELA_RECEBER)


END