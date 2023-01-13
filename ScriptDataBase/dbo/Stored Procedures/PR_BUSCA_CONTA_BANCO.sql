-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE PR_BUSCA_CONTA_BANCO 
	-- Add the parameters for the stored procedure here
	@ID_CONTA_BANCO INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM CAD_CONTA_BANCO WHERE ID_CONTA_BANCO = @ID_CONTA_BANCO
END