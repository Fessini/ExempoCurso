Imports Cadastros
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
    'Private dtView As DataTable
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
        '
        'EXIBINDO POR LISTA
        ParcelasReceber.Clear()
        For Each Linha As DataRow In Pesq
            Dim nova As New PARCELA_CONTA_RECEBER
            nova.VALOR_PARCELA_RECEBER = Linha.Item("VALOR_PARCELA_RECEBER")
            nova.NUMERO_PARCELA_RECEBER = Linha.Item("NUMERO_PARCELA_RECEBER")
            nova.DATA_VENCIMENTO_RECEBER = Linha.Item("DATA_VENCIMENTO_RECEBER")
            ParcelasReceber.Add(nova)
        Next
        '
        'EXIBINDO POR DATATABLE
        'dtView.Rows.Clear()
        'For Each Linha As DataRow In Pesq
        '    dtView.ImportRow(Linha)
        'Next
        'dtView.AcceptChanges()

        dgvParcelas.AutoGenerateColumns = False
        dgvParcelas.DataSource = ParcelasReceber
        'dgvParcelas.DataSource = dtView
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
        'dtView = dtParcelas.Copy
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
        If txtIntervalo.TextLength > 0 Or ckbMesmoDia.Checked = True Then
            GeraParcelas()
        End If
    End Sub

    Private Sub ckbMesmoDia_CheckedChanged(sender As Object, e As EventArgs) Handles ckbMesmoDia.CheckedChanged
        If ckbMesmoDia.Checked = True Then
            txtIntervalo.Enabled = False
            txtIntervalo.Clear()
        Else
            txtIntervalo.Enabled = True
        End If
    End Sub

    Private Sub tsbGravar_Click(sender As Object, e As EventArgs) Handles tsbGravar.Click
        'DECLARA CLASSES
        Dim objConta As MOV_CONTA_RECEBER
        Dim blnValida As Boolean = True

        Try
            'FAZ A VALIDAÇÃO
            If lblCliente.Text = "-" Then
                epValida.SetError(txtCliente, "Favor selecione um cliente.")
                blnValida = False
            End If
            If IsDate(dtpEmissao.Value) = False Then
                epValida.SetError(dtpEmissao, "Formato de data incorreto.")
                blnValida = False
            End If
            If IsDate(dtpVencimento.Value) = False Then
                epValida.SetError(dtpVencimento, "Formato de data incorreto.")
                blnValida = False
            End If
            If txtValor.TextLength = 0 Then
                epValida.SetError(txtValor, "Favor informar o valor do documento.")
                blnValida = False
            Else
                If IsNumeric(txtValor.Text) = False Then
                    epValida.SetError(txtValor, "Formato incorreto de valor.")
                    blnValida = False
                End If
            End If
            If dgvParcelas.Rows.Count = 0 Then
                epValida.SetError(btnGeraParcela, "Favor gerar pelo menos uma parcela.")
                blnValida = False
            End If
            If blnValida = False Then Exit Sub
            '
            'INSTANCIA A CLASSE
            objConta = New MOV_CONTA_RECEBER
            objConta.CODIGO_CLIENTE = Convert.ToInt32(txtCliente.Text)
            objConta.DATA_EMISSAO_RECEBER = dtpEmissao.Value
            objConta.DATA_VENCIMENTO_RECEBER = dtpVencimento.Value
            objConta.NUMERO_DOCUMENTO_RECEBER = txtNumero.Text
            objConta.VALOR_CONTA_RECEBER = Convert.ToDouble(txtValor.Text)
            objConta.OBS_CONTA_RECEBER = txtObs.Text
            If rbAtivo.Checked = True Then
                objConta.STATUS_CONTA_RECEBER = MOV_CONTA_RECEBER.Ativo
            Else
                objConta.STATUS_CONTA_RECEBER = MOV_CONTA_RECEBER.Inativo
            End If
            '
            'FAZ A SELEÇÃO
            Select Case intOpcao
                Case Opcao.Incluir
                    If objConta.NovaConta(dtParcelas) = True Then
                        MessageBox.Show("Documento incluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Case Opcao.Editar
            End Select
        Catch ex As Exception
            TrataErro("Problema ao tentar gravar documento.", ex)
        End Try
    End Sub

    Private Sub txtDocumento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDocumento.KeyDown
        If txtDocumento.TextLength > 0 And e.KeyCode = Keys.Enter Then
            Dim objDocumento As New MOV_CONTA_RECEBER

            Try
                objDocumento.ID_CONTA_RECEBER = Convert.ToInt32(txtDocumento.Text)
                If objDocumento.BuscaDocumento = True Then
                    txtCliente.Text = objDocumento.CODIGO_CLIENTE
                    txtCliente_KeyDown(Nothing, e)
                    dtpEmissao.Value = objDocumento.DATA_EMISSAO_RECEBER
                    dtpVencimento.Value = objDocumento.DATA_VENCIMENTO_RECEBER
                    txtNumero.Text = objDocumento.NUMERO_DOCUMENTO_RECEBER
                    txtValor.Text = FormatNumber(objDocumento.VALOR_CONTA_RECEBER, 2)
                    txtObs.Text = objDocumento.OBS_CONTA_RECEBER
                    dtpInclusao.Value = objDocumento.DATA_INCLUSAO
                    If objDocumento.STATUS_CONTA_RECEBER = MOV_CONTA_RECEBER.Ativo Then
                        rbAtivo.Checked = True
                    Else
                        rbInativo.Checked = True
                    End If
                    '
                    'BUSCA DAS PARCELAS
                    dtParcelas = objDocumento.BuscaParcelas(Convert.ToInt32(txtDocumento.Text))
                    dtParcelas.Columns.Add("STATUS", GetType(String))
                    'PESQUISA AS PARCELAS
                    Pesq = dtParcelas.Select("STATUS <> 'D' OR STATUS IS NULL")
                    '
                    'EXIBINDO POR LISTA
                    ParcelasReceber.Clear()
                    For Each Linha As DataRow In Pesq
                        Dim nova As New PARCELA_CONTA_RECEBER
                        nova.VALOR_PARCELA_RECEBER = Linha.Item("VALOR_PARCELA_RECEBER")
                        nova.NUMERO_PARCELA_RECEBER = Linha.Item("NUMERO_PARCELA_RECEBER")
                        nova.DATA_VENCIMENTO_RECEBER = Linha.Item("DATA_VENCIMENTO_RECEBER")
                        If Not IsDBNull(Linha.Item("NOME_BANCO")) Then nova.NOME_BANCO = Linha.Item("NOME_BANCO")
                        ParcelasReceber.Add(nova)
                    Next
                    dgvParcelas.AutoGenerateColumns = False
                    dgvParcelas.DataSource = ParcelasReceber
                    dgvParcelas.Refresh()

                    If intOpcao = Opcao.Editar Then
                        AtivaDesativa(True)
                        tsbGravar.Enabled = True
                    End If
                Else
                    MessageBox.Show("Documento não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                TrataErro("Problema ao tentar carregar documento.", ex)
            End Try
        End If
    End Sub
End Class