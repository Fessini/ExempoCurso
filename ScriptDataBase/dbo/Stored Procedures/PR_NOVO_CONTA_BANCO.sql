-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE PR_NOVO_CONTA_BANCO 
	-- Add the parameters for the stored procedure here
	@DESCRICAO_CONTA_BANCO VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO CAD_CONTA_BANCO 
		(DESCRICAO_CONTA_BANCO) 
	VALUES 
		(@DESCRICAO_CONTA_BANCO)
END