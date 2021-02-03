Imports System.Data.SqlClient
Public Class CAD_FORNECEDOR
#Region "Propriedades"
    Public Property ID_FORNECEDOR As Integer
    Public Property NOME_FORNECEDOR As String
    Public Property TIPO_FORNECEDOR As Char
    Public Property FANTASIA_FORNECEDOR As String
    Public Property CPF_CNPJ_FORNECEDOR As String
    Public Property INSC_MUNICIPAL_FORNECEDOR As String
    Public Property INSC_ESTADUAL_FORNECEDOR As String
    Public Property FONE_FORNECEDOR_1 As String
    Public Property FONE_FORNECEDOR_2 As String
    Public Property EMAIL_FORNECEDOR As String
    Public Property CEP_FORNECEDOR As String
    Public Property ENDERECO_FORNECEDOR As String
    Public Property BAIRRO_FORNECEDOR As String
    Public Property CIDADE_FORNECEDOR As String
    Public Property UF As String
    Public Property COMPLEMENTO_FORNECEDOR As String
    Public Property DATA_INCLUSAO_FORNECEDOR As Date
    Public Property DATA_ALTERACAO_FORNECEDOR As Date
    Public Property NUMERO_FORNECEDOR As String
#End Region

#Region "Cosntantes"
    Public Const Fisico As Char = "F"
    Public Const Juridico As Char = "J"
#End Region

