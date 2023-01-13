
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PR_BUSCA_PARCELAS_CONTA_RECEBER_ITEM]
	-- Add the parameters for the stored procedure here
	@ID_CONTA_RECEBER INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM VW_PARCELA_RECEBER WHERE CODIGO_CONTA_RECEBER = @ID_CONTA_RECEBER
END