Imports DataBase
Imports DataBase.Utils
Imports System.Windows.Forms

Public Class frmPesqCliente
#Region "Propriedades"
    Public Property IDCliente As Integer
#End Region
    Private Sub frmPesqCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboTipo.SelectedIndex = 0
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        Select Case cboTipo.SelectedIndex
            Case 1
                txtCPFCNPJ.Enabled = True
                txtCPFCNPJ.ValidaCPF = True
            Case 2
                txtCPFCNPJ.Enabled = True
                txtCPFCNPJ.ValidaCNPJ = True
            Case Else
                txtCPFCNPJ.Enabled = False
                txtCPFCNPJ.Clear()
        End Select
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Dim banco As New CAD_CLIENTE
        Dim nome, cpfcnpj As String
        Dim tipo As String
        Dim tabela As DataTable

        Try
            'SETA OS PARAMETROS
            nome = txtNome.Text
            cpfcnpj = txtCPFCNPJ.Text
            Select Case cboTipo.SelectedIndex
                Case 0
                    tipo = ""
                Case 1
                    tipo = "F"
                Case 2
                    tipo = "J"
            End Select
            '
            'FAZ A PESQUISA
            tabela = banco.BuscaCliente(tipo, nome, cpfcnpj)
            '
            'VINCULA A TABELA
            dgvDados.AutoGenerateColumns = False
            dgvDados.DataSource = tabela
            '
            'EXIBIR MENSAGEM
            If dgvDados.Rows.Count = 0 Then
                MessageBox.Show("Nenhum registro encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            TrataErro("Problema ao tentar fazer a pesquisa do cliente.", ex)
        End Try
    End Sub

    Private Sub dgvDados_DoubleClick(sender As Object, e As EventArgs) Handles dgvDados.DoubleClick
        If dgvDados.Rows.Count > 0 Then
            IDCliente = dgvDados.CurrentRow.Cells("colID").Value
            Me.Close()
        End If
    End Sub

    Private Sub dgvDados_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDados.KeyDown
        If dgvDados.Rows.Count > 0 And e.KeyCode = Keys.Enter Then
            IDCliente = dgvDados.CurrentRow.Cells("colID").Value
            Me.Close()
        End If
    End Sub
End Class