
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PR_BUSCA_CONTA_BANCOS] 
	-- Add the parameters for the stored procedure here
	@DESCRICAO_CONTA_BANCO VARCHAR(50) = NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF (@DESCRICAO_CONTA_BANCO IS NOT NULL)
	BEGIN
		SELECT * FROM CAD_CONTA_BANCO WHERE DESCRICAO_CONTA_BANCO LIKE '%' + @DESCRICAO_CONTA_BANCO + '%'
	END
	IF (@DESCRICAO_CONTA_BANCO IS NULL)
	BEGIN
		SELECT * FROM CAD_CONTA_BANCO
	END
END