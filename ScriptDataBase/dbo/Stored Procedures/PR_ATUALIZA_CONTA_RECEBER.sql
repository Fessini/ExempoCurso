﻿
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PR_ATUALIZA_CONTA_RECEBER]
	-- Add the parameters for the stored procedure here
	@ID_CONTA_RECEBER INT,
	@CODIGO_CLIENTE INT,
	@NUMERO_DOCUMENTO_RECEBER VARCHAR(20) = NULL,
	@DATA_EMISSAO_RECEBER DATETIME,
	@VALOR_CONTA_RECEBER FLOAT,
	@STATUS_CONTA_RECEBER CHAR(1),
	@OBS_CONTA_RECEBER VARCHAR(400) = NULL

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
		
    -- Insert statements for procedure here
	UPDATE MOV_CONTA_RECEBER SET
		CODIGO_CLIENTE = @CODIGO_CLIENTE,
		NUMERO_DOCUMENTO_RECEBER = @NUMERO_DOCUMENTO_RECEBER,
		DATA_EMISSAO_RECEBER = @DATA_EMISSAO_RECEBER,
		VALOR_CONTA_RECEBER = @VALOR_CONTA_RECEBER,
		STATUS_CONTA_RECEBER = @STATUS_CONTA_RECEBER,
		OBS_CONTA_RECEBER = @OBS_CONTA_RECEBER
	WHERE ID_CONTA_RECEBER = @ID_CONTA_RECEBER

	
END