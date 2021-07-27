Imports System.Data.SqlClient
Public Class MOV_CONTA_RECEBER
#Region "Propriedades"
    'PROPRIEDADES DA TABELA MOV_CONTA_RECEBER
    Public Property ID_CONTA_RECEBER As Integer
    Public Property CODIGO_CLIENTE As Integer
    Public Property NUMERO_DOCUMENTO_RECEBER As String
    Public Property DATA_EMISSAO_RECEBER As Object = Nothing
    Public Property VALOR_CONTA_RECEBER As Double
    Public Property STATUS_CONTA_RECEBER As String
    Public Property OBS_CONTA_RECEBER As String
    Public Property DATA_INCLUSAO As Object
    '
    'PROPRIEDADES DA TABELA MOV_CONTA_RECEBER_ITEM
    Public Property ID_MOV_CONTA_ITEM As Integer
    Public Property CODIGO_CONTA_RECEBER As Integer
    Public Property CODIGO_CONTA_BANCO As Integer
    Public Property NOME_BANCO As String
    Public Property VALOR_PARCELA_RECEBER As Double
    Public Property DATA_PAGAMENTO_RECEBER As Object = Nothing
    Public Property DATA_VENCIMENTO_RECEBER As Object = Nothing
    Public Property NUMERO_PARCELA_RECEBER As Integer
#End Region

#Region "Constantes"
    Public Const Aberto As Char = "A"
    Public Const Pago As Char = "P"
    Public Const Cancelado As Char = "C"
    Public Const Ativo As Char = "A"
    Public Const Inativo As Char = "I"
#End Region

