Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing

Public Class CursoTextBox
    Inherits TextBox

#Region "Propriedades"
    <Category("Curso")>
    <Description("Permite digitar somente números.")>
    Public Property SomenteNumero As Boolean = False

    <Category("Curso")>
    <Description("Envia cursor para o próximo controle. Enter: próximo controle, Seta para Baixo: próximo controle, Seta para cima: controle anterior.")>
    Public Property EnviaTab As Boolean = True

#End Region




    Private Sub CursoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If SomenteNumero = True Then
            If Char.IsLetter(e.KeyChar) Then
                e.Handled = True
            ElseIf Char.IsPunctuation(e.KeyChar) Then
                e.Handled = True
            ElseIf Char.IsSeparator(e.KeyChar) Then
                e.Handled = True
            ElseIf Char.IsSymbol(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CursoTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub CursoTextBox_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.BackColor = Color.LightYellow
    End Sub

    Private Sub CursoTextBox_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.BackColor = Color.White
    End Sub
End Class
