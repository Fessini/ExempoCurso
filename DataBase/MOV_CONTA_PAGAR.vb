Imports System.Data.SqlClient
Public Class MOV_CONTA_PAGAR
#Region "Propriedades"
    'PROPRIEDADES DA TABELA MOV_CONTA_PAGAR
    Public Property ID_CONTA_PAGAR As Integer
    Public Property CODIGO_FORNECEDOR As Integer
    Public Property NUMERO_DOCUMENTO_PAGAR As String
    Public Property DATA_EMISSAO_PAGAR As Object = Nothing
    Public Property VALOR_CONTA_PAGAR As Double
    Public Property STATUS_CONTA_PAGAR As String
    Public Property OBS_CONTA_PAGAR As String
    '
    'PROPRIEDADES DA TABELA MOV_CONTA_PAGAR_ITEM
    Public Property ID_MOV_CONTA_ITEM As Integer
    Public Property CODIGO_CONTA_PAGAR As Integer
    Public Property CODIGO_CONTA_BANCO As Integer
    Public Property VALOR_PARCELA_PAGAR As Integer
    Public Property DATA_PAGAMENTO_PAGAR As Object = Nothing
    Public Property DATA_VENCIMENTO_PAGAR As Object = Nothing
    Public Property NUMERO_PARCELA_PAGAR As Integer
#End Region

#Region "Constantes"
    Public Const Aberto As Char = "A"
    Public Const Pago As Char = "P"
    Public Const Cancelado As Char = "C"
#End Region

