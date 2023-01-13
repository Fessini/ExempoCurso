-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE PR_BUSCA_MOV_CONTA_RECEBER
	-- Add the parameters for the stored procedure here
	@ID_CONTA_RECEBER INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM MOV_CONTA_RECEBER WHERE ID_CONTA_RECEBER = @ID_CONTA_RECEBER
END