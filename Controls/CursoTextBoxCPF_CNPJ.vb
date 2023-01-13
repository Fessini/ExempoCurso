Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing

Public Class CursoTextBoxCPF_CNPJ
    Inherits TextBox

#Region "Variáveis"
    Private m_blnValidaCPF As Boolean = True
    Private m_blnValidaCNPJ As Boolean
    Private m_blnValida As Boolean = False
    Private epValida As New ErrorProvider
#End Region

#Region "Propriedades"
    <Category("Curso")>
    <Description("Envia cursor para o próximo controle. Enter: próximo controle, Seta para Baixo: próximo controle, Seta para cima: controle anterior.")>
    Public Property EnviaTab As Boolean = True

    <Category("Curso")>
    <Description("Exibir ou não mensgem de CPF ou CNPJ inválido.")>
    Public Property ExibirMensagem As Boolean = False

    <Category("Curso")>
    <Description("Informa se o CPF ou CNPJ é válido.")>
    Public Property IsValido As Boolean
        Get
            Return m_blnValida
        End Get
        Set(value As Boolean)
            m_blnValida = value
        End Set
    End Property

    <Category("Curso")>
    <Description("Configura o controle para validar CPF.")>
    Public Property ValidaCPF As Boolean
        Get
            Return m_blnValidaCPF
        End Get
        Set(value As Boolean)
            m_blnValidaCPF = value
            If m_blnValidaCPF = True Then
                Me.MaxLength = 14
                m_blnValidaCNPJ = False
            Else
                m_blnValidaCNPJ = True
                Me.MaxLength = 18
            End If
        End Set
    End Property

    <Category("Curso")>
    <Description("Configura o controle para validar CNPJ.")>
    Public Property ValidaCNPJ As Boolean
        Get
            Return m_blnValidaCNPJ
        End Get
        Set(value As Boolean)
            m_blnValidaCNPJ = value
            If m_blnValidaCNPJ = True Then
                m_blnValidaCPF = False
                Me.MaxLength = 18
            Else
                m_blnValidaCPF = True
                Me.MaxLength = 14
            End If
        End Set
    End Property
#End Region

    Private Sub CursoTextBoxCPF_CNPJ_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.BackColor = Color.LightYellow
    End Sub

    Private Sub CursoTextBoxCPF_CNPJ_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.BackColor = Color.White
    End Sub

    Private Sub CursoTextBoxCPF_CNPJ_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If EnviaTab = True Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
                SendKeys.Send("{TAB}")
                e.SuppressKeyPress = True
            ElseIf e.KeyCode = Keys.Up Then
                SendKeys.Send("+{TAB}")
                e.SuppressKeyPress = True
            End If
        End If
    End Sub

    Private Sub CursoTextBoxCPF_CNPJ_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        'VALIDAR O CPF
        If m_blnValidaCPF = True Then
            'FAZ A MÁSCARA DO CPF
            If e.KeyCode <> Keys.Back Then
                If Me.TextLength = 3 Then
                    Me.Text = Me.Text & "."
                    Me.SelectionStart = Me.TextLength
                ElseIf Me.TextLength = 7 Then
                    Me.Text = Me.Text & "."
                    Me.SelectionStart = Me.TextLength
                ElseIf Me.TextLength = 11 Then
                    Me.Text = Me.Text & "-"
                    Me.SelectionStart = Me.TextLength
                End If
            End If

            'FAZ A VALIDAÇÃO
            Dim ValidaCPF As New Valida_CPF_CNPJ
            If Me.TextLength = 14 Then
                ValidaCPF.cpf = Me.Text
                If ValidaCPF.isCpfValido = False Then
                    If ExibirMensagem = True Then
                        epValida.SetError(Me, "CPF inválido.")
                    End If
                    Me.Focus()
                    Me.SelectAll()
                    m_blnValida = False
                Else
                    m_blnValida = True
                    epValida.SetError(Me, "")
                End If
            Else
                epValida.SetError(Me, "")
            End If
        Else
            'VALIDA O CNPJ
            'FAZ A MÁSCARA DO CNPJ
            If e.KeyCode <> Keys.Back Then
                If Me.TextLength = 2 Then
                    Me.Text = Me.Text & "."
                    Me.SelectionStart = Me.TextLength
                ElseIf Me.TextLength = 6 Then
                    Me.Text = Me.Text & "."
                    Me.SelectionStart = Me.TextLength
                ElseIf Me.TextLength = 10 Then
                    Me.Text = Me.Text & "/"
                    Me.SelectionStart = Me.TextLength
                ElseIf Me.TextLength = 15 Then
                    Me.Text = Me.Text & "-"
                    Me.SelectionStart = Me.TextLength
                End If
            End If
            '
            'FAZ VALIDAÇÃO
            Dim ValidaCNPJ As New Valida_CPF_CNPJ
            If Me.TextLength = 18 Then
                ValidaCNPJ.cnpj = Me.Text
                If ValidaCNPJ.isCnpjValido = False Then
                    m_blnValida = False
                    If ExibirMensagem = True Then
                        epValida.SetError(Me, "CNPJ inválido.")
                    End If
                    Me.Focus()
                    Me.SelectAll()
                Else
                    epValida.SetError(Me, "")
                    m_blnValida = True
                End If
            Else
                epValida.SetError(Me, "")
            End If
        End If
    End Sub