#Region "Métodos"
    ''' <summary>
    ''' Adiciona um nova conta a receber no banco de dados.
    ''' </summary>
    ''' <returns>True: conta adicionada. False: conta não adicionada.</returns>
    Public Function NovaConta(ByVal parcelas As DataTable) As Boolean
        Dim retorno As Boolean
        Dim par As List(Of SqlParameter)
        Dim banco As DataAccess

        Try
            'VERIFICA DADOS MOV_CONTA_RECEBER
            If CODIGO_CLIENTE = 0 Then
                Throw New Exception("Informe a propriedade CODIGO_CLIENTE")
            End If
            If DATA_EMISSAO_RECEBER Is Nothing Then
                Throw New Exception("Informe a propriedade DATA_EMISSAO_RECEBER")
            End If
            If VALOR_CONTA_RECEBER = 0 Then
                Throw New Exception("Informe a propriedade VALOR_CONTA_RECEBER")
            End If
            If STATUS_CONTA_RECEBER.Length = 0 Then
                Throw New Exception("Informe a propriedade VALOR_CONTA_RECEBER")
            End If
            '
            'INSTANCIAR A CLASSE DO BANCO
            banco = New DataAccess
            '
            'ADICIONA OS PARÂMETROS
            par = New List(Of SqlParameter)
            par.Add(New SqlParameter("@CODIGO_CLIENTE", CODIGO_CLIENTE))
            If NUMERO_DOCUMENTO_RECEBER.Length > 0 Then par.Add(New SqlParameter("@NUMERO_DOCUMENTO_RECEBER", NUMERO_DOCUMENTO_RECEBER))
            par.Add(New SqlParameter("@DATA_EMISSAO_RECEBER", DATA_EMISSAO_RECEBER))
            par.Add(New SqlParameter("@VALOR_CONTA_RECEBER", VALOR_CONTA_RECEBER))
            par.Add(New SqlParameter("@STATUS_CONTA_RECEBER", STATUS_CONTA_RECEBER))
            par.Add(New SqlParameter("@DATA_VENCIMENTO_RECEBER", DATA_VENCIMENTO_RECEBER))
            If OBS_CONTA_RECEBER.Length > 0 Then par.Add(New SqlParameter("@OBS_CONTA_RECEBER", OBS_CONTA_RECEBER))
            '
            'EXECUTRA A PROCEDURE
            retorno = banco.ExecuteStoreProcedureRetorno("PR_NOVO_CONTA_RECEBER", par)
            '
            'ADICIONA AS PARCELAS
            If retorno = True Then
                For Each Linha As DataRow In parcelas.Rows
                    par = Nothing
                    par = New List(Of SqlParameter)
                    par.Add(New SqlParameter("@CODIGO_CONTA_RECEBER", banco.RetornoValor))
                    par.Add(New SqlParameter("@VALOR_PARCELA_RECEBER", Linha.Item("VALOR_PARCELA_RECEBER")))
                    par.Add(New SqlParameter("@DATA_VENCIMENTO_RECEBER", Linha.Item("DATA_VENCIMENTO_RECEBER")))
                    par.Add(New SqlParameter("@NUMERO_PARCELA_RECEBER", Linha.Item("NUMERO_PARCELA_RECEBER")))
                    '
                    'EXECUTRA A PROCEDURE
                    retorno = banco.ExecuteStoreProcedure("PR_NOVO_CONTA_RECEBER_ITEM", par)
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
            'VERIFICA DADOS MOV_CONTA_RECEBER
            If ID_CONTA_RECEBER = 0 Then
                Throw New Exception("Informe a propriedade ID_CONTA_RECEBER")
            End If
            If CODIGO_CLIENTE = 0 Then
                Throw New Exception("Informe a propriedade CODIGO_CLIENTE")
            End If
            If DATA_EMISSAO_RECEBER Is Nothing Then
                Throw New Exception("Informe a propriedade DATA_EMISSAO_RECEBER")
            End If
            If VALOR_CONTA_RECEBER = 0 Then
                Throw New Exception("Informe a propriedade VALOR_CONTA_RECEBER")
            End If
            If STATUS_CONTA_RECEBER.Length = 0 Then
                Throw New Exception("Informe a propriedade VALOR_CONTA_RECEBER")
            End If
            '
            'INSTANCIAR A CLASSE DO BANCO
            banco = New DataAccess
            '
            'ADICIONA OS PARÂMETROS
            par = New List(Of SqlParameter)
            par.Add(New SqlParameter("@ID_CONTA_RECEBER", ID_CONTA_RECEBER))
            par.Add(New SqlParameter("@CODIGO_CLIENTE", CODIGO_CLIENTE))
            If NUMERO_DOCUMENTO_RECEBER.Length > 0 Then par.Add(New SqlParameter("@NUMERO_DOCUMENTO_RECEBER", NUMERO_DOCUMENTO_RECEBER))
            par.Add(New SqlParameter("@DATA_EMISSAO_RECEBER", DATA_EMISSAO_RECEBER))
            par.Add(New SqlParameter("@VALOR_CONTA_RECEBER", VALOR_CONTA_RECEBER))
            par.Add(New SqlParameter("@STATUS_CONTA_RECEBER", STATUS_CONTA_RECEBER))
            par.Add(New SqlParameter("@DATA_VENCIMENTO_RECEBER", DATA_VENCIMENTO_RECEBER))
            If OBS_CONTA_RECEBER.Length > 0 Then par.Add(New SqlParameter("@OBS_CONTA_RECEBER", OBS_CONTA_RECEBER))
            '
            'EXECUTRA A PROCEDURE
            retorno = banco.ExecuteStoreProcedure("PR_ATUALIZA_CONTA_RECEBER", par)
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

    Public Function ManipulaParcelas(ByVal parcelas As DataTable, ByVal idDocumento As Integer) As Boolean
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
                If Not IsDBNull(Linha.Item("ID_MOV_CONTA_ITEM")) Then par.Add(New SqlParameter("@ID_MOV_CONTA_ITEM", Linha.Item("ID_MOV_CONTA_ITEM")))

                If Not IsDBNull(Linha.Item("STATUS")) Then
                    If Linha.Item("STATUS") = "I" Then
                        'EXECUTRA A PROCEDURE
                        par.Add(New SqlParameter("@VALOR_PARCELA_RECEBER", Linha.Item("VALOR_PARCELA_RECEBER")))
                        par.Add(New SqlParameter("@DATA_VENCIMENTO_RECEBER", Linha.Item("DATA_VENCIMENTO_RECEBER")))
                        par.Add(New SqlParameter("@NUMERO_PARCELA_RECEBER", Linha.Item("NUMERO_PARCELA_RECEBER")))
                        par.Add(New SqlParameter("@CODIGO_CONTA_RECEBER", idDocumento))
                        retorno = banco.ExecuteStoreProcedure("PR_NOVO_CONTA_RECEBER_ITEM", par)
                        If retorno = False Then Exit For
                    ElseIf Linha.Item("STATUS") = "E" Then
                        par.Add(New SqlParameter("@VALOR_PARCELA_RECEBER", Linha.Item("VALOR_PARCELA_RECEBER")))
                        par.Add(New SqlParameter("@DATA_VENCIMENTO_RECEBER", Linha.Item("DATA_VENCIMENTO_RECEBER")))
                        par.Add(New SqlParameter("@NUMERO_PARCELA_RECEBER", Linha.Item("NUMERO_PARCELA_RECEBER")))
                        If CODIGO_CONTA_BANCO > 0 Then par.Add(New SqlParameter("@CODIGO_CONTA_BANCO", CODIGO_CONTA_BANCO))
                        par.Add(New SqlParameter("@DATA_PAGAMENTO_RECEBER", DATA_PAGAMENTO_RECEBER))
                        'EXECUTRA A PROCEDURE
                        retorno = banco.ExecuteStoreProcedure("PR_ATUALIZA_CONTA_RECEBER_ITEM", par)
                        If retorno = False Then Exit For
                    ElseIf Linha.Item("STATUS") = "D" Then
                        'EXECUTRA A PROCEDURE
                        retorno = banco.ExecuteStoreProcedure("PR_DELETE_CONTA_RECEBER_ITEM", par)
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
            If ID_CONTA_RECEBER = 0 Then
                Throw New Exception("Informe a propriedade ID_CONTA_RECEBER")
            End If
            '
            'INSTANCIAR A CLASSE DO BANCO
            banco = New DataAccess
            '
            'ADICIONA OS PARÂMETROS
            par = New List(Of SqlParameter)
            par.Add(New SqlParameter("@ID_CONTA_RECEBER", ID_CONTA_RECEBER))
            '
            'EXECUTRA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("PR_BUSCA_MOV_CONTA_RECEBER", par)
            '
            'PREENCHER AS PROPRIEDADES
            While dr.Read

                CODIGO_CLIENTE = dr("CODIGO_CLIENTE")
                If Not IsDBNull(dr("NUMERO_DOCUMENTO_RECEBER")) Then NUMERO_DOCUMENTO_RECEBER = dr("NUMERO_DOCUMENTO_RECEBER")
                DATA_EMISSAO_RECEBER = dr("DATA_EMISSAO_RECEBER")
                DATA_VENCIMENTO_RECEBER = dr("DATA_VENCIMENTO_RECEBER")
                VALOR_CONTA_RECEBER = dr("VALOR_CONTA_RECEBER")
                STATUS_CONTA_RECEBER = dr("STATUS_CONTA_RECEBER")
                DATA_INCLUSAO = dr("DATA_INCLUSAO")
                If Not IsDBNull(dr("OBS_CONTA_RECEBER")) Then OBS_CONTA_RECEBER = dr("OBS_CONTA_RECEBER")
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
            par.Add(New SqlParameter("@ID_CONTA_RECEBER", idConta))
            '
            'EXECUTRA A PROCEDURE
            tabela = banco.ExecutaStoreProcedureDataTable("PR_BUSCA_PARCELAS_CONTA_RECEBER_ITEM", par)
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
