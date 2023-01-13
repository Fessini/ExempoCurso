
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PR_BUSCA_FORNECEDOR]
	-- Add the parameters for the stored procedure here
	@ID_FORNECEDOR INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM CAD_FORNECEDOR WHERE ID_FORNECEDOR = @ID_FORNECEDOR
END