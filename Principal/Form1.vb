Imports Cadastros
Imports Financeiro


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Abre o form cliente para teste
        Dim frm As New frmCadCliente
        frm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim frm As New frmContaReceber
        'frm.Show()
        Dim frm As New frmBaixaParcela
        frm.Show()
    End Sub
End Class
