﻿

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PR_BUSCA_FORNECEDORS] 
	-- Add the parameters for the stored procedure here
	@TIPO CHAR(1) = NULL,
	@NOME VARCHAR(200) = NULL,
	@CPFCNPJ VARCHAR(18) = NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @SQL VARCHAR(500);

    -- Insert statements for procedure here
	SET @SQL = 'SELECT * FROM CAD_FORNECEDOR WHERE ID_FORNECEDOR IS NOT NULL';

	IF (@TIPO IS NOT NULL)
	BEGIN
		SET @SQL = @SQL + ' AND TIPO_FORNECEDOR = ''' + CONVERT(VARCHAR, @TIPO) + '''';
	END

	IF (@NOME IS NOT NULL)
	BEGIN
		SET @SQL = @SQL + ' AND NOME_FORNECEDOR LIKE ''%' + CONVERT(VARCHAR,@NOME) + '%''';
	END

	IF (@CPFCNPJ IS NOT NULL)
	BEGIN
		SET @SQL = @SQL + ' AND CPF_CNPJ_FORNECEDOR = ''' + CONVERT(VARCHAR, @CPFCNPJ) + '''';
	END

	EXECUTE(@SQL);
END