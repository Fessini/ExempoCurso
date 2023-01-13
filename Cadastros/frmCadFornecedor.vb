Imports DataBase
Imports System.Windows.Forms
Imports DataBase.Utils

Public Class frmCadFornecedor
#Region "Variáveis"
    Private Enum Opcao As Integer
        Cancelar = 0
        Incluir = 1
        Editar = 2
        Consultar = 3
    End Enum
    Private intOpcao As Opcao
#End Region
#Region "Métodos"
    Private Sub PesqFornecedor()
        Using frm As New frmPesqFornecedor
            frm.ShowDialog()
            If frm.IDFORNECEDOR > 0 Then
                Dim enter As New KeyEventArgs(Keys.Enter)
                txtID.Text = frm.IDFORNECEDOR
                txtID_KeyDown(Nothing, enter)
            End If
        End Using
    End Sub
    Private Sub AtivaDesativa(ByVal Status As Boolean)
        rbFisico.Enabled = Status
        rbJuridico.Enabled = Status
        If Status = False Then
            txtID.Enabled = Status
            btnPesquisar.Enabled = Status
        End If
        txtBairro.Enabled = Status
        txtCEP.Enabled = Status
        txtCidade.Enabled = Status
        txtComplemento.Enabled = Status
        txtCPFCNPJ.Enabled = Status
        txtEmail.Enabled = Status
        txtFantasia.Enabled = Status
        txtFone1.Enabled = Status
        txtFone2.Enabled = Status
        txtInscEstadual.Enabled = Status
        txtInsMunicipal.Enabled = Status
        txtLogradouro.Enabled = Status
        txtNome.Enabled = Status
        txtNumero.Enabled = Status
        txtUF.Enabled = Status
    End Sub
