-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE PR_BUSCA_CLIENTE
	-- Add the parameters for the stored procedure here
	@ID_CLIENTE INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM CAD_CLIENTE WHERE ID_CLIENTE = @ID_CLIENTE
END