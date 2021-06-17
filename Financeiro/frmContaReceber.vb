﻿Imports Cadastros
Imports DataBase
Imports System.Windows.Forms
Imports DataBase.Utils
Public Class frmContaReceber
#Region "Variáveis"
    'CONTROLA OS MODOS DE OPERAÇÃO
    Private Enum Opcao As Integer
        Cancelar = 0
        Incluir = 1
        Editar = 2
        Consultar = 3
    End Enum
    Private intOpcao As Opcao
    '
    'DataTable para controlar as parcelas
    Private dtParcelas As DataTable
    Private Pesq() As DataRow
    Private ParcelasReceber As New List(Of PARCELA_CONTA_RECEBER)
#End Region

#Region "Métodos"
    Private Sub GeraParcelas()
        Dim dtData As Date = dtpVencimento.Value
        Dim dblValorParcela As Double = Math.Round(Convert.ToDouble(txtValor.Text) / Convert.ToInt32(txtQtdParcelas.Text), 2)
        Dim dblTotalParcela, dblDiferenca As Double

        NovoDataTableParcela()
        '
        'Gera as parcelas
        For I As Integer = 1 To Convert.ToInt32(txtQtdParcelas.Text)
            Dim novaLinha As DataRow = dtParcelas.NewRow
            novaLinha.Item("VALOR_PARCELA_RECEBER") = dblValorParcela
            novaLinha.Item("NUMERO_PARCELA_RECEBER") = I
            novaLinha.Item("DATA_VENCIMENTO_RECEBER") = dtData.Date
            novaLinha.Item("STATUS") = "I"
            'FAZ A SELEÇÃO DE MODO DE GERAR PARCELAS
            If ckbMesmoDia.Checked = True Then 'MESMO DIA DE VENCIMENTO
                dtData = dtData.Date.AddMonths(1)
            Else 'QUANTIDADES DE DIAS DE VENCIMENTO
                dtData = dtData.Date.AddDays(Convert.ToInt32(txtIntervalo.Text))
            End If
            dtParcelas.Rows.Add(novaLinha)
            dblTotalParcela += dblValorParcela
        Next
        '
        'VERIFICA O TOTAL DAS PARCELAS
        dblDiferenca = Math.Round(Convert.ToDouble(txtValor.Text) - dblTotalParcela, 2)
        If dblDiferenca > 0 Then
            dtParcelas.Rows(0).Item("VALOR_PARCELA_RECEBER") = dblValorParcela + Math.Abs(dblDiferenca)
        Else
            dtParcelas.Rows(0).Item("VALOR_PARCELA_RECEBER") = dblValorParcela - Math.Abs(dblDiferenca)
        End If
        dtParcelas.AcceptChanges()
        '
        'PESQUISA AS PARCELAS
        Pesq = dtParcelas.Select("STATUS <> 'D' OR STATUS IS NULL")
        ParcelasReceber.Clear()
        For Each Linha As DataRow In Pesq
            Dim nova As New PARCELA_CONTA_RECEBER
            nova.VALOR_PARCELA_RECEBER = Linha.Item("VALOR_PARCELA_RECEBER")
            nova.NUMERO_PARCELA_RECEBER = Linha.Item("NUMERO_PARCELA_RECEBER")
            nova.DATA_VENCIMENTO_RECEBER = Linha.Item("DATA_VENCIMENTO_RECEBER")
            ParcelasReceber.Add(nova)
        Next
        dgvParcelas.AutoGenerateColumns = False
        dgvParcelas.DataSource = ParcelasReceber
        dgvParcelas.Refresh()
    End Sub
    ''' <summary>
    ''' Cria o DataTable para controlar as parcelas.
    ''' </summary>
    Private Sub NovoDataTableParcela()
        dtParcelas = Nothing
        dtParcelas = New DataTable
        dtParcelas.Columns.Add("ID_MOV_CONTA_ITEM", GetType(Integer))
        dtParcelas.Columns.Add("CODIGO_CONTA_RECEBER", GetType(Integer))
        dtParcelas.Columns.Add("CODIGO_CONTA_BANCO", GetType(Integer))
        dtParcelas.Columns.Add("VALOR_PARCELA_RECEBER", GetType(Double))
        dtParcelas.Columns.Add("DATA_PAGAMENTO_RECEBER", GetType(Date))
        dtParcelas.Columns.Add("DATA_VENCIMENTO_RECEBER", GetType(Date))
        dtParcelas.Columns.Add("NUMERO_PARCELA_RECEBER", GetType(Integer))
        dtParcelas.Columns.Add("STATUS", GetType(String))
    End Sub
    ''' <summary>
    ''' Abre pesquisa de cliente.
    ''' </summary>
    Private Sub PesqCliente()
        Using frm As New frmPesqCliente
            frm.ShowDialog()
            If frm.IDCliente > 0 Then
                Dim enter As New KeyEventArgs(Keys.Enter)
                txtCliente.Text = frm.IDCliente
                txtCliente_KeyDown(Nothing, enter)
            End If
        End Using
    End Sub
    ''' <summary>
    ''' Ativa e desativa os controles do formulário.
    ''' </summary>
    ''' <param name="status">True: ativa. False: desativa.</param>
    Private Sub AtivaDesativa(ByVal status As Boolean)
        If intOpcao <> Opcao.Incluir Then
            txtDocumento.Enabled = status
            btnPesquisa.Enabled = status
        End If
        txtCliente.Enabled = status
        btnPesqCliente.Enabled = status
        dtpEmissao.Enabled = status
        dtpVencimento.Enabled = status
        txtNumero.Enabled = status
        txtValor.Enabled = status
        txtObs.Enabled = status
        txtQtdParcelas.Enabled = status
        txtIntervalo.Enabled = status
        ckbMesmoDia.Enabled = status
        btnGeraParcela.Enabled = status
        rbAtivo.Enabled = status
        rbInativo.Enabled = status
        btnEstornar.Enabled = status
        btnBaixar.Enabled = status
        btnRemover.Enabled = status
        dgvParcelas.Enabled = status
    End Sub
