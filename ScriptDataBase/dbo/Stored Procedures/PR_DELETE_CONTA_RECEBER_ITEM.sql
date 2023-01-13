
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PR_DELETE_CONTA_RECEBER_ITEM]
	-- Add the parameters for the stored procedure here
	@ID_MOV_CONTA_ITEM INT
	

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM MOV_CONTA_RECEBER_ITEM WHERE ID_MOV_CONTA_ITEM = @ID_MOV_CONTA_ITEM


END