#End Region

    Private Sub tsbIncluir_Click(sender As Object, e As EventArgs) Handles tsbIncluir.Click
        'TIPO DE OPERAÇÃO
        intOpcao = Opcao.Incluir
        'alterado pelo notebook
        'CONFIGURANDO OS BOTÕES
        tsbIncluir.Enabled = False
        tsbEditar.Enabled = False
        tsbConsultar.Enabled = False
        tsbCancelar.Enabled = True
        tsbGravar.Enabled = True
        '
        'ATIVANDO OS CONTROLES
        AtivaDesativa(True)
        rbJuridico.Checked = True
        txtNome.Focus()
    End Sub

    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click
        'TIPO DE OPERAÇÃO
        intOpcao = Opcao.Editar
        '
        'CONFIGURANDO OS BOTÕES
        tsbIncluir.Enabled = False
        tsbEditar.Enabled = False
        tsbConsultar.Enabled = False
        tsbCancelar.Enabled = True
        '
        'ATIVANDO OS CONTROLES
        txtID.Enabled = True
        btnPesquisar.Enabled = True
        txtID.Focus()
    End Sub

    Private Sub tsbConsultar_Click(sender As Object, e As EventArgs) Handles tsbConsultar.Click
        'TIPO DE OPERAÇÃO
        intOpcao = Opcao.Consultar
        '
        'CONFIGURANDO OS BOTÕES
        tsbIncluir.Enabled = False
        tsbEditar.Enabled = False
        tsbConsultar.Enabled = False
        tsbCancelar.Enabled = True
        '
        'ATIVANDO OS CONTROLES
        txtID.Enabled = True
        btnPesquisar.Enabled = True
        txtID.Focus()
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        'PERGUNTA PARA O USUÁRIO
        If intOpcao = Opcao.Incluir And txtNome.TextLength > 0 Then
            If MessageBox.Show("Você tem certeza que deseja cancelar?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
        ElseIf intOpcao = Opcao.Editar And txtID.Enabled = False Then
            If MessageBox.Show("Você tem certeza que deseja cancelar?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
        End If
        '
        'SETA TIPO DE OPERAÇÃO
        intOpcao = Opcao.Cancelar
        '
        'LIMPA OS CONTROLES
        rbFisico.Checked = False
        rbJuridico.Checked = False
        txtBairro.Clear()
        txtCEP.Clear()
        txtCidade.Clear()
        txtComplemento.Clear()
        txtCPFCNPJ.Clear()
        txtEmail.Clear()
        txtFantasia.Clear()
        txtFone1.Clear()
        txtFone2.Clear()
        txtID.Clear()
        txtInscEstadual.Clear()
        txtInsMunicipal.Clear()
        txtLogradouro.Clear()
        txtNome.Clear()
        txtNumero.Clear()
        txtUF.Clear()
        dtpAlteracao.Value = Now.Date
        dtpInclusao.Value = Now.Date
        AtivaDesativa(False)
        '
        'VOLTA A CONFIGURAÇÃO DOS BOTÕES
        tsbIncluir.Enabled = True
        tsbEditar.Enabled = True
        tsbConsultar.Enabled = True
        tsbCancelar.Enabled = False
        tsbGravar.Enabled = False
        epValida.Clear()
    End Sub

    Private Sub rbFisico_CheckedChanged(sender As Object, e As EventArgs) Handles rbFisico.CheckedChanged
        txtFantasia.Enabled = False
        txtFantasia.Clear()
        txtCPFCNPJ.ValidaCPF = True
    End Sub

    Private Sub rbJuridico_CheckedChanged(sender As Object, e As EventArgs) Handles rbJuridico.CheckedChanged
        txtFantasia.Enabled = True
        txtCPFCNPJ.ValidaCNPJ = True
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtNome_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNome.Validating
        If txtNome.TextLength > 0 Then
            epValida.SetError(txtNome, "")
        End If
    End Sub

    Private Sub txtFone1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFone1.Validating
        If txtFone1.TextLength > 0 Then
            epValida.SetError(txtFone1, "")
        End If
    End Sub

    Private Sub txtCEP_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCEP.Validating
        If txtCEP.TextLength > 0 Then
            epValida.SetError(txtCEP, "")
        End If
    End Sub

    Private Sub txtLogradouro_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtLogradouro.Validating
        If txtLogradouro.TextLength > 0 Then
            epValida.SetError(txtLogradouro, "")
        End If
    End Sub

    Private Sub txtBairro_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtBairro.Validating
        If txtBairro.TextLength > 0 Then
            epValida.SetError(txtBairro, "")
        End If
    End Sub

    Private Sub txtCidade_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCidade.Validating
        If txtCidade.TextLength > 0 Then
            epValida.SetError(txtCidade, "")
        End If
    End Sub

    Private Sub txtUF_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUF.Validating
        If txtUF.TextLength > 0 Then
            epValida.SetError(txtUF, "")
        End If
    End Sub

    Private Sub tsbGravar_Click(sender As Object, e As EventArgs) Handles tsbGravar.Click
        Dim blnValida As Boolean = True
        Dim objFORNECEDOR As CAD_FORNECEDOR

        Try
            'VALIDAÇÃO DOS CAMPOS
            If txtNome.TextLength = 0 Then
                epValida.SetError(txtNome, "Informar o campo nome.")
                blnValida = False
            End If
            If txtFantasia.TextLength = 0 And rbJuridico.Checked = True Then
                epValida.SetError(txtFantasia, "Iformar o compo fantasia.")
                blnValida = False
            End If
            If txtCPFCNPJ.IsValido = False Then
                blnValida = False
            End If
            If txtFone1.TextLength = 0 Then
                epValida.SetError(txtFone1, "Informar um telefone.")
                blnValida = False
            End If
            If txtCEP.TextLength = 0 Then
                epValida.SetError(txtCEP, "Informar o campo cep.")
                blnValida = False
            End If
            If txtLogradouro.TextLength = 0 Then
                epValida.SetError(txtLogradouro, "Informar o compo logradouro.")
                blnValida = False
            End If
            If txtBairro.TextLength = 0 Then
                epValida.SetError(txtBairro, "Infomar o campo bairro.")
                blnValida = False
            End If
            If txtCidade.TextLength = 0 Then
                epValida.SetError(txtCidade, "Informar o campo cidade.")
                blnValida = False
            End If
            If txtUF.TextLength = 0 Then
                epValida.SetError(txtUF, "Informar o campo uf.")
                blnValida = False
            End If
            If blnValida = False Then Exit Sub
            '
            'INSTANCIA A CLASSE
            objFORNECEDOR = New CAD_FORNECEDOR With {
                .BAIRRO_FORNECEDOR = txtBairro.Text,
                .CEP_FORNECEDOR = txtCEP.Text,
                .CIDADE_FORNECEDOR = txtCidade.Text,
                .COMPLEMENTO_FORNECEDOR = txtComplemento.Text,
                .CPF_CNPJ_FORNECEDOR = txtCPFCNPJ.Text,
                .EMAIL_FORNECEDOR = txtEmail.Text,
                .ENDERECO_FORNECEDOR = txtLogradouro.Text,
                .FONE_FORNECEDOR_1 = txtFone1.Text,
                .FONE_FORNECEDOR_2 = txtFone2.Text,
                .FANTASIA_FORNECEDOR = txtFantasia.Text,
                .INSC_ESTADUAL_FORNECEDOR = txtInscEstadual.Text,
                .INSC_MUNICIPAL_FORNECEDOR = txtInsMunicipal.Text,
                .NOME_FORNECEDOR = txtNome.Text,
                .NUMERO_FORNECEDOR = txtNumero.Text,
                .TIPO_FORNECEDOR = IIf(rbFisico.Checked, "F", "J"),
                .UF = txtUF.Text}
            '.ID_FORNECEDOR = IIf(txtID.TextLength > 0, Convert.ToInt32(txtID.Text), "0")}
            If txtID.TextLength > 0 Then
                objFORNECEDOR.ID_FORNECEDOR = Convert.ToInt32(txtID.Text)
            End If

            '
            'SELECIONA O TIPO DE OPERAÇÃO
            Select Case intOpcao
                Case Opcao.Incluir
                    If objFORNECEDOR.NovoFORNECEDOR Then
                        'SETA TIPO OPERAÇÃO
                        intOpcao = Opcao.Cancelar
                        '
                        'CHAMA SUBROTINA PARA LIMPA
                        tsbCancelar_Click(Nothing, Nothing)
                        '
                        'FAZ PERGUNTA PARA ADICIONAR OUTRO
                        If MessageBox.Show("Fornecedor adicionado com sucesso!" & vbNewLine &
                                           "Deseja adicionar outro?", "Aviso",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            'CHAMA ROTINA PARA INCLUIR OUTRO
                            tsbIncluir_Click(Nothing, Nothing)
                        End If
                    Else
                        MessageBox.Show("Problema ao tentar gravar fornecedor.", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                    End If
                Case Opcao.Editar
                    If objFORNECEDOR.AtualizaFORNECEDOR Then
                        'SETA TIPO OPERAÇÃO
                        intOpcao = Opcao.Cancelar
                        '
                        'CHAMA SUBROTINA PARA LIMPA
                        tsbCancelar_Click(Nothing, Nothing)
                        '
                        'FAZ PERGUNTA PARA ADICIONAR OUTRO
                        If MessageBox.Show("Fornecedor alterado com sucesso!" & vbNewLine &
                                           "Deseja alterar outro?", "Aviso",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            'CHAMA ROTINA PARA INCLUIR OUTRO
                            tsbEditar_Click(Nothing, Nothing)
                        End If
                    Else
                        MessageBox.Show("Problema ao tentar gravar fornecedor.", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                    End If
            End Select
        Catch ex As Exception
            TrataErro("Problema ao tentar gravar fornecedor.", ex)
        End Try
    End Sub

    Private Sub txtID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID.KeyDown
        If txtID.TextLength > 0 And e.KeyCode = Keys.Enter Then
            Dim objFORNECEDOR As New CAD_FORNECEDOR

            Try
                objFORNECEDOR.ID_FORNECEDOR = Convert.ToInt32(txtID.Text)
                'PREECHE OS DADOS
                If objFORNECEDOR.BuscaFORNECEDOR Then
                    txtBairro.Text = objFORNECEDOR.BAIRRO_FORNECEDOR
                    txtCEP.Text = objFORNECEDOR.CEP_FORNECEDOR
                    txtCidade.Text = objFORNECEDOR.CIDADE_FORNECEDOR
                    txtComplemento.Text = objFORNECEDOR.COMPLEMENTO_FORNECEDOR
                    txtCPFCNPJ.Text = objFORNECEDOR.CPF_CNPJ_FORNECEDOR
                    txtCPFCNPJ.IsValido = True
                    txtEmail.Text = objFORNECEDOR.EMAIL_FORNECEDOR
                    txtFantasia.Text = objFORNECEDOR.FANTASIA_FORNECEDOR
                    txtFone1.Text = objFORNECEDOR.FONE_FORNECEDOR_1
                    txtFone2.Text = objFORNECEDOR.FONE_FORNECEDOR_2
                    txtInscEstadual.Text = objFORNECEDOR.INSC_ESTADUAL_FORNECEDOR
                    txtInsMunicipal.Text = objFORNECEDOR.INSC_MUNICIPAL_FORNECEDOR
                    txtLogradouro.Text = objFORNECEDOR.ENDERECO_FORNECEDOR
                    txtNome.Text = objFORNECEDOR.NOME_FORNECEDOR
                    txtNumero.Text = objFORNECEDOR.NUMERO_FORNECEDOR
                    txtUF.Text = objFORNECEDOR.UF
                    dtpInclusao.Value = objFORNECEDOR.DATA_INCLUSAO_FORNECEDOR.Date
                    If objFORNECEDOR.DATA_ALTERACAO_FORNECEDOR <> CDate("01/01/0001") Then
                        dtpAlteracao.Value = objFORNECEDOR.DATA_ALTERACAO_FORNECEDOR.Date
                    End If
                    '
                    'VERIFICA O TIPO DE OPERAÇÃO
                    If intOpcao = Opcao.Editar Then
                        txtID.Enabled = False
                        btnPesquisar.Enabled = False
                        AtivaDesativa(True)
                        tsbGravar.Enabled = True
                        txtNome.Focus()
                    End If
                    If objFORNECEDOR.TIPO_FORNECEDOR = CAD_FORNECEDOR.Fisico Then
                        rbFisico.Checked = True
                    Else
                        rbJuridico.Checked = True
                    End If
                Else
                    MessageBox.Show("ID não cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                TrataErro("Problema ao tentar localizar fornecedor.", ex)
            End Try
        ElseIf txtID.TextLength = 0 And e.KeyCode = Keys.Enter Then
            'CHAMA FORMULÁRIO DE PESQUISA DE FORNECEDOR
            PesqFornecedor()
        End If
    End Sub

    Private Sub txtCEP_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCEP.KeyDown
        If txtCEP.TextLength > 0 And e.KeyCode = Keys.Enter Then
            Try
                Dim cep As BUSCA_CEP = PesquisaCEP(txtCEP.Text.Replace("-", ""))
                txtLogradouro.Text = cep.logradouro
                txtBairro.Text = cep.bairro
                txtCidade.Text = cep.localidade
                txtUF.Text = cep.uf
                txtNumero.Focus()
            Catch ex As Exception
                TrataErro("Problema ao tentar consultar cep, verifique sua conexão com a internet.", ex)
            End Try


        End If
    End Sub

    Private Sub frmCadFORNECEDOR_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If tsbIncluir.Enabled = True And e.KeyCode = Keys.F2 Then
            tsbIncluir_Click(Nothing, Nothing)
        ElseIf tsbEditar.Enabled = True And e.KeyCode = Keys.F3 Then
            tsbEditar_Click(Nothing, Nothing)
        ElseIf tsbConsultar.Enabled = True And e.KeyCode = Keys.F4 Then
            tsbConsultar_Click(Nothing, Nothing)
        ElseIf tsbGravar.Enabled = True And e.KeyCode = Keys.F5 Then
            tsbGravar_Click(Nothing, Nothing)
        ElseIf tsbCancelar.Enabled = True And e.KeyCode = Keys.Escape Then
            tsbCancelar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        'CHAMA FORMULÁRIO DE PESQUISA DE FORNECEDOR
        PesqFornecedor()
    End Sub
End Class