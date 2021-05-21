
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PR_BUSCA_PARCELAS_CONTA_PAGAR_ITEM]
	-- Add the parameters for the stored procedure here
	@ID_CONTA_PAGAR INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM MOV_CONTA_PAGAR_ITEM WHERE CODIGO_CONTA_PAGAR = @ID_CONTA_PAGAR
END