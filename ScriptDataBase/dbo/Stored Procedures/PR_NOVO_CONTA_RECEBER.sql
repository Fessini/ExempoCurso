﻿
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PR_NOVO_CONTA_RECEBER]
	-- Add the parameters for the stored procedure here
	@CODIGO_CLIENTE INT,
	@NUMERO_DOCUMENTO_RECEBER VARCHAR(20) = NULL,
	@DATA_EMISSAO_RECEBER DATETIME,
	@VALOR_CONTA_RECEBER FLOAT,
	@STATUS_CONTA_RECEBER CHAR(1),
	@OBS_CONTA_RECEBER VARCHAR(400) = NULL,
	@DATA_VENCIMENTO_RECEBER DATETIME

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @CODIGO_RECEBER INT;

    -- Insert statements for procedure here
	INSERT INTO MOV_CONTA_RECEBER (
		CODIGO_CLIENTE,
		NUMERO_DOCUMENTO_RECEBER,
		DATA_EMISSAO_RECEBER,
		VALOR_CONTA_RECEBER,
		STATUS_CONTA_RECEBER,
		OBS_CONTA_RECEBER,
		DATA_INCLUSAO,
		DATA_VENCIMENTO_RECEBER)
	VALUES (
		@CODIGO_CLIENTE,
		@NUMERO_DOCUMENTO_RECEBER,
		@DATA_EMISSAO_RECEBER,
		@VALOR_CONTA_RECEBER,
		@STATUS_CONTA_RECEBER,
		@OBS_CONTA_RECEBER,
		GETDATE(),
		@DATA_VENCIMENTO_RECEBER)

	SET @CODIGO_RECEBER = SCOPE_IDENTITY();
	SELECT @CODIGO_RECEBER;
END