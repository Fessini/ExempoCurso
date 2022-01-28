<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaixaParcela
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
        Me.lblValorParcela = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPerJuros = New System.Windows.Forms.Button()
        Me.btnPerDesconto = New System.Windows.Forms.Button()
        Me.lblValorBaixa = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpBaixa = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboBanco = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.epValida = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtDesconto = New Controls.CursoTextBoxMonetario()
        Me.txtJuros = New Controls.CursoTextBoxMonetario()
        Me.GroupBox1.SuspendLayout()
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblValorParcela
        '
        Me.lblValorParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorParcela.Location = New System.Drawing.Point(12, 9)
        Me.lblValorParcela.Name = "lblValorParcela"
        Me.lblValorParcela.Size = New System.Drawing.Size(334, 23)
        Me.lblValorParcela.TabIndex = 0
        Me.lblValorParcela.Text = "Valor Parcela: 0,00"
        Me.lblValorParcela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtJuros)
        Me.GroupBox1.Controls.Add(Me.txtDesconto)
        Me.GroupBox1.Controls.Add(Me.btnPerJuros)
        Me.GroupBox1.Controls.Add(Me.btnPerDesconto)
        Me.GroupBox1.Controls.Add(Me.lblValorBaixa)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpBaixa)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboBanco)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 157)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnPerJuros
        '
        Me.btnPerJuros.Location = New System.Drawing.Point(142, 70)
        Me.btnPerJuros.Name = "btnPerJuros"
        Me.btnPerJuros.Size = New System.Drawing.Size(23, 23)
        Me.btnPerJuros.TabIndex = 4
        Me.btnPerJuros.Text = "%"
        Me.btnPerJuros.UseVisualStyleBackColor = True
        '
        'btnPerDesconto
        '
        Me.btnPerDesconto.Location = New System.Drawing.Point(142, 44)
        Me.btnPerDesconto.Name = "btnPerDesconto"
        Me.btnPerDesconto.Size = New System.Drawing.Size(23, 23)
        Me.btnPerDesconto.TabIndex = 2
        Me.btnPerDesconto.Text = "%"
        Me.btnPerDesconto.UseVisualStyleBackColor = True
        '
        'lblValorBaixa
        '
        Me.lblValorBaixa.AutoSize = True
        Me.lblValorBaixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorBaixa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblValorBaixa.Location = New System.Drawing.Point(63, 132)
        Me.lblValorBaixa.Name = "lblValorBaixa"
        Me.lblValorBaixa.Size = New System.Drawing.Size(116, 15)
        Me.lblValorBaixa.TabIndex = 8
        Me.lblValorBaixa.Text = "Valor Baixa: 0,00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Baixa:"
        '
        'dtpBaixa
        '
        Me.dtpBaixa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBaixa.Location = New System.Drawing.Point(66, 98)
        Me.dtpBaixa.Name = "dtpBaixa"
        Me.dtpBaixa.Size = New System.Drawing.Size(98, 20)
        Me.dtpBaixa.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Desconto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Juros:"
        '
        'cboBanco
        '
        Me.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBanco.FormattingEnabled = True
        Me.cboBanco.Location = New System.Drawing.Point(66, 19)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(236, 21)
        Me.cboBanco.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco:"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(271, 198)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(190, 198)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'epValida
        '
        Me.epValida.ContainerControl = Me
        '
        'txtDesconto
        '
        Me.txtDesconto.EnviaTab = True
        Me.txtDesconto.Location = New System.Drawing.Point(66, 46)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(70, 20)
        Me.txtDesconto.TabIndex = 1
        '
        'txtJuros
        '
        Me.txtJuros.EnviaTab = True
        Me.txtJuros.Location = New System.Drawing.Point(66, 72)
        Me.txtJuros.Name = "txtJuros"
        Me.txtJuros.Size = New System.Drawing.Size(70, 20)
        Me.txtJuros.TabIndex = 3
        '
        'frmBaixaParcela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(358, 229)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblValorParcela)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBaixaParcela"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baixar Parcela"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblValorParcela As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents dtpBaixa As Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents cboBanco As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lblValorBaixa As Windows.Forms.Label
    Friend WithEvents btnCancelar As Windows.Forms.Button
    Friend WithEvents btnOk As Windows.Forms.Button
    Friend WithEvents btnPerJuros As Windows.Forms.Button
    Friend WithEvents btnPerDesconto As Windows.Forms.Button
    Friend WithEvents epValida As Windows.Forms.ErrorProvider
    Friend WithEvents txtDesconto As Controls.CursoTextBoxMonetario
    Friend WithEvents txtJuros As Controls.CursoTextBoxMonetario
End Class
