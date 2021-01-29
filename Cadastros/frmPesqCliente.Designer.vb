<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesqCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPesqCliente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCPFCNPJ = New Controls.CursoTextBoxCPF_CNPJ()
        Me.txtNome = New Controls.CursoTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCPFCNPJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCPFCNPJ)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboTipo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 111)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar por"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CPF/CNPJ:"
        '
        'txtCPFCNPJ
        '
        Me.txtCPFCNPJ.Enabled = False
        Me.txtCPFCNPJ.EnviaTab = True
        Me.txtCPFCNPJ.ExibirMensagem = False
        Me.txtCPFCNPJ.IsValido = False
        Me.txtCPFCNPJ.Location = New System.Drawing.Point(74, 72)
        Me.txtCPFCNPJ.MaxLength = 14
        Me.txtCPFCNPJ.Name = "txtCPFCNPJ"
        Me.txtCPFCNPJ.Size = New System.Drawing.Size(173, 20)
        Me.txtCPFCNPJ.TabIndex = 4
        Me.txtCPFCNPJ.ValidaCNPJ = False
        Me.txtCPFCNPJ.ValidaCPF = True
        '
        'txtNome
        '
        Me.txtNome.EnviaTab = True
        Me.txtNome.Location = New System.Drawing.Point(74, 46)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(364, 20)
        Me.txtNome.SomenteNumero = False
        Me.txtNome.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome:"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"-----Todos-----", "Físico", "Jurídico"})
        Me.cboTipo.Location = New System.Drawing.Point(74, 19)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(121, 21)
        Me.cboTipo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo:"
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colNome, Me.colCPFCNPJ})
        Me.dgvDados.Location = New System.Drawing.Point(12, 129)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(573, 309)
        Me.dgvDados.TabIndex = 8
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Image = Global.Cadastros.My.Resources.Resources.icone_procurar
        Me.btnPesquisar.Location = New System.Drawing.Point(483, 19)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(96, 23)
        Me.btnPesquisar.TabIndex = 6
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = Global.Cadastros.My.Resources.Resources.icone_cancelar_botao
        Me.btnCancelar.Location = New System.Drawing.Point(483, 48)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID_CLIENTE"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Width = 50
        '
        'colNome
        '
        Me.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNome.DataPropertyName = "NOME_CLIENTE"
        Me.colNome.HeaderText = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.ReadOnly = True
        '
        'colCPFCNPJ
        '
        Me.colCPFCNPJ.DataPropertyName = "CPF_CNPJ_CLIENTE"
        Me.colCPFCNPJ.HeaderText = "CPF / CNPJ"
        Me.colCPFCNPJ.Name = "colCPFCNPJ"
        Me.colCPFCNPJ.ReadOnly = True
        Me.colCPFCNPJ.Width = 150
        '
        'frmPesqCliente
        '
        Me.AcceptButton = Me.btnPesquisar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(597, 450)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPesqCliente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisa Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents txtNome As Controls.CursoTextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents cboTipo As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtCPFCNPJ As Controls.CursoTextBoxCPF_CNPJ
    Friend WithEvents btnPesquisar As Windows.Forms.Button
    Friend WithEvents btnCancelar As Windows.Forms.Button
    Friend WithEvents dgvDados As Windows.Forms.DataGridView
    Friend WithEvents colID As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNome As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCPFCNPJ As Windows.Forms.DataGridViewTextBoxColumn
End Class
