Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel

Public Class CursoTelefone
    Inherits TextBox

#Region "Propriedades"
    <Category("Curso")>
    <Description("Envia cursor para o próximo controle. Enter: próximo controle, Seta para Baixo: próximo controle, Seta para cima: controle anterior.")>
    Public Property EnviaTab As Boolean = True
#End Region

    Private Sub CursoTelefone_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub CursoTelefone_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.BackColor = Color.LightYellow
    End Sub

    Private Sub CursoTelefone_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.BackColor = Color.White
    End Sub

    Private Sub CursoTelefone_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        '(16) 99123-9899
        'FAZ A MÁSCARA
        If e.KeyCode <> Keys.Back Then
            If Me.TextLength = 1 Then
                Me.Text = Me.Text.Insert(0, "(")
                Me.SelectionStart = Me.TextLength
            ElseIf Me.TextLength = 3 Then
                Me.Text = Me.Text & ") "
                Me.SelectionStart = Me.TextLength
            ElseIf Me.TextLength = 10 Then
                Me.Text = Me.Text & "-"
                Me.SelectionStart = Me.TextLength
            End If
        End If
    End Sub
End Class
