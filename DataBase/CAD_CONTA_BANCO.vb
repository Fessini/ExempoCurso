Imports System.Data.SqlClient
Public Class CAD_CONTA_BANCO
#Region "Propriedades"
    Public Property ID_CONTA_BANCO As Integer
    Public Property DESCRICAO_CONTA_BANCO As String

#End Region

#Region "Métodos"
    ''' <summary>
    ''' Adiciona um novo banco no banco de dados.
    ''' </summary>
    ''' <returns>True: banco adicionado. False: banco não adicionado.</returns>
    Public Function NovoBanco() As Boolean
        Dim retorno As Boolean
        Dim par As List(Of SqlParameter)
        Dim banco As DataAccess

        Try
            'VERIFICA DADOS
            If DESCRICAO_CONTA_BANCO.Length = 0 Then
                Throw New Exception("Informe a propriedade DESCRICAO_CONTA_BANCO")
            End If
            '
            'INSTANCIAR A CLASSE DO BANCO
            banco = New DataAccess
            '
            'ADICIONA OS PARÂMETROS
            par = New List(Of SqlParameter)
            par.Add(New SqlParameter("@DESCRICAO_CONTA_BANCO", DESCRICAO_CONTA_BANCO))
            '
            'EXECUTRA A PROCEDURE
            retorno = banco.ExecuteStoreProcedure("PR_NOVO_CONTA_BANCO", par)
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
    ''' Atualiza um banco no banco de dados.
    ''' </summary>
    ''' <returns>True: banco alterado. False: banco não alterado.</returns>
    Public Function AtualizaBanco() As Boolean
        Dim retorno As Boolean
        Dim par As List(Of SqlParameter)
        Dim banco As DataAccess

        Try
            'VERIFICA DADOS
            If ID_CONTA_BANCO = 0 Then
                Throw New Exception("Informe a propriedade ID_CONTA_BANCO")
            End If
            '
            'INSTANCIAR A CLASSE DO BANCO
            banco = New DataAccess
            '
            'ADICIONA OS PARÂMETROS
            par = New List(Of SqlParameter)
            par.Add(New SqlParameter("@ID_CONTA_BANCO", ID_CONTA_BANCO))
            par.Add(New SqlParameter("@DESCRICAO_CONTA_BANCO", DESCRICAO_CONTA_BANCO))
            '
            'EXECUTRA A PROCEDURE
            retorno = banco.ExecuteStoreProcedure("PR_ATUALIZA_CONTA_BANCO", par)
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
    ''' Busca um banco no bando de dados.
    ''' </summary>
    ''' <returns>True: banco encontrado. False: banco não encontrado.</returns>
    Public Function BuscaCliente() As Boolean
        Dim retorno As Boolean = False
        Dim par As List(Of SqlParameter)
        Dim banco As DataAccess
        Dim dr As IDataReader

        Try
            'VERIFICA DADOS
            If ID_CONTA_BANCO = 0 Then
                Throw New Exception("Informe a propriedade ID_CONTA_BANCO")
            End If
            '
            'INSTANCIAR A CLASSE DO BANCO
            banco = New DataAccess
            '
            'ADICIONA OS PARÂMETROS
            par = New List(Of SqlParameter)
            par.Add(New SqlParameter("@ID_CONTA_BANCO", ID_CONTA_BANCO))
            '
            'EXECUTRA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("PR_BUSCA_CONTA_BANCO", par)
            '
            'PREENCHER AS PROPRIEDADES
            While dr.Read
                ID_CONTA_BANCO = dr("ID_CONTA_BANCO")
                DESCRICAO_CONTA_BANCO = dr("DESCRICAO_CONTA_BANCO")
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
    ''' Busca bancos de acordo com o filtro selecionado.
    ''' </summary>
    ''' <returns></returns>
    Public Function BuscaBancos(Optional ByVal descricao As String = "") As DataTable
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
            If descricao <> "" Then par.Add(New SqlParameter("@DESCRICAO", descricao))
            '
            'EXECUTRA A PROCEDURE
            tabela = banco.ExecutaStoreProcedureDataTable("PR_BUSCA_CONTA_BANCOS", par)
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
