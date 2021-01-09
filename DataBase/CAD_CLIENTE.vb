Imports System.Data.SqlClient

Public Class CAD_CLIENTE
#Region "Propriedades"
    Public Property ID_CLIENTE As Integer
    Public Property NOME_CLIENTE As String
    Public Property TIPO_CLIENTE As Char
    Public Property FANTASIA_CLIENTE As String
    Public Property CPF_CNPJ_CLIENTE As String
    Public Property INSC_MUNICIPAL_CLIENTE As String
    Public Property INSC_ESTADUAL_CLIENTE As String
    Public Property FONE_CLIENTE_1 As String
    Public Property FONE_CLIENTE_2 As String
    Public Property EMAIL_CLIENTE As String
    Public Property CEP_CLIENTE As String
    Public Property ENDERECO_CLIENTE As String
    Public Property BAIRRO_CLIENTE As String
    Public Property CIDADE_CLIENTE As String
    Public Property UF As String
    Public Property COMPLEMENTO_CLIENTE As String
    Public Property DATA_INCLUSAO_CLIENTE As Date
    Public Property DATA_ALTERACAO_CLIENTE As Date
    Public Property NUMERO_CLIENTE As String
#End Region

#Region "Cosntantes"
    Public Const Fisico As Char = "F"
    Public Const Juridico As Char = "J"
#End Region

