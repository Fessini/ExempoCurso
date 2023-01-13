

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PR_ATUALIZA_CONTA_PAGAR]
	-- Add the parameters for the stored procedure here
	@ID_CONTA_PAGAR INT,
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
		
    -- Insert statements for procedure here
	UPDATE MOV_CONTA_PAGAR SET
		CODIGO_FORNECEDOR = @CODIGO_FORNECEDOR,
		NUMERO_DOCUMENTO_PAGAR = @NUMERO_DOCUMENTO_PAGAR,
		DATA_EMISSAO_PAGAR = @DATA_EMISSAO_PAGAR,
		VALOR_CONTA_PAGAR = @VALOR_CONTA_PAGAR,
		STATUS_CONTA_PAGAR = @STATUS_CONTA_PAGAR,
		OBS_CONTA_PAGAR = @OBS_CONTA_PAGAR
	WHERE ID_CONTA_PAGAR = @ID_CONTA_PAGAR

	
END