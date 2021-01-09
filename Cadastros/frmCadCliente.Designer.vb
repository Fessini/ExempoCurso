<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadCliente))
        Me.tsPrincipal = New System.Windows.Forms.ToolStrip()
        Me.tsbIncluir = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.tsbGravar = New System.Windows.Forms.ToolStripButton()
        Me.tsbDeletar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbFechar = New System.Windows.Forms.ToolStripButton()
        Me.ssPrincipal = New System.Windows.Forms.StatusStrip()
        Me.tsslAtalho = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCEP = New Controls.CursoCEP()
        Me.txtFone2 = New Controls.CursoTelefone()
        Me.txtFone1 = New Controls.CursoTelefone()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.dtpAlteracao = New System.Windows.Forms.DateTimePicker()
        Me.dtpInclusao = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtComplemento = New Controls.CursoTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtUF = New Controls.CursoTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCidade = New Controls.CursoTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBairro = New Controls.CursoTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNumero = New Controls.CursoTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtLogradouro = New Controls.CursoTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmail = New Controls.CursoTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtInscEstadual = New Controls.CursoTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtInsMunicipal = New Controls.CursoTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCPFCNPJ = New Controls.CursoTextBoxCPF_CNPJ()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFantasia = New Controls.CursoTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNome = New Controls.CursoTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New Controls.CursoTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbJuridico = New System.Windows.Forms.RadioButton()
        Me.rbFisico = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.epValida = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tsPrincipal.SuspendLayout()
        Me.ssPrincipal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsPrincipal
        '
        Me.tsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbIncluir, Me.tsbEditar, Me.tsbConsultar, Me.ToolStripSeparator1, Me.tsbCancelar, Me.tsbGravar, Me.tsbDeletar, Me.ToolStripSeparator2, Me.tsbFechar})
        Me.tsPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tsPrincipal.Name = "tsPrincipal"
        Me.tsPrincipal.Size = New System.Drawing.Size(800, 54)
        Me.tsPrincipal.TabIndex = 0
        Me.tsPrincipal.Text = "ToolStrip1"
        '
        'tsbIncluir
        '
        Me.tsbIncluir.Image = Global.Cadastros.My.Resources.Resources.icone_novo
        Me.tsbIncluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbIncluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbIncluir.Name = "tsbIncluir"
        Me.tsbIncluir.Size = New System.Drawing.Size(44, 51)
        Me.tsbIncluir.Text = "Incluir"
        Me.tsbIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbEditar
        '
        Me.tsbEditar.Image = Global.Cadastros.My.Resources.Resources.icone_editar
        Me.tsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(41, 51)
        Me.tsbEditar.Text = "Editar"
        Me.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbConsultar
        '
        Me.tsbConsultar.Image = Global.Cadastros.My.Resources.Resources.icone_consultar
        Me.tsbConsultar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsultar.Name = "tsbConsultar"
        Me.tsbConsultar.Size = New System.Drawing.Size(62, 51)
        Me.tsbConsultar.Text = "Consultar"
        Me.tsbConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Enabled = False
        Me.tsbCancelar.Image = Global.Cadastros.My.Resources.Resources.icone_cancelar
        Me.tsbCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(57, 51)
        Me.tsbCancelar.Text = "Cancelar"
        Me.tsbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbGravar
        '
        Me.tsbGravar.Enabled = False
        Me.tsbGravar.Image = Global.Cadastros.My.Resources.Resources.icone_salvar
        Me.tsbGravar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbGravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGravar.Name = "tsbGravar"
        Me.tsbGravar.Size = New System.Drawing.Size(45, 51)
        Me.tsbGravar.Text = "Gravar"
        Me.tsbGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbDeletar
        '
        Me.tsbDeletar.Enabled = False
        Me.tsbDeletar.Image = Global.Cadastros.My.Resources.Resources.icone_deletar
        Me.tsbDeletar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbDeletar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDeletar.Name = "tsbDeletar"
        Me.tsbDeletar.Size = New System.Drawing.Size(48, 51)
        Me.tsbDeletar.Text = "Deletar"
        Me.tsbDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbDeletar.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 54)
        '
        'tsbFechar
        '
        Me.tsbFechar.Image = Global.Cadastros.My.Resources.Resources.icone_sair
        Me.tsbFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFechar.Name = "tsbFechar"
        Me.tsbFechar.Size = New System.Drawing.Size(46, 51)
        Me.tsbFechar.Text = "Fechar"
        Me.tsbFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ssPrincipal
        '
        Me.ssPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslAtalho})
        Me.ssPrincipal.Location = New System.Drawing.Point(0, 393)
        Me.ssPrincipal.Name = "ssPrincipal"
        Me.ssPrincipal.Size = New System.Drawing.Size(800, 22)
        Me.ssPrincipal.TabIndex = 2
        Me.ssPrincipal.Text = "StatusStrip1"
        '
        'tsslAtalho
        '
        Me.tsslAtalho.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslAtalho.Name = "tsslAtalho"
        Me.tsslAtalho.Size = New System.Drawing.Size(375, 17)
        Me.tsslAtalho.Text = "Incluir - F2 | Editar - F3 | Consultar - F4 | Gravar - F5 | Cancelar - Esc"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCEP)
        Me.GroupBox1.Controls.Add(Me.txtFone2)
        Me.GroupBox1.Controls.Add(Me.txtFone1)
        Me.GroupBox1.Controls.Add(Me.btnPesquisar)
        Me.GroupBox1.Controls.Add(Me.dtpAlteracao)
        Me.GroupBox1.Controls.Add(Me.dtpInclusao)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtComplemento)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtUF)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtCidade)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtBairro)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtLogradouro)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtInscEstadual)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtInsMunicipal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCPFCNPJ)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtFantasia)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rbJuridico)
        Me.GroupBox1.Controls.Add(Me.rbFisico)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 333)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtCEP
        '
        Me.txtCEP.Enabled = False
        Me.txtCEP.EnviaTab = False
        Me.txtCEP.Location = New System.Drawing.Point(76, 250)
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(100, 20)
        Me.txtCEP.TabIndex = 22
        '
        'txtFone2
        '
        Me.txtFone2.Enabled = False
        Me.txtFone2.EnviaTab = True
        Me.txtFone2.Location = New System.Drawing.Point(182, 198)
        Me.txtFone2.Name = "txtFone2"
        Me.txtFone2.Size = New System.Drawing.Size(100, 20)
        Me.txtFone2.TabIndex = 18
        '
        'txtFone1
        '
        Me.txtFone1.Enabled = False
        Me.txtFone1.EnviaTab = True
        Me.txtFone1.Location = New System.Drawing.Point(76, 198)
        Me.txtFone1.Name = "txtFone1"
        Me.txtFone1.Size = New System.Drawing.Size(100, 20)
        Me.txtFone1.TabIndex = 17
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Enabled = False
        Me.btnPesquisar.Image = Global.Cadastros.My.Resources.Resources.icone_procurar
        Me.btnPesquisar.Location = New System.Drawing.Point(182, 39)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(31, 23)
        Me.btnPesquisar.TabIndex = 5
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'dtpAlteracao
        '
        Me.dtpAlteracao.Enabled = False
        Me.dtpAlteracao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAlteracao.Location = New System.Drawing.Point(665, 45)
        Me.dtpAlteracao.Name = "dtpAlteracao"
        Me.dtpAlteracao.Size = New System.Drawing.Size(105, 20)
        Me.dtpAlteracao.TabIndex = 37
        '
        'dtpInclusao
        '
        Me.dtpInclusao.Enabled = False
        Me.dtpInclusao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInclusao.Location = New System.Drawing.Point(665, 19)
        Me.dtpInclusao.Name = "dtpInclusao"
        Me.dtpInclusao.Size = New System.Drawing.Size(105, 20)
        Me.dtpInclusao.TabIndex = 36
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(604, 51)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 13)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Alteração:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(609, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 13)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Inclusâo:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Enabled = False
        Me.txtComplemento.EnviaTab = True
        Me.txtComplemento.Location = New System.Drawing.Point(76, 302)
        Me.txtComplemento.MaxLength = 20
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(206, 20)
        Me.txtComplemento.SomenteNumero = False
        Me.txtComplemento.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(30, 305)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Comp.:"
        '
        'txtUF
        '
        Me.txtUF.Enabled = False
        Me.txtUF.EnviaTab = True
        Me.txtUF.Location = New System.Drawing.Point(597, 276)
        Me.txtUF.MaxLength = 2
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(100, 20)
        Me.txtUF.SomenteNumero = False
        Me.txtUF.TabIndex = 33
        Me.txtUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(567, 279)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "UF:"
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.EnviaTab = True
        Me.txtCidade.Location = New System.Drawing.Point(337, 276)
        Me.txtCidade.MaxLength = 50
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(201, 20)
        Me.txtCidade.SomenteNumero = False
        Me.txtCidade.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(288, 279)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Cidade:"
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.EnviaTab = True
        Me.txtBairro.Location = New System.Drawing.Point(76, 276)
        Me.txtBairro.MaxLength = 50
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(206, 20)
        Me.txtBairro.SomenteNumero = False
        Me.txtBairro.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(33, 279)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Bairro:"
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.EnviaTab = True
        Me.txtNumero.Location = New System.Drawing.Point(597, 250)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.SomenteNumero = False
        Me.txtNumero.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(544, 253)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Número:"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Enabled = False
        Me.txtLogradouro.EnviaTab = True
        Me.txtLogradouro.Location = New System.Drawing.Point(252, 250)
        Me.txtLogradouro.MaxLength = 100
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(286, 20)
        Me.txtLogradouro.SomenteNumero = False
        Me.txtLogradouro.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(182, 253)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Logradouro:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "CEP:"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.EnviaTab = True
        Me.txtEmail.Location = New System.Drawing.Point(76, 224)
        Me.txtEmail.MaxLength = 30
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(160, 20)
        Me.txtEmail.SomenteNumero = False
        Me.txtEmail.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "E-mail:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Fone:"
        '
        'txtInscEstadual
        '
        Me.txtInscEstadual.Enabled = False
        Me.txtInscEstadual.EnviaTab = True
        Me.txtInscEstadual.Location = New System.Drawing.Point(76, 172)
        Me.txtInscEstadual.MaxLength = 15
        Me.txtInscEstadual.Name = "txtInscEstadual"
        Me.txtInscEstadual.Size = New System.Drawing.Size(100, 20)
        Me.txtInscEstadual.SomenteNumero = False
        Me.txtInscEstadual.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Ins. Est.:"
        '
        'txtInsMunicipal
        '
        Me.txtInsMunicipal.Enabled = False
        Me.txtInsMunicipal.EnviaTab = True
        Me.txtInsMunicipal.Location = New System.Drawing.Point(76, 146)
        Me.txtInsMunicipal.MaxLength = 15
        Me.txtInsMunicipal.Name = "txtInsMunicipal"
        Me.txtInsMunicipal.Size = New System.Drawing.Size(100, 20)
        Me.txtInsMunicipal.SomenteNumero = False
        Me.txtInsMunicipal.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Ins. Mun.:"
        '
        'txtCPFCNPJ
        '
        Me.txtCPFCNPJ.Enabled = False
        Me.txtCPFCNPJ.EnviaTab = True
        Me.txtCPFCNPJ.ExibirMensagem = True
        Me.txtCPFCNPJ.IsValido = False
        Me.txtCPFCNPJ.Location = New System.Drawing.Point(76, 120)
        Me.txtCPFCNPJ.MaxLength = 14
        Me.txtCPFCNPJ.Name = "txtCPFCNPJ"
        Me.txtCPFCNPJ.Size = New System.Drawing.Size(144, 20)
        Me.txtCPFCNPJ.TabIndex = 11
        Me.txtCPFCNPJ.ValidaCNPJ = False
        Me.txtCPFCNPJ.ValidaCPF = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "CPF/CNPJ:"
        '
        'txtFantasia
        '
        Me.txtFantasia.Enabled = False
        Me.txtFantasia.EnviaTab = True
        Me.txtFantasia.Location = New System.Drawing.Point(76, 94)
        Me.txtFantasia.MaxLength = 200
        Me.txtFantasia.Name = "txtFantasia"
        Me.txtFantasia.Size = New System.Drawing.Size(326, 20)
        Me.txtFantasia.SomenteNumero = False
        Me.txtFantasia.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fantasia:"
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.EnviaTab = True
        Me.txtNome.Location = New System.Drawing.Point(76, 68)
        Me.txtNome.MaxLength = 200
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(326, 20)
        Me.txtNome.SomenteNumero = False
        Me.txtNome.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nome:"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.EnviaTab = False
        Me.txtID.Location = New System.Drawing.Point(76, 42)
        Me.txtID.MaxLength = 7
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.SomenteNumero = True
        Me.txtID.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID:"
        '
        'rbJuridico
        '
        Me.rbJuridico.AutoSize = True
        Me.rbJuridico.Enabled = False
        Me.rbJuridico.Location = New System.Drawing.Point(136, 19)
        Me.rbJuridico.Name = "rbJuridico"
        Me.rbJuridico.Size = New System.Drawing.Size(63, 17)
        Me.rbJuridico.TabIndex = 2
        Me.rbJuridico.TabStop = True
        Me.rbJuridico.Text = "Jurídico"
        Me.rbJuridico.UseVisualStyleBackColor = True
        '
        'rbFisico
        '
        Me.rbFisico.AutoSize = True
        Me.rbFisico.Enabled = False
        Me.rbFisico.Location = New System.Drawing.Point(76, 19)
        Me.rbFisico.Name = "rbFisico"
        Me.rbFisico.Size = New System.Drawing.Size(54, 17)
        Me.rbFisico.TabIndex = 1
        Me.rbFisico.TabStop = True
        Me.rbFisico.Text = "Físico"
        Me.rbFisico.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo:"
        '
        'epValida
        '
        Me.epValida.ContainerControl = Me
        '
        'frmCadCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 415)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ssPrincipal)
        Me.Controls.Add(Me.tsPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCadCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro Cliente"
        Me.tsPrincipal.ResumeLayout(False)
        Me.tsPrincipal.PerformLayout()
        Me.ssPrincipal.ResumeLayout(False)
        Me.ssPrincipal.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsPrincipal As Windows.Forms.ToolStrip
    Friend WithEvents tsbEditar As Windows.Forms.ToolStripButton
    Friend WithEvents tsbIncluir As Windows.Forms.ToolStripButton
    Friend WithEvents tsbConsultar As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbCancelar As Windows.Forms.ToolStripButton
    Friend WithEvents tsbGravar As Windows.Forms.ToolStripButton
    Friend WithEvents tsbDeletar As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbFechar As Windows.Forms.ToolStripButton
    Friend WithEvents ssPrincipal As Windows.Forms.StatusStrip
    Friend WithEvents tsslAtalho As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents rbJuridico As Windows.Forms.RadioButton
    Friend WithEvents rbFisico As Windows.Forms.RadioButton
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtComplemento As Controls.CursoTextBox
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents txtUF As Controls.CursoTextBox
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents txtCidade As Controls.CursoTextBox
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents txtBairro As Controls.CursoTextBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents txtNumero As Controls.CursoTextBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents txtLogradouro As Controls.CursoTextBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents txtEmail As Controls.CursoTextBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents txtInscEstadual As Controls.CursoTextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents txtInsMunicipal As Controls.CursoTextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents txtCPFCNPJ As Controls.CursoTextBoxCPF_CNPJ
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txtFantasia As Controls.CursoTextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtNome As Controls.CursoTextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtID As Controls.CursoTextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents dtpAlteracao As Windows.Forms.DateTimePicker
    Friend WithEvents dtpInclusao As Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents btnPesquisar As Windows.Forms.Button
    Friend WithEvents epValida As Windows.Forms.ErrorProvider
    Friend WithEvents txtFone2 As Controls.CursoTelefone
    Friend WithEvents txtFone1 As Controls.CursoTelefone
    Friend WithEvents txtCEP As Controls.CursoCEP
End Class
