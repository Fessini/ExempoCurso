
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PR_NOVO_CONTA_PAGAR]
	-- Add the parameters for the stored procedure here
	@CODIGO_FORNECEDOR INT,
	@NUMERO_DOCUMENTO_PAGAR VARCHAR(20) = NULL,
	@DATA_EMISSAO_PAGAR DATETIME,
	@VALOR_CONTA_PAGAR FLOAT,
	@STATUS_CONTA_PAGAR CHAR(1),
	@OBS_CONTA_PAGAR VARCHAR(400) = NULL

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @CODIGO_PAGAR INT;

    -- Insert statements for procedure here
	INSERT INTO MOV_CONTA_PAGAR (
		CODIGO_FORNECEDOR,
		NUMERO_DOCUMENTO_PAGAR,
		DATA_EMISSAO_PAGAR,
		VALOR_CONTA_PAGAR,
		STATUS_CONTA_PAGAR,
		OBS_CONTA_PAGAR)
	VALUES (
		@CODIGO_FORNECEDOR,
		@NUMERO_DOCUMENTO_PAGAR,
		@DATA_EMISSAO_PAGAR,
		@VALOR_CONTA_PAGAR,
		@STATUS_CONTA_PAGAR,
		@OBS_CONTA_PAGAR)

	SET @CODIGO_PAGAR = SCOPE_IDENTITY();
	SELECT @CODIGO_PAGAR;
END