#Region "Métodos"
    ''' <summary>
    ''' Adiciona um nova conta a PAGAR no banco de dados.
    ''' </summary>
    ''' <returns>True: conta adicionada. False: conta não adicionada.</returns>
    Public Function NovaConta(ByVal parcelas As DataTable) As Boolean
        Dim retorno As Boolean
        Dim par As List(Of SqlParameter)
        Dim banco As DataAccess

        Try
            'VERIFICA DADOS MOV_CONTA_PAGAR
            If CODIGO_FORNECEDOR = 0 Then
                Throw New Exception("Informe a propriedade CODIGO_FORNECEDOR")
            End If
            If DATA_EMISSAO_PAGAR Is Nothing Then
                Throw New Exception("Informe a propriedade DATA_EMISSAO_PAGAR")
            End If
            If VALOR_CONTA_PAGAR = 0 Then
                Throw New Exception("Informe a propriedade VALOR_CONTA_PAGAR")
            End If
            If STATUS_CONTA_PAGAR.Length = 0 Then
                Throw New Exception("Informe a propriedade VALOR_CONTA_PAGAR")
            End If
            '
            'INSTANCIAR A CLASSE DO BANCO
            banco = New DataAccess
            '
            'ADICIONA OS PARÂMETROS
            par = New List(Of SqlParameter)
            par.Add(New SqlParameter("@CODIGO_FORNECEDOR", CODIGO_FORNECEDOR))
            If NUMERO_DOCUMENTO_PAGAR.Length > 0 Then par.Add(New SqlParameter("@NUMERO_DOCUMENTO_PAGAR", NUMERO_DOCUMENTO_PAGAR))
            par.Add(New SqlParameter("@DATA_EMISSAO_PAGAR", DATA_EMISSAO_PAGAR))
            par.Add(New SqlParameter("@VALOR_CONTA_PAGAR", VALOR_CONTA_PAGAR))
            par.Add(New SqlParameter("@STATUS_CONTA_PAGAR", STATUS_CONTA_PAGAR))
            If OBS_CONTA_PAGAR.Length > 0 Then par.Add(New SqlParameter("@OBS_CONTA_PAGAR", OBS_CONTA_PAGAR))
            '
            'EXECUTRA A PROCEDURE
            retorno = banco.ExecuteStoreProcedureRetorno("PR_NOVO_CONTA_PAGAR", par)
            '
            'ADICIONA AS PARCELAS
            If retorno = True Then
                For Each Linha As DataRow In parcelas.Rows
                    par = Nothing
                    par = New List(Of SqlParameter)
                    par.Add(New SqlParameter("@CODIGO_CONTA_PAGAR", banco.RetornoValor))
                    par.Add(New SqlParameter("@VALOR_PARCELA_PAGAR", Linha.Item("VALOR_PARCELA_PAGAR")))
                    par.Add(New SqlParameter("@DATA_VENCIMENTO_PAGAR", Linha.Item("DATA_VENCIMENTO_PAGAR")))
                    par.Add(New SqlParameter("@NUMERO_PARCELA_PAGAR", Linha.Item("NUMERO_PARCELA_PAGAR")))
                    '
                    'EXECUTRA A PROCEDURE
                    retorno = banco.ExecuteStoreProcedure("PR_NOVO_CONTA_PAGAR_ITEM", par)
                    If retorno = False Then Exit For
                Next
            End If
            '
            'FECHAR A CONEXÃO
            banco.CloseConn()
            '
            'RETORNO
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Atualiza uma conta no banco de dados.
    ''' </summary>
    ''' <returns>True: conta alterada. False: conta não alterada.</returns>
    Public Function AtualizaConta() As Boolean
        Dim retorno As Boolean
        Dim par As List(Of SqlParameter)
        Dim banco As DataAccess

        Try
            'VERIFICA DADOS MOV_CONTA_PAGAR
            If ID_CONTA_PAGAR = 0 Then
                Throw New Exception("Informe a propriedade ID_CONTA_PAGAR")
            End If
            If CODIGO_FORNECEDOR = 0 Then
                Throw New Exception("Informe a propriedade CODIGO_CLIENTE")
            End If
            If DATA_EMISSAO_PAGAR Is Nothing Then
                Throw New Exception("Informe a propriedade DATA_EMISSAO_PAGAR")
            End If
            If VALOR_CONTA_PAGAR = 0 Then
                Throw New Exception("Informe a propriedade VALOR_CONTA_PAGAR")
            End If
            If STATUS_CONTA_PAGAR.Length = 0 Then
                Throw New Exception("Informe a propriedade VALOR_CONTA_PAGAR")
            End If
            '
            'INSTANCIAR A CLASSE DO BANCO
            banco = New DataAccess
            '
            'ADICIONA OS PARÂMETROS
            par = New List(Of SqlParameter)
            par.Add(New SqlParameter("@ID_CONTA_PAGAR", ID_CONTA_PAGAR))
            par.Add(New SqlParameter("@CODIGO_CLIENTE", CODIGO_FORNECEDOR))
            If NUMERO_DOCUMENTO_PAGAR.Length > 0 Then par.Add(New SqlParameter("@NUMERO_DOCUMENTO_PAGAR", NUMERO_DOCUMENTO_PAGAR))
            par.Add(New SqlParameter("@DATA_EMISSAO_PAGAR", DATA_EMISSAO_PAGAR))
            par.Add(New SqlParameter("@VALOR_CONTA_PAGAR", VALOR_CONTA_PAGAR))
            par.Add(New SqlParameter("@STATUS_CONTA_PAGAR", STATUS_CONTA_PAGAR))
            If OBS_CONTA_PAGAR.Length > 0 Then par.Add(New SqlParameter("@OBS_CONTA_PAGAR", OBS_CONTA_PAGAR))
            '
            'EXECUTRA A PROCEDURE
            retorno = banco.ExecuteStoreProcedureRetorno("PR_ATUALIZA_CONTA_PAGAR", par)
            '
            'FECHAR A CONEXÃO
            banco.CloseConn()
            '
            'RETORNO
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ManipulaParcelas(ByVal parcelas As DataTable) As Boolean
        Dim retorno As Boolean
        Dim par As List(Of SqlParameter)
        Dim banco As DataAccess

        Try
            'INSTANCIAR A CLASSE DO BANCO
            banco = New DataAccess
            '
            For Each Linha As DataRow In parcelas.Rows
                par = Nothing
                par = New List(Of SqlParameter)
                par.Add(New SqlParameter("@CODIGO_CONTA_PAGAR", banco.RetornoValor))
                par.Add(New SqlParameter("@VALOR_PARCELA_PAGAR", Linha.Item("VALOR_PARCELA_PAGAR")))
                par.Add(New SqlParameter("@DATA_VENCIMENTO_PAGAR", Linha.Item("DATA_VENCIMENTO_PAGAR")))
                par.Add(New SqlParameter("@NUMERO_PARCELA_PAGAR", Linha.Item("NUMERO_PARCELA_PAGAR")))
                If Not IsDBNull(Linha.Item("STATUS")) Then
                    If Linha.Item("STATUS") = "I" Then
                        'EXECUTRA A PROCEDURE
                        retorno = banco.ExecuteStoreProcedure("PR_NOVO_CONTA_PAGAR_ITEM", par)
                        If retorno = False Then Exit For
                    ElseIf Linha.Item("STATUS") = "E" Then
                        par.Add(New SqlParameter("@ID_MOV_CONTA_ITEM", ID_MOV_CONTA_ITEM))
                        par.Add(New SqlParameter("@CODIGO_CONTA_BANCO", CODIGO_CONTA_BANCO))
                        par.Add(New SqlParameter("@DATA_PAGAMENTO_PAGAR", DATA_PAGAMENTO_PAGAR))
                        'EXECUTRA A PROCEDURE
                        retorno = banco.ExecuteStoreProcedure("PR_ATUALIZA_CONTA_PAGAR_ITEM", par)
                        If retorno = False Then Exit For
                    ElseIf Linha.Item("STATUS") = "D" Then
                        par.Add(New SqlParameter("@ID_MOV_CONTA_ITEM", ID_MOV_CONTA_ITEM))
                        'EXECUTRA A PROCEDURE
                        retorno = banco.ExecuteStoreProcedure("PR_DELETA_CONTA_PAGAR_ITEM", par)
                        If retorno = False Then Exit For
                    End If
                End If
            Next
            'FECHAR A CONEXÃO
            banco.CloseConn()
            '
            'RETORNO
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Busca um documento no bando de dados.
    ''' </summary>
    ''' <returns>True: documento encontrado. False: documento não encontrado.</returns>
    Public Function BuscaDocumento() As Boolean
        Dim retorno As Boolean = False
        Dim par As List(Of SqlParameter)
        Dim banco As DataAccess
        Dim dr As IDataReader

        Try
            'VERIFICA DADOS
            If ID_CONTA_PAGAR = 0 Then
                Throw New Exception("Informe a propriedade ID_CONTA_PAGAR")
            End If
            '
            'INSTANCIAR A CLASSE DO BANCO
            banco = New DataAccess
            '
            'ADICIONA OS PARÂMETROS
            par = New List(Of SqlParameter)
            par.Add(New SqlParameter("@ID_CONTA_PAGAR", ID_CONTA_PAGAR))
            '
            'EXECUTRA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("PR_BUSCA_MOV_CONTA_PAGAR", par)
            '
            'PREENCHER AS PROPRIEDADES
            While dr.Read

                CODIGO_FORNECEDOR = dr("CODIGO_CLIENTE")
                If Not IsDBNull(dr("NUMERO_DOCUMENTO_PAGAR")) Then NUMERO_DOCUMENTO_PAGAR = dr("NUMERO_DOCUMENTO_PAGAR")
                DATA_EMISSAO_PAGAR = dr("DATA_EMISSAO_PAGAR")
                VALOR_CONTA_PAGAR = dr("VALOR_CONTA_PAGAR")
                STATUS_CONTA_PAGAR = dr("STATUS_CONTA_PAGAR")
                If Not IsDBNull(dr("OBS_CONTA_PAGAR")) Then OBS_CONTA_PAGAR = dr("OBS_CONTA_PAGAR")
                retorno = True
            End While
            '
            'FECHAR A CONEXÃO
            banco.CloseConn()
            '
            'RETORNO
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Busca as parcelas do documento informado.
    ''' </summary>
    ''' <returns></returns>
    Public Function BuscaParcelas(ByVal idConta As Integer) As DataTable
        Dim tabela As New DataTable
        Dim par As List(Of SqlParameter)
        Dim banco As DataAccess

        Try
            '
            'INSTANCIAR A CLASSE DO BANCO
            banco = New DataAccess
            '
            'ADICIONA OS PARÂMETROS
            par = New List(Of SqlParameter)
            par.Add(New SqlParameter("@ID_CONTA_PAGAR", idConta))
            '
            'EXECUTRA A PROCEDURE
            tabela = banco.ExecutaStoreProcedureDataTable("PR_BUSCA_PARCELAS_CONTA_PAGAR_ITEM", par)
            '
            'FECHAR A CONEXÃO
            banco.CloseConn()
            '
            'RETORNO
            Return tabela
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
End Class
