-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE PR_ATUALIZA_CONTA_BANCO 
	-- Add the parameters for the stored procedure here
	@ID_CONTA_BANCO INT,
	@DESCRICAO_CONTA_BANCO VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE CAD_CONTA_BANCO SET
		DESCRICAO_CONTA_BANCO = @DESCRICAO_CONTA_BANCO
	WHERE ID_CONTA_BANCO = @ID_CONTA_BANCO
END