#Region "Métodos"
    ''' <summary>
    ''' Adiciona um novo FORNECEDOR no banco de dados.
    ''' </summary>
    ''' <returns>True: FORNECEDOR adicionado. False: FORNECEDOR não adicionado.</returns>
    Public Function NovoFORNECEDOR() As Boolean
        Dim retorno As Boolean
        Dim par As List(Of SqlParameter)
        Dim banco As DataAccess

        Try
            'VERIFICA DADOS
            If NOME_FORNECEDOR.Length = 0 Then
                Throw New Exception("Informe a propriedade NOME_FORNECEDOR")
            End If
            If TIPO_FORNECEDOR = "" Then
                Throw New Exception("Informe a propriedade TIPO_FORNECEDOR")
            End If
            If FANTASIA_FORNECEDOR.Length = 0 And TIPO_FORNECEDOR = Juridico Then
                Throw New Exception("Informe a propriedade FANTASIA_FORNECEDOR")
            End If
            If CPF_CNPJ_FORNECEDOR.Length = 0 Then
                Throw New Exception("Informe a propriedade CPF_CNPJ_FORNECEDOR")
            End If
            If FONE_FORNECEDOR_1.Length = 0 Then
                Throw New Exception("Informe a propriedade FONE_FORNECEDOR_1")
            End If
            If CEP_FORNECEDOR.Length = 0 Then
                Throw New Exception("Informe a propriedade CEP_FORNECEDOR")
            End If
            If ENDERECO_FORNECEDOR.Length = 0 Then
                Throw New Exception("Informe a propriedade ENDERECO_FORNECEDOR")
            End If
            If CIDADE_FORNECEDOR.Length = 0 Then
                Throw New Exception("Informe a propriedade CIDADE_FORNECEDOR")
            End If
            If BAIRRO_FORNECEDOR.Length = 0 Then
                Throw New Exception("Informe a propriedade BAIRRO_FORNECEDOR")
            End If
            If UF.Length = 0 Then
                Throw New Exception("Informe a propriedade UF_FORNECEDOR")
            End If
            '
            'INSTANCIAR A CLASSE DO BANCO
            banco = New DataAccess
            '
            'ADICIONA OS PARÂMETROS
            par = New List(Of SqlParameter)
            par.Add(New SqlParameter("@NOME_FORNECEDOR", NOME_FORNECEDOR))
            If FANTASIA_FORNECEDOR.Length > 0 Then par.Add(New SqlParameter("@FANTASIA_FORNECEDOR", FANTASIA_FORNECEDOR))
            par.Add(New SqlParameter("@TIPO_FORNECEDOR", TIPO_FORNECEDOR))
            par.Add(New SqlParameter("@FONE_FORNECEDOR_1", FONE_FORNECEDOR_1))
            If EMAIL_FORNECEDOR.Length > 0 Then par.Add(New SqlParameter("@EMAIL_FORNECEDOR", EMAIL_FORNECEDOR))
            par.Add(New SqlParameter("@CPF_CNPJ_FORNECEDOR", CPF_CNPJ_FORNECEDOR))
            If INSC_ESTADUAL_FORNECEDOR.Length > 0 Then par.Add(New SqlParameter("@INSC_ESTADUAL_FORNECEDOR", INSC_ESTADUAL_FORNECEDOR))
            If INSC_MUNICIPAL_FORNECEDOR.Length > 0 Then par.Add(New SqlParameter("@INSC_MUNICIPAL_FORNECEDOR", INSC_MUNICIPAL_FORNECEDOR))
            If NUMERO_FORNECEDOR.Length > 0 Then par.Add(New SqlParameter("@NUMERO_FORNECEDOR", NUMERO_FORNECEDOR))
            If FONE_FORNECEDOR_2.Length > 0 Then par.Add(New SqlParameter("@FONE_FORNECEDOR_2", FONE_FORNECEDOR_2))
            If COMPLEMENTO_FORNECEDOR.Length > 0 Then par.Add(New SqlParameter("@COMPLEMENTO_FORNECEDOR", COMPLEMENTO_FORNECEDOR))
            par.Add(New SqlParameter("@CEP_FORNECEDOR", CEP_FORNECEDOR))
            par.Add(New SqlParameter("@ENDERECO_FORNECEDOR", ENDERECO_FORNECEDOR))
            par.Add(New SqlParameter("@BAIRRO_FORNECEDOR", BAIRRO_FORNECEDOR))
            par.Add(New SqlParameter("@CIDADE_FORNECEDOR", CIDADE_FORNECEDOR))
            par.Add(New SqlParameter("@UF_FORNECEDOR", UF))
            '
            'EXECUTRA A PROCEDURE
            retorno = banco.ExecuteStoreProcedure("PR_NOVO_FORNECEDOR", par)
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
    ''' Atualiza um FORNECEDOR no banco de dados.
    ''' </summary>
    ''' <returns>True: FORNECEDOR alterado. False: FORNECEDOR não alterado.</returns>
    Public Function AtualizaFORNECEDOR() As Boolean
        Dim retorno As Boolean
        Dim par As List(Of SqlParameter)
        Dim banco As DataAccess

        Try
            'VERIFICA DADOS
            If ID_FORNECEDOR = 0 Then
                Throw New Exception("Informe a propriedade ID_FORNECEDOR")
            End If
            If NOME_FORNECEDOR.Length = 0 Then
                Throw New Exception("Informe a propriedade NOME_FORNECEDOR")
            End If
            If TIPO_FORNECEDOR = "" Then
                Throw New Exception("Informe a propriedade TIPO_FORNECEDOR")
            End If
            If FANTASIA_FORNECEDOR.Length = 0 And TIPO_FORNECEDOR = Juridico Then
                Throw New Exception("Informe a propriedade FANTASIA_FORNECEDOR")
            End If
            If CPF_CNPJ_FORNECEDOR.Length = 0 Then
                Throw New Exception("Informe a propriedade CPF_CNPJ_FORNECEDOR")
            End If
            If FONE_FORNECEDOR_1.Length = 0 Then
                Throw New Exception("Informe a propriedade FONE_FORNECEDOR_1")
            End If
            If CEP_FORNECEDOR.Length = 0 Then
                Throw New Exception("Informe a propriedade CEP_FORNECEDOR")
            End If
            If ENDERECO_FORNECEDOR.Length = 0 Then
                Throw New Exception("Informe a propriedade ENDERECO_FORNECEDOR")
            End If
            If CIDADE_FORNECEDOR.Length = 0 Then
                Throw New Exception("Informe a propriedade CIDADE_FORNECEDOR")
            End If
            If BAIRRO_FORNECEDOR.Length = 0 Then
                Throw New Exception("Informe a propriedade BAIRRO_FORNECEDOR")
            End If
            If UF.Length = 0 Then
                Throw New Exception("Informe a propriedade UF_FORNECEDOR")
            End If
            '
            'INSTANCIAR A CLASSE DO BANCO
            banco = New DataAccess
            '
            'ADICIONA OS PARÂMETROS
            par = New List(Of SqlParameter)
            par.Add(New SqlParameter("@ID_FORNECEDOR", ID_FORNECEDOR))
            par.Add(New SqlParameter("@NOME_FORNECEDOR", NOME_FORNECEDOR))
            If FANTASIA_FORNECEDOR.Length > 0 Then par.Add(New SqlParameter("@FANTASIA_FORNECEDOR", FANTASIA_FORNECEDOR))
            par.Add(New SqlParameter("@TIPO_FORNECEDOR", TIPO_FORNECEDOR))
            par.Add(New SqlParameter("@FONE_FORNECEDOR_1", FONE_FORNECEDOR_1))
            If EMAIL_FORNECEDOR.Length > 0 Then par.Add(New SqlParameter("@EMAIL_FORNECEDOR", EMAIL_FORNECEDOR))
            par.Add(New SqlParameter("@CPF_CNPJ_FORNECEDOR", CPF_CNPJ_FORNECEDOR))
            If INSC_ESTADUAL_FORNECEDOR.Length > 0 Then par.Add(New SqlParameter("@INSC_ESTADUAL_FORNECEDOR", INSC_ESTADUAL_FORNECEDOR))
            If INSC_MUNICIPAL_FORNECEDOR.Length > 0 Then par.Add(New SqlParameter("@INSC_MUNICIPAL_FORNECEDOR", INSC_MUNICIPAL_FORNECEDOR))
            If NUMERO_FORNECEDOR.Length > 0 Then par.Add(New SqlParameter("@NUMERO_FORNECEDOR", NUMERO_FORNECEDOR))
            If FONE_FORNECEDOR_2.Length > 0 Then par.Add(New SqlParameter("@FONE_FORNECEDOR_2", FONE_FORNECEDOR_2))
            If COMPLEMENTO_FORNECEDOR.Length > 0 Then par.Add(New SqlParameter("@COMPLEMENTO_FORNECEDOR", COMPLEMENTO_FORNECEDOR))
            par.Add(New SqlParameter("@CEP_FORNECEDOR", CEP_FORNECEDOR))
            par.Add(New SqlParameter("@ENDERECO_FORNECEDOR", ENDERECO_FORNECEDOR))
            par.Add(New SqlParameter("@BAIRRO_FORNECEDOR", BAIRRO_FORNECEDOR))
            par.Add(New SqlParameter("@CIDADE_FORNECEDOR", CIDADE_FORNECEDOR))
            par.Add(New SqlParameter("@UF_FORNECEDOR", UF))
            '
            'EXECUTRA A PROCEDURE
            retorno = banco.ExecuteStoreProcedure("PR_ATUALIZA_FORNECEDOR", par)
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
    ''' Busca um FORNECEDOR no bando de dados.
    ''' </summary>
    ''' <returns>True: FORNECEDOR encontrado. False: FORNECEDOR não encontrado.</returns>
    Public Function BuscaFORNECEDOR() As Boolean
        Dim retorno As Boolean = False
        Dim par As List(Of SqlParameter)
        Dim banco As DataAccess
        Dim dr As IDataReader

        Try
            'VERIFICA DADOS
            If ID_FORNECEDOR = 0 Then
                Throw New Exception("Informe a propriedade ID_FORNECEDOR")
            End If
            '
            'INSTANCIAR A CLASSE DO BANCO
            banco = New DataAccess
            '
            'ADICIONA OS PARÂMETROS
            par = New List(Of SqlParameter)
            par.Add(New SqlParameter("@ID_FORNECEDOR", ID_FORNECEDOR))
            '
            'EXECUTRA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("PR_BUSCA_FORNECEDOR", par)
            '
            'PREENCHER AS PROPRIEDADES
            While dr.Read
                ID_FORNECEDOR = dr("ID_FORNECEDOR")
                NOME_FORNECEDOR = dr("NOME_FORNECEDOR")
                TIPO_FORNECEDOR = dr("TIPO_FORNECEDOR")
                If Not IsDBNull(dr("FANTASIA_FORNECEDOR")) Then FANTASIA_FORNECEDOR = dr("FANTASIA_FORNECEDOR")
                CPF_CNPJ_FORNECEDOR = dr("CPF_CNPJ_FORNECEDOR")
                If Not IsDBNull(dr("INSC_MUNICIPAL_FORNECEDOR")) Then INSC_MUNICIPAL_FORNECEDOR = dr("INSC_MUNICIPAL_FORNECEDOR")
                If Not IsDBNull(dr("INSC_ESTADUAL_FORNECEDOR")) Then INSC_ESTADUAL_FORNECEDOR = dr("INSC_ESTADUAL_FORNECEDOR")
                FONE_FORNECEDOR_1 = dr("FONE_FORNECEDOR_1")
                If Not IsDBNull(dr("FONE_FORNECEDOR_2")) Then FONE_FORNECEDOR_2 = dr("FONE_FORNECEDOR_2")
                If Not IsDBNull(dr("EMAIL_FORNECEDOR")) Then EMAIL_FORNECEDOR = dr("EMAIL_FORNECEDOR")
                CEP_FORNECEDOR = dr("CEP_FORNECEDOR")
                ENDERECO_FORNECEDOR = dr("ENDERECO_FORNECEDOR")
                BAIRRO_FORNECEDOR = dr("BAIRRO_FORNECEDOR")
                CIDADE_FORNECEDOR = dr("CIDADE_FORNECEDOR")
                If Not IsDBNull(dr("COMPLEMENTO_FORNECEDOR")) Then COMPLEMENTO_FORNECEDOR = dr("COMPLEMENTO_FORNECEDOR")
                UF = dr("UF")
                DATA_INCLUSAO_FORNECEDOR = dr("DATA_INCLUSAO_FORNECEDOR")
                If Not IsDBNull(dr("DATA_ALTERACAO_FORNECEDOR")) Then DATA_ALTERACAO_FORNECEDOR = dr("DATA_ALTERACAO_FORNECEDOR")
                If Not IsDBNull(dr("NUMERO_FORNECEDOR")) Then NUMERO_FORNECEDOR = dr("NUMERO_FORNECEDOR")
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
    ''' Busca FORNECEDORs de acordo com o filtro selecionado.
    ''' </summary>
    ''' <param name="tipo">Tipo de FORNECEDOR. J ou F.</param>
    ''' <param name="nome">Nome do FORNECEDOR.</param>
    ''' <param name="cpfcnpj">CPF ou CNPJ do FORNECEDOR.</param>
    ''' <returns></returns>
    Public Function BuscaFORNECEDOR(Optional ByVal tipo As String = "",
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
            tabela = banco.ExecutaStoreProcedureDataTable("PR_BUSCA_FORNECEDORS", par)
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
