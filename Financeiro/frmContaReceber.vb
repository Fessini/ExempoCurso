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
#End Region

#Region "Métodos"
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
End Class