#End Region

    Private Sub tsbIncluir_Click(sender As Object, e As EventArgs) Handles tsbIncluir.Click
        'SETAR A OPERAÇÃO
        intOpcao = Opcao.Incluir
        '
        'CONFIGURA OS BOTÕES
        tsbIncluir.Enabled = False
        tsbEditar.Enabled = False
        tsbConsultar.Enabled = False
        tsbCancelar.Enabled = True
        tsbGravar.Enabled = True
        '
        'ATIVA OS CONTROLES
        AtivaDesativa(True)
        '
        txtCliente.Focus()
    End Sub

    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click
        'SETAR A OPERAÇÃO
        intOpcao = Opcao.Editar
        '
        'CONFIGURA OS BOTÕES
        tsbIncluir.Enabled = False
        tsbEditar.Enabled = False
        tsbConsultar.Enabled = False
        tsbCancelar.Enabled = True
        '
        txtDocumento.Enabled = True
        btnPesquisa.Enabled = True
        txtDocumento.Focus()
    End Sub

    Private Sub tsbConsultar_Click(sender As Object, e As EventArgs) Handles tsbConsultar.Click
        'SETAR A OPERAÇÃO
        intOpcao = Opcao.Consultar
        '
        'CONFIGURA OS BOTÕES
        tsbIncluir.Enabled = False
        tsbEditar.Enabled = False
        tsbConsultar.Enabled = False
        tsbCancelar.Enabled = True
        '
        txtDocumento.Enabled = True
        btnPesquisa.Enabled = True
        txtDocumento.Focus()
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        'VERIFICAR OS MODOS DE OPERAÇÃO
        If intOpcao = Opcao.Incluir And lblCliente.Text <> "-" Then
            If MessageBox.Show("Deseja cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
        ElseIf intOpcao = Opcao.Editar And txtDocumento.Enabled = False Then
            If MessageBox.Show("Deseja cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
        End If
        '
        'FAZ O CANCELAMENTO E RETORNA O FORM NO MODO PADRÃO
        intOpcao = Opcao.Cancelar
        txtCliente.Clear()
        txtDocumento.Clear()
        txtIntervalo.Clear()
        txtNumero.Clear()
        txtObs.Clear()
        txtQtdParcelas.Clear()
        txtValor.Clear()
        dtpEmissao.Value = Now.Date
        dtpVencimento.Value = Now.Date
        dtpInclusao.Value = Now.Date
        ckbMesmoDia.Checked = False
        rbAtivo.Checked = False
        rbInativo.Checked = False
        dgvParcelas.DataSource = Nothing
        AtivaDesativa(False)
        tsbIncluir.Enabled = True
        tsbEditar.Enabled = True
        tsbConsultar.Enabled = True
        tsbCancelar.Enabled = False
        tsbGravar.Enabled = False

    End Sub

    Private Sub txtCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown
        If txtCliente.TextLength > 0 And e.KeyCode = Keys.Enter Then
            Dim objCliente As New CAD_CLIENTE
            Try
                objCliente.ID_CLIENTE = Convert.ToInt32(txtCliente.Text)
                If objCliente.BuscaCliente = True Then
                    lblCliente.Text = "- " & objCliente.NOME_CLIENTE
                End If
            Catch ex As Exception
                TrataErro("Problema ao pesquisar cliente.", ex)
            End Try
        ElseIf txtCliente.TextLength = 0 And e.KeyCode = Keys.Enter Then
            'Chama a pesquisa
            PesqCliente()
        End If
    End Sub

    Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged
        lblCliente.Text = "-"
    End Sub

    Private Sub btnPesqCliente_Click(sender As Object, e As EventArgs) Handles btnPesqCliente.Click
        'Chama a pesquisa
        PesqCliente()
    End Sub

    Private Sub btnGeraParcela_Click(sender As Object, e As EventArgs) Handles btnGeraParcela.Click
        GeraParcelas()
    End Sub

    Private Sub ckbMesmoDia_CheckedChanged(sender As Object, e As EventArgs) Handles ckbMesmoDia.CheckedChanged
        If ckbMesmoDia.Checked = True Then
            txtIntervalo.Enabled = False
            txtIntervalo.Clear()
        Else
            txtIntervalo.Enabled = True
        End If
    End Sub
End Class