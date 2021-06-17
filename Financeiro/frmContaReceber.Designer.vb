<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContaReceber
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbInativo = New System.Windows.Forms.RadioButton()
        Me.rbAtivo = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnGeraParcela = New System.Windows.Forms.Button()
        Me.ckbMesmoDia = New System.Windows.Forms.CheckBox()
        Me.txtIntervalo = New Controls.CursoTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtQtdParcelas = New Controls.CursoTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpInclusao = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.txtObs = New Controls.CursoTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtValor = New Controls.CursoTextBoxMonetario()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumero = New Controls.CursoTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpVencimento = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpEmissao = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.btnPesqCliente = New System.Windows.Forms.Button()
        Me.txtCliente = New Controls.CursoTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.txtDocumento = New Controls.CursoTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEstornar = New System.Windows.Forms.Button()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnBaixar = New System.Windows.Forms.Button()
        Me.dgvParcelas = New System.Windows.Forms.DataGridView()
        Me.ssPrincipal = New System.Windows.Forms.StatusStrip()
        Me.tsslAtalho = New System.Windows.Forms.ToolStripStatusLabel()
        Me.colIdMovItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodigoContaReceber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVencimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodigoContaBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPagamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsPrincipal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ssPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsPrincipal
        '
        Me.tsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbIncluir, Me.tsbEditar, Me.tsbConsultar, Me.ToolStripSeparator1, Me.tsbCancelar, Me.tsbGravar, Me.tsbDeletar, Me.ToolStripSeparator2, Me.tsbFechar})
        Me.tsPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tsPrincipal.Name = "tsPrincipal"
        Me.tsPrincipal.Size = New System.Drawing.Size(603, 54)
        Me.tsPrincipal.TabIndex = 1
        Me.tsPrincipal.Text = "ToolStrip1"
        '
        'tsbIncluir
        '
        Me.tsbIncluir.Image = Global.Financeiro.My.Resources.Resources.icone_novo
        Me.tsbIncluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbIncluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbIncluir.Name = "tsbIncluir"
        Me.tsbIncluir.Size = New System.Drawing.Size(44, 51)
        Me.tsbIncluir.Text = "Incluir"
        Me.tsbIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbEditar
        '
        Me.tsbEditar.Image = Global.Financeiro.My.Resources.Resources.icone_editar
        Me.tsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(41, 51)
        Me.tsbEditar.Text = "Editar"
        Me.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbConsultar
        '
        Me.tsbConsultar.Image = Global.Financeiro.My.Resources.Resources.icone_consultar
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
        Me.tsbCancelar.Image = Global.Financeiro.My.Resources.Resources.icone_cancelar
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
        Me.tsbGravar.Image = Global.Financeiro.My.Resources.Resources.icone_salvar
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
        Me.tsbDeletar.Image = Global.Financeiro.My.Resources.Resources.icone_deletar
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
        Me.tsbFechar.Image = Global.Financeiro.My.Resources.Resources.icone_sair
        Me.tsbFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFechar.Name = "tsbFechar"
        Me.tsbFechar.Size = New System.Drawing.Size(46, 51)
        Me.tsbFechar.Text = "Fechar"
        Me.tsbFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.dtpInclusao)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblObs)
        Me.GroupBox1.Controls.Add(Me.txtObs)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpVencimento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpEmissao)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblCliente)
        Me.GroupBox1.Controls.Add(Me.btnPesqCliente)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnPesquisa)
        Me.GroupBox1.Controls.Add(Me.txtDocumento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 217)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documento"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbInativo)
        Me.GroupBox4.Controls.Add(Me.rbAtivo)
        Me.GroupBox4.Location = New System.Drawing.Point(414, 173)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(161, 38)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Status"
        '
        'rbInativo
        '
        Me.rbInativo.AutoSize = True
        Me.rbInativo.Enabled = False
        Me.rbInativo.Location = New System.Drawing.Point(63, 15)
        Me.rbInativo.Name = "rbInativo"
        Me.rbInativo.Size = New System.Drawing.Size(57, 17)
        Me.rbInativo.TabIndex = 1
        Me.rbInativo.TabStop = True
        Me.rbInativo.Text = "Inativo"
        Me.rbInativo.UseVisualStyleBackColor = True
        '
        'rbAtivo
        '
        Me.rbAtivo.AutoSize = True
        Me.rbAtivo.Enabled = False
        Me.rbAtivo.Location = New System.Drawing.Point(8, 15)
        Me.rbAtivo.Name = "rbAtivo"
        Me.rbAtivo.Size = New System.Drawing.Size(49, 17)
        Me.rbAtivo.TabIndex = 0
        Me.rbAtivo.TabStop = True
        Me.rbAtivo.Text = "Ativo"
        Me.rbAtivo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnGeraParcela)
        Me.GroupBox3.Controls.Add(Me.ckbMesmoDia)
        Me.GroupBox3.Controls.Add(Me.txtIntervalo)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtQtdParcelas)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(414, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(161, 119)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Parcelar"
        '
        'btnGeraParcela
        '
        Me.btnGeraParcela.Enabled = False
        Me.btnGeraParcela.Location = New System.Drawing.Point(43, 88)
        Me.btnGeraParcela.Name = "btnGeraParcela"
        Me.btnGeraParcela.Size = New System.Drawing.Size(75, 23)
        Me.btnGeraParcela.TabIndex = 5
        Me.btnGeraParcela.Text = "Gerar"
        Me.btnGeraParcela.UseVisualStyleBackColor = True
        '
        'ckbMesmoDia
        '
        Me.ckbMesmoDia.AutoSize = True
        Me.ckbMesmoDia.Enabled = False
        Me.ckbMesmoDia.Location = New System.Drawing.Point(6, 71)
        Me.ckbMesmoDia.Name = "ckbMesmoDia"
        Me.ckbMesmoDia.Size = New System.Drawing.Size(148, 17)
        Me.ckbMesmoDia.TabIndex = 4
        Me.ckbMesmoDia.Text = "Usar Mesmo dia de Venc."
        Me.ckbMesmoDia.UseVisualStyleBackColor = True
        '
        'txtIntervalo
        '
        Me.txtIntervalo.Enabled = False
        Me.txtIntervalo.EnviaTab = True
        Me.txtIntervalo.Location = New System.Drawing.Point(62, 45)
        Me.txtIntervalo.Name = "txtIntervalo"
        Me.txtIntervalo.Size = New System.Drawing.Size(40, 20)
        Me.txtIntervalo.SomenteNumero = True
        Me.txtIntervalo.TabIndex = 3
        Me.txtIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Intervalo:"
        '
        'txtQtdParcelas
        '
        Me.txtQtdParcelas.Enabled = False
        Me.txtQtdParcelas.EnviaTab = True
        Me.txtQtdParcelas.Location = New System.Drawing.Point(62, 19)
        Me.txtQtdParcelas.Name = "txtQtdParcelas"
        Me.txtQtdParcelas.Size = New System.Drawing.Size(40, 20)
        Me.txtQtdParcelas.SomenteNumero = True
        Me.txtQtdParcelas.TabIndex = 1
        Me.txtQtdParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Qtd.:"
        '
        'dtpInclusao
        '
        Me.dtpInclusao.Enabled = False
        Me.dtpInclusao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInclusao.Location = New System.Drawing.Point(467, 22)
        Me.dtpInclusao.Name = "dtpInclusao"
        Me.dtpInclusao.Size = New System.Drawing.Size(100, 20)
        Me.dtpInclusao.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(411, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Inclusão:"
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Location = New System.Drawing.Point(366, 163)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(36, 13)
        Me.lblObs.TabIndex = 17
        Me.lblObs.Text = "0/400"
        '
        'txtObs
        '
        Me.txtObs.Enabled = False
        Me.txtObs.EnviaTab = True
        Me.txtObs.Location = New System.Drawing.Point(82, 123)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(278, 88)
        Me.txtObs.SomenteNumero = False
        Me.txtObs.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Obs:"
        '
        'txtValor
        '
        Me.txtValor.Enabled = False
        Me.txtValor.EnviaTab = True
        Me.txtValor.Location = New System.Drawing.Point(260, 97)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 14
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(220, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Valor:"
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.EnviaTab = True
        Me.txtNumero.Location = New System.Drawing.Point(82, 97)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.SomenteNumero = False
        Me.txtNumero.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Número:"
        '
        'dtpVencimento
        '
        Me.dtpVencimento.Enabled = False
        Me.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimento.Location = New System.Drawing.Point(260, 71)
        Me.dtpVencimento.Name = "dtpVencimento"
        Me.dtpVencimento.Size = New System.Drawing.Size(100, 20)
        Me.dtpVencimento.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(188, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Vencimento:"
        '
        'dtpEmissao
        '
        Me.dtpEmissao.Enabled = False
        Me.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEmissao.Location = New System.Drawing.Point(82, 71)
        Me.dtpEmissao.Name = "dtpEmissao"
        Me.dtpEmissao.Size = New System.Drawing.Size(100, 20)
        Me.dtpEmissao.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Emissão:"
        '
        'lblCliente
        '
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(185, 44)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(223, 18)
        Me.lblCliente.TabIndex = 6
        Me.lblCliente.Text = "- "
        '
        'btnPesqCliente
        '
        Me.btnPesqCliente.Enabled = False
        Me.btnPesqCliente.Image = Global.Financeiro.My.Resources.Resources.icone_procurar
        Me.btnPesqCliente.Location = New System.Drawing.Point(152, 43)
        Me.btnPesqCliente.Name = "btnPesqCliente"
        Me.btnPesqCliente.Size = New System.Drawing.Size(27, 23)
        Me.btnPesqCliente.TabIndex = 5
        Me.btnPesqCliente.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.EnviaTab = True
        Me.txtCliente.Location = New System.Drawing.Point(82, 45)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(64, 20)
        Me.txtCliente.SomenteNumero = True
        Me.txtCliente.TabIndex = 4
        Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cliente:"
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Enabled = False
        Me.btnPesquisa.Image = Global.Financeiro.My.Resources.Resources.icone_procurar
        Me.btnPesquisa.Location = New System.Drawing.Point(152, 17)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(27, 23)
        Me.btnPesquisa.TabIndex = 2
        Me.btnPesquisa.UseVisualStyleBackColor = True
        '
        'txtDocumento
        '
        Me.txtDocumento.Enabled = False
        Me.txtDocumento.EnviaTab = True
        Me.txtDocumento.Location = New System.Drawing.Point(82, 19)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(64, 20)
        Me.txtDocumento.SomenteNumero = True
        Me.txtDocumento.TabIndex = 1
        Me.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Documento:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEstornar)
        Me.GroupBox2.Controls.Add(Me.btnRemover)
        Me.GroupBox2.Controls.Add(Me.btnBaixar)
        Me.GroupBox2.Controls.Add(Me.dgvParcelas)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(581, 174)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parcelas"
        '
        'btnEstornar
        '
        Me.btnEstornar.Enabled = False
        Me.btnEstornar.Image = Global.Financeiro.My.Resources.Resources.icone_estornar_parcela
        Me.btnEstornar.Location = New System.Drawing.Point(218, 19)
        Me.btnEstornar.Name = "btnEstornar"
        Me.btnEstornar.Size = New System.Drawing.Size(115, 23)
        Me.btnEstornar.TabIndex = 3
        Me.btnEstornar.Text = "Estornar"
        Me.btnEstornar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEstornar.UseVisualStyleBackColor = True
        '
        'btnRemover
        '
        Me.btnRemover.Enabled = False
        Me.btnRemover.Image = Global.Financeiro.My.Resources.Resources.icone_remover_parcela
        Me.btnRemover.Location = New System.Drawing.Point(460, 19)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(115, 23)
        Me.btnRemover.TabIndex = 2
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'btnBaixar
        '
        Me.btnBaixar.Enabled = False
        Me.btnBaixar.Image = Global.Financeiro.My.Resources.Resources.icone_baixar_parcela
        Me.btnBaixar.Location = New System.Drawing.Point(339, 19)
        Me.btnBaixar.Name = "btnBaixar"
        Me.btnBaixar.Size = New System.Drawing.Size(115, 23)
        Me.btnBaixar.TabIndex = 1
        Me.btnBaixar.Text = "Baixar"
        Me.btnBaixar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBaixar.UseVisualStyleBackColor = True
        '
        'dgvParcelas
        '
        Me.dgvParcelas.AllowUserToAddRows = False
        Me.dgvParcelas.AllowUserToDeleteRows = False
        Me.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParcelas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdMovItem, Me.colCodigoContaReceber, Me.colNumero, Me.colValor, Me.colVencimento, Me.colCodigoContaBanco, Me.colPagamento})
        Me.dgvParcelas.Enabled = False
        Me.dgvParcelas.Location = New System.Drawing.Point(6, 48)
        Me.dgvParcelas.Name = "dgvParcelas"
        Me.dgvParcelas.ReadOnly = True
        Me.dgvParcelas.Size = New System.Drawing.Size(569, 120)
        Me.dgvParcelas.TabIndex = 0
        '
        'ssPrincipal
        '
        Me.ssPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslAtalho})
        Me.ssPrincipal.Location = New System.Drawing.Point(0, 465)
        Me.ssPrincipal.Name = "ssPrincipal"
        Me.ssPrincipal.Size = New System.Drawing.Size(603, 22)
        Me.ssPrincipal.TabIndex = 4
        Me.ssPrincipal.Text = "StatusStrip1"
        '
        'tsslAtalho
        '
        Me.tsslAtalho.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslAtalho.Name = "tsslAtalho"
        Me.tsslAtalho.Size = New System.Drawing.Size(375, 17)
        Me.tsslAtalho.Text = "Incluir - F2 | Editar - F3 | Consultar - F4 | Gravar - F5 | Cancelar - Esc"
        '
        'colIdMovItem
        '
        Me.colIdMovItem.DataPropertyName = "ID_MOV_CONTA_ITEM"
        Me.colIdMovItem.HeaderText = "IdMovContaItem"
        Me.colIdMovItem.Name = "colIdMovItem"
        Me.colIdMovItem.ReadOnly = True
        Me.colIdMovItem.Visible = False
        '
        'colCodigoContaReceber
        '
        Me.colCodigoContaReceber.DataPropertyName = "CODIGO_CONTA_RECEBER"
        Me.colCodigoContaReceber.HeaderText = "CodigoReceber"
        Me.colCodigoContaReceber.Name = "colCodigoContaReceber"
        Me.colCodigoContaReceber.ReadOnly = True
        Me.colCodigoContaReceber.Visible = False
        '
        'colNumero
        '
        Me.colNumero.DataPropertyName = "NUMERO_PARCELA_RECEBER"
        Me.colNumero.HeaderText = "Parcela"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.ReadOnly = True
        '
        'colValor
        '
        Me.colValor.DataPropertyName = "VALOR_PARCELA_RECEBER"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colValor.DefaultCellStyle = DataGridViewCellStyle1
        Me.colValor.HeaderText = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.ReadOnly = True
        '
        'colVencimento
        '
        Me.colVencimento.DataPropertyName = "DATA_VENCIMENTO_RECEBER"
        Me.colVencimento.HeaderText = "Vencimento"
        Me.colVencimento.Name = "colVencimento"
        Me.colVencimento.ReadOnly = True
        '
        'colCodigoContaBanco
        '
        Me.colCodigoContaBanco.DataPropertyName = "CODIGO_CONTA_BANCO"
        Me.colCodigoContaBanco.HeaderText = "Banco"
        Me.colCodigoContaBanco.Name = "colCodigoContaBanco"
        Me.colCodigoContaBanco.ReadOnly = True
        '
        'colPagamento
        '
        Me.colPagamento.DataPropertyName = "DATA_PAGAMENTO_RECEBER"
        Me.colPagamento.HeaderText = "Pagamento"
        Me.colPagamento.Name = "colPagamento"
        Me.colPagamento.ReadOnly = True
        '
        'frmContaReceber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 487)
        Me.Controls.Add(Me.ssPrincipal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tsPrincipal)
        Me.Name = "frmContaReceber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conta Receber"
        Me.tsPrincipal.ResumeLayout(False)
        Me.tsPrincipal.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ssPrincipal.ResumeLayout(False)
        Me.ssPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsPrincipal As Windows.Forms.ToolStrip
    Friend WithEvents tsbIncluir As Windows.Forms.ToolStripButton
    Friend WithEvents tsbEditar As Windows.Forms.ToolStripButton
    Friend WithEvents tsbConsultar As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbCancelar As Windows.Forms.ToolStripButton
    Friend WithEvents tsbGravar As Windows.Forms.ToolStripButton
    Friend WithEvents tsbDeletar As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbFechar As Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents btnPesquisa As Windows.Forms.Button
    Friend WithEvents txtDocumento As Controls.CursoTextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents dtpInclusao As Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents lblObs As Windows.Forms.Label
    Friend WithEvents txtObs As Controls.CursoTextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents txtValor As Controls.CursoTextBoxMonetario
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents txtNumero As Controls.CursoTextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents dtpVencimento As Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents dtpEmissao As Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents lblCliente As Windows.Forms.Label
    Friend WithEvents btnPesqCliente As Windows.Forms.Button
    Friend WithEvents txtCliente As Controls.CursoTextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents ckbMesmoDia As Windows.Forms.CheckBox
    Friend WithEvents txtIntervalo As Controls.CursoTextBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents txtQtdParcelas As Controls.CursoTextBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
    Friend WithEvents rbInativo As Windows.Forms.RadioButton
    Friend WithEvents rbAtivo As Windows.Forms.RadioButton
    Friend WithEvents dgvParcelas As Windows.Forms.DataGridView
    Friend WithEvents btnEstornar As Windows.Forms.Button
    Friend WithEvents btnRemover As Windows.Forms.Button
    Friend WithEvents btnBaixar As Windows.Forms.Button
    Friend WithEvents ssPrincipal As Windows.Forms.StatusStrip
    Friend WithEvents tsslAtalho As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnGeraParcela As Windows.Forms.Button
    Friend WithEvents colIdMovItem As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCodigoContaReceber As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNumero As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colValor As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVencimento As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCodigoContaBanco As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPagamento As Windows.Forms.DataGridViewTextBoxColumn
End Class