#Region "Métodos"
    ''' <summary>
    ''' Adiciona um novo cliente no banco de dados.
    ''' </summary>
    ''' <returns>True: cliente adicionado. False: cliente não adicionado.</returns>
    Public Function NovoCliente() As Boolean
        Dim retorno As Boolean
        Dim par As List(Of SqlParameter)
        Dim banco As DataAccess

        Try
            'VERIFICA DADOS
            If NOME_CLIENTE.Length = 0 Then
                Throw New Exception("Informe a propriedade NOME_CLIENTE")
            End If
            If TIPO_CLIENTE = "" Then
                Throw New Exception("Informe a propriedade TIPO_CLIENTE")
            End If
            If FANTASIA_CLIENTE.Length = 0 And TIPO_CLIENTE = Juridico Then
                Throw New Exception("Informe a propriedade FANTASIA_CLIENTE")
            End If
            If CPF_CNPJ_CLIENTE.Length = 0 Then
                Throw New Exception("Informe a propriedade CPF_CNPJ_CLIENTE")
            End If
            If FONE_CLIENTE_1.Length = 0 Then
                Throw New Exception("Informe a propriedade FONE_CLIENTE_1")
            End If
            If CEP_CLIENTE.Length = 0 Then
                Throw New Exception("Informe a propriedade CEP_CLIENTE")
            End If
            If ENDERECO_CLIENTE.Length = 0 Then
                Throw New Exception("Informe a propriedade ENDERECO_CLIENTE")
            End If
            If CIDADE_CLIENTE.Length = 0 Then
                Throw New Exception("Informe a propriedade CIDADE_CLIENTE")
            End If
            If BAIRRO_CLIENTE.Length = 0 Then
                Throw New Exception("Informe a propriedade BAIRRO_CLIENTE")
            End If
            If UF.Length = 0 Then
                Throw New Exception("Informe a propriedade UF_CLIENTE")
            End If
            '
            'INSTANCIAR A CLASSE DO BANCO
            banco = New DataAccess
            '
            'ADICIONA OS PARÂMETROS
            par = New List(Of SqlParameter)
            par.Add(New SqlParameter("@NOME_CLIENTE", NOME_CLIENTE))
            If FANTASIA_CLIENTE.Length > 0 Then par.Add(New SqlParameter("@FANTASIA_CLIENTE", FANTASIA_CLIENTE))
            par.Add(New SqlParameter("@TIPO_CLIENTE", TIPO_CLIENTE))
            par.Add(New SqlParameter("@FONE_CLIENTE_1", FONE_CLIENTE_1))
            If EMAIL_CLIENTE.Length > 0 Then par.Add(New SqlParameter("@EMAIL_CLIENTE", EMAIL_CLIENTE))
            par.Add(New SqlParameter("@CPF_CNPJ_CLIENTE", CPF_CNPJ_CLIENTE))
            If INSC_ESTADUAL_CLIENTE.Length > 0 Then par.Add(New SqlParameter("@INSC_ESTADUAL_CLIENTE", INSC_ESTADUAL_CLIENTE))
            If INSC_MUNICIPAL_CLIENTE.Length > 0 Then par.Add(New SqlParameter("@INSC_MUNICIPAL_CLIENTE", INSC_MUNICIPAL_CLIENTE))
            If NUMERO_CLIENTE.Length > 0 Then par.Add(New SqlParameter("@NUMERO_CLIENTE", NUMERO_CLIENTE))
            If FONE_CLIENTE_2.Length > 0 Then par.Add(New SqlParameter("@FONE_CLIENTE_2", FONE_CLIENTE_2))
            If COMPLEMENTO_CLIENTE.Length > 0 Then par.Add(New SqlParameter("@COMPLEMENTO_CLIENTE", COMPLEMENTO_CLIENTE))
            par.Add(New SqlParameter("@CEP_CLIENTE", CEP_CLIENTE))
            par.Add(New SqlParameter("@ENDERECO_CLIENTE", ENDERECO_CLIENTE))
            par.Add(New SqlParameter("@BAIRRO_CLIENTE", BAIRRO_CLIENTE))
            par.Add(New SqlParameter("@CIDADE_CLIENTE", CIDADE_CLIENTE))
            par.Add(New SqlParameter("@UF_CLIENTE", UF))
            '
            'EXECUTRA A PROCEDURE
            retorno = banco.ExecuteStoreProcedure("PR_NOVO_CLIENTE", par)
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
    ''' Atualiza um cliente no banco de dados.
    ''' </summary>
    ''' <returns>True: cliente alterado. False: cliente não alterado.</returns>
    Public Function AtualizaCliente() As Boolean
        Dim retorno As Boolean
        Dim par As List(Of SqlParameter)
        Dim banco As DataAccess

        Try
            'VERIFICA DADOS
            If ID_CLIENTE = 0 Then
                Throw New Exception("Informe a propriedade ID_CLIENTE")
            End If
            If NOME_CLIENTE.Length = 0 Then
                Throw New Exception("Informe a propriedade NOME_CLIENTE")
            End If
            If TIPO_CLIENTE = "" Then
                Throw New Exception("Informe a propriedade TIPO_CLIENTE")
            End If
            If FANTASIA_CLIENTE.Length = 0 And TIPO_CLIENTE = Juridico Then
                Throw New Exception("Informe a propriedade FANTASIA_CLIENTE")
            End If
            If CPF_CNPJ_CLIENTE.Length = 0 Then
                Throw New Exception("Informe a propriedade CPF_CNPJ_CLIENTE")
            End If
            If FONE_CLIENTE_1.Length = 0 Then
                Throw New Exception("Informe a propriedade FONE_CLIENTE_1")
            End If
            If CEP_CLIENTE.Length = 0 Then
                Throw New Exception("Informe a propriedade CEP_CLIENTE")
            End If
            If ENDERECO_CLIENTE.Length = 0 Then
                Throw New Exception("Informe a propriedade ENDERECO_CLIENTE")
            End If
            If CIDADE_CLIENTE.Length = 0 Then
                Throw New Exception("Informe a propriedade CIDADE_CLIENTE")
            End If
            If BAIRRO_CLIENTE.Length = 0 Then
                Throw New Exception("Informe a propriedade BAIRRO_CLIENTE")
            End If
            If UF.Length = 0 Then
                Throw New Exception("Informe a propriedade UF_CLIENTE")
            End If
            '
            'INSTANCIAR A CLASSE DO BANCO
            banco = New DataAccess
            '
            'ADICIONA OS PARÂMETROS
            par = New List(Of SqlParameter)
            par.Add(New SqlParameter("@ID_CLIENTE", ID_CLIENTE))
            par.Add(New SqlParameter("@NOME_CLIENTE", NOME_CLIENTE))
            If FANTASIA_CLIENTE.Length > 0 Then par.Add(New SqlParameter("@FANTASIA_CLIENTE", FANTASIA_CLIENTE))
            par.Add(New SqlParameter("@TIPO_CLIENTE", TIPO_CLIENTE))
            par.Add(New SqlParameter("@FONE_CLIENTE_1", FONE_CLIENTE_1))
            If EMAIL_CLIENTE.Length > 0 Then par.Add(New SqlParameter("@EMAIL_CLIENTE", EMAIL_CLIENTE))
            par.Add(New SqlParameter("@CPF_CNPJ_CLIENTE", CPF_CNPJ_CLIENTE))
            If INSC_ESTADUAL_CLIENTE.Length > 0 Then par.Add(New SqlParameter("@INSC_ESTADUAL_CLIENTE", INSC_ESTADUAL_CLIENTE))
            If INSC_MUNICIPAL_CLIENTE.Length > 0 Then par.Add(New SqlParameter("@INSC_MUNICIPAL_CLIENTE", INSC_MUNICIPAL_CLIENTE))
            If NUMERO_CLIENTE.Length > 0 Then par.Add(New SqlParameter("@NUMERO_CLIENTE", NUMERO_CLIENTE))
            If FONE_CLIENTE_2.Length > 0 Then par.Add(New SqlParameter("@FONE_CLIENTE_2", FONE_CLIENTE_2))
            If COMPLEMENTO_CLIENTE.Length > 0 Then par.Add(New SqlParameter("@COMPLEMENTO_CLIENTE", COMPLEMENTO_CLIENTE))
            par.Add(New SqlParameter("@CEP_CLIENTE", CEP_CLIENTE))
            par.Add(New SqlParameter("@ENDERECO_CLIENTE", ENDERECO_CLIENTE))
            par.Add(New SqlParameter("@BAIRRO_CLIENTE", BAIRRO_CLIENTE))
            par.Add(New SqlParameter("@CIDADE_CLIENTE", CIDADE_CLIENTE))
            par.Add(New SqlParameter("@UF_CLIENTE", UF))
            '
            'EXECUTRA A PROCEDURE
            retorno = banco.ExecuteStoreProcedure("PR_ATUALIZA_CLIENTE", par)
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
    ''' Busca um cliente no bando de dados.
    ''' </summary>
    ''' <returns>True: cliente encontrado. False: cliente não encontrado.</returns>
    Public Function BuscaCliente() As Boolean
        Dim retorno As Boolean = False
        Dim par As List(Of SqlParameter)
        Dim banco As DataAccess
        Dim dr As IDataReader

        Try
            'VERIFICA DADOS
            If ID_CLIENTE = 0 Then
                Throw New Exception("Informe a propriedade ID_CLIENTE")
            End If
            '
            'INSTANCIAR A CLASSE DO BANCO
            banco = New DataAccess
            '
            'ADICIONA OS PARÂMETROS
            par = New List(Of SqlParameter)
            par.Add(New SqlParameter("@ID_CLIENTE", ID_CLIENTE))
            '
            'EXECUTRA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("PR_BUSCA_CLIENTE", par)
            '
            'PREENCHER AS PROPRIEDADES
            While dr.Read
                ID_CLIENTE = dr("ID_CLIENTE")
                NOME_CLIENTE = dr("NOME_CLIENTE")
                TIPO_CLIENTE = dr("TIPO_CLIENTE")
                If Not IsDBNull(dr("FANTASIA_CLIENTE")) Then FANTASIA_CLIENTE = dr("FANTASIA_CLIENTE")
                CPF_CNPJ_CLIENTE = dr("CPF_CNPJ_CLIENTE")
                If Not IsDBNull(dr("INSC_MUNICIPAL_CLIENTE")) Then INSC_MUNICIPAL_CLIENTE = dr("INSC_MUNICIPAL_CLIENTE")
                If Not IsDBNull(dr("INSC_ESTADUAL_CLIENTE")) Then INSC_ESTADUAL_CLIENTE = dr("INSC_ESTADUAL_CLIENTE")
                FONE_CLIENTE_1 = dr("FONE_CLIENTE_1")
                If Not IsDBNull(dr("FONE_CLIENTE_2")) Then FONE_CLIENTE_2 = dr("FONE_CLIENTE_2")
                If Not IsDBNull(dr("EMAIL_CLIENTE")) Then EMAIL_CLIENTE = dr("EMAIL_CLIENTE")
                CEP_CLIENTE = dr("CEP_CLIENTE")
                ENDERECO_CLIENTE = dr("ENDERECO_CLIENTE")
                BAIRRO_CLIENTE = dr("BAIRRO_CLIENTE")
                CIDADE_CLIENTE = dr("CIDADE_CLIENTE")
                If Not IsDBNull(dr("COMPLEMENTO_CLIENTE")) Then COMPLEMENTO_CLIENTE = dr("COMPLEMENTO_CLIENTE")
                UF = dr("UF")
                DATA_INCLUSAO_CLIENTE = dr("DATA_INCLUSAO_CLIENTE")
                If Not IsDBNull(dr("DATA_ALTERACAO_CLIENTE")) Then DATA_ALTERACAO_CLIENTE = dr("DATA_ALTERACAO_CLIENTE")
                If Not IsDBNull(dr("NUMERO_CLIENTE")) Then NUMERO_CLIENTE = dr("NUMERO_CLIENTE")
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
    ''' Busca clientes de acordo com o filtro selecionado.
    ''' </summary>
    ''' <param name="tipo">Tipo de cliente. J ou F.</param>
    ''' <param name="nome">Nome do cliente.</param>
    ''' <param name="cpfcnpj">CPF ou CNPJ do cliente.</param>
    ''' <returns></returns>
    Public Function BuscaCliente(Optional ByVal tipo As Char = "",
                                  Optional ByVal nome As String = "",
                                  Optional ByVal cpfcnpj As String = "") As DataTable
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
            If tipo <> "" Then par.Add(New SqlParameter("@TIPO", tipo))
            If nome.Length > 0 Then par.Add(New SqlParameter("@NOME", nome))
            If cpfcnpj.Length > 0 Then par.Add(New SqlParameter("@CPFCNPJ", cpfcnpj))
            '
            'EXECUTRA A PROCEDURE
            tabela = banco.ExecutaStoreProcedureDataTable("PR_BUSCA_CLIENTES", par)
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