End Class

Public Class Valida_CPF_CNPJ

#Region "Variáveis"
    Private dadosArray() As String = {"111.111.111-11", "222.222.222-22", "333.333.333-33", "444.444.444-44",
                                                 "555.555.555-55", "666.666.666-66", "777.777.777-77", "888.888.888-88", "999.999.999-99"}

    Private Const msgErro As String = "Dados Inválidos"
    Private bValida As Boolean
    Private sCPF As String
    Private sCNPJ As String
#End Region

#Region "Propriedades"
    Public Property cpf() As String
        Get

            Return sCPF
        End Get
        Set(ByVal Valor As String)
            bValida = ValidaCPF(Valor)
            If bValida Then
                sCPF = Valor
            Else
                'Throw (New System.ArgumentException(msgErro, "Dados Inválidos"))
            End If
        End Set
    End Property
    Public ReadOnly Property isCpfValido() As Boolean
        Get
            bValida = ValidaCPF(cpf)
            If bValida Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property
    Public Property cnpj() As String
        Get
            Return sCNPJ
        End Get
        Set(ByVal Valor As String)
            bValida = ValidaCNPJ(Valor)
            If bValida Then
                sCNPJ = Valor
            Else
                'Throw (New System.ArgumentException(msgErro, "Numero do CNPJ"))
            End If
        End Set
    End Property
    Public ReadOnly Property isCnpjValido() As Boolean
        Get
            bValida = ValidaCNPJ(cnpj)
            If bValida Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property
#End Region

#Region "Métodos"
    Private Function ValidaCPF(ByVal CPF As String) As Boolean

        Dim i, x, n1, n2 As Integer

        CPF = Trim(CPF)

        For i = 0 To dadosArray.Length - 1

            If CPF.Length <> 14 Or dadosArray(i).Equals(CPF) Then

                Return False

            End If

        Next

        'remove a maskara

        CPF = CPF.Substring(0, 3) + CPF.Substring(4, 3) + CPF.Substring(8, 3) + CPF.Substring(12)

        For x = 0 To 1

            n1 = 0

            For i = 0 To 8 + x

                n1 = n1 + Val(CPF.Substring(i, 1)) * (10 + x - i)

            Next

            n2 = 11 - (n1 - (Int(n1 / 11) * 11))

            If n2 = 10 Or n2 = 11 Then n2 = 0

            If n2 <> Val(CPF.Substring(9 + x, 1)) Then

                Return False

            End If
        Next

        Return True

    End Function

    Private Function ValidaCNPJ(ByVal CNPJ As String) As Boolean

        Dim i As Integer

        Dim valida As Boolean

        CNPJ = Trim(CNPJ)

        For i = 0 To dadosArray.Length - 1

            If CNPJ.Length <> 18 Or dadosArray(i).Equals(CNPJ) Then

                Return False

            End If

        Next

        'remove a maskara

        CNPJ = CNPJ.Substring(0, 2) + CNPJ.Substring(3, 3) + CNPJ.Substring(7, 3) + CNPJ.Substring(11, 4) + CNPJ.Substring(16)

        valida = efetivaValidacao(CNPJ)

        If valida Then

            ValidaCNPJ = True

        Else

            ValidaCNPJ = False

        End If

    End Function


    Private Function efetivaValidacao(ByVal cnpj As String)

        Dim Numero(13) As Integer

        Dim soma As Integer

        Dim i As Integer

        Dim resultado1 As Integer

        Dim resultado2 As Integer

        For i = 0 To Numero.Length - 1

            Numero(i) = CInt(cnpj.Substring(i, 1))

        Next

        soma = Numero(0) * 5 + Numero(1) * 4 + Numero(2) * 3 + Numero(3) * 2 + Numero(4) * 9 + Numero(5) * 8 + Numero(6) * 7 +
                   Numero(7) * 6 + Numero(8) * 5 + Numero(9) * 4 + Numero(10) * 3 + Numero(11) * 2

        soma = soma - (11 * (Int(soma / 11)))

        If soma = 0 Or soma = 1 Then

            resultado1 = 0

        Else

            resultado1 = 11 - soma

        End If

        If resultado1 = Numero(12) Then

            soma = Numero(0) * 6 + Numero(1) * 5 + Numero(2) * 4 + Numero(3) * 3 + Numero(4) * 2 + Numero(5) * 9 + Numero(6) * 8 +
                         Numero(7) * 7 + Numero(8) * 6 + Numero(9) * 5 + Numero(10) * 4 + Numero(11) * 3 + Numero(12) * 2

            soma = soma - (11 * (Int(soma / 11)))

            If soma = 0 Or soma = 1 Then

                resultado2 = 0

            Else

                resultado2 = 11 - soma

            End If

            If resultado2 = Numero(13) Then

                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If

    End Function
#End Region


End Class
