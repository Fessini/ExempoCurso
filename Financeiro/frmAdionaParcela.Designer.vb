<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdionaParcela
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
        Me.gbParcela = New System.Windows.Forms.GroupBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.dtpVencimento = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGeraParcela = New System.Windows.Forms.Button()
        Me.txtQtdParcelas = New Controls.CursoTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIntervalo = New Controls.CursoTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ckbMesmoDia = New System.Windows.Forms.CheckBox()
        Me.gbParcela.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbParcela
        '
        Me.gbParcela.Controls.Add(Me.ckbMesmoDia)
        Me.gbParcela.Controls.Add(Me.txtIntervalo)
        Me.gbParcela.Controls.Add(Me.Label10)
        Me.gbParcela.Controls.Add(Me.lblValor)
        Me.gbParcela.Controls.Add(Me.dtpVencimento)
        Me.gbParcela.Controls.Add(Me.Label1)
        Me.gbParcela.Controls.Add(Me.btnGeraParcela)
        Me.gbParcela.Controls.Add(Me.txtQtdParcelas)
        Me.gbParcela.Controls.Add(Me.Label9)
        Me.gbParcela.Location = New System.Drawing.Point(12, 12)
        Me.gbParcela.Name = "gbParcela"
        Me.gbParcela.Size = New System.Drawing.Size(161, 177)
        Me.gbParcela.TabIndex = 0
        Me.gbParcela.TabStop = False
        Me.gbParcela.Text = "Parcelar"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(19, 26)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(34, 13)
        Me.lblValor.TabIndex = 0
        Me.lblValor.Text = "Valor:"
        '
        'dtpVencimento
        '
        Me.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimento.Location = New System.Drawing.Point(56, 98)
        Me.dtpVencimento.Name = "dtpVencimento"
        Me.dtpVencimento.Size = New System.Drawing.Size(89, 20)
        Me.dtpVencimento.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Venc.:"
        '
        'btnGeraParcela
        '
        Me.btnGeraParcela.Location = New System.Drawing.Point(43, 147)
        Me.btnGeraParcela.Name = "btnGeraParcela"
        Me.btnGeraParcela.Size = New System.Drawing.Size(75, 23)
        Me.btnGeraParcela.TabIndex = 7
        Me.btnGeraParcela.Text = "Gerar"
        Me.btnGeraParcela.UseVisualStyleBackColor = True
        '
        'txtQtdParcelas
        '
        Me.txtQtdParcelas.EnviaTab = True
        Me.txtQtdParcelas.Location = New System.Drawing.Point(56, 72)
        Me.txtQtdParcelas.Name = "txtQtdParcelas"
        Me.txtQtdParcelas.Size = New System.Drawing.Size(40, 20)
        Me.txtQtdParcelas.SomenteNumero = True
        Me.txtQtdParcelas.TabIndex = 4
        Me.txtQtdParcelas.Text = "1"
        Me.txtQtdParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Qtd.:"
        '
        'txtIntervalo
        '
        Me.txtIntervalo.EnviaTab = True
        Me.txtIntervalo.Location = New System.Drawing.Point(56, 46)
        Me.txtIntervalo.Name = "txtIntervalo"
        Me.txtIntervalo.Size = New System.Drawing.Size(40, 20)
        Me.txtIntervalo.SomenteNumero = True
        Me.txtIntervalo.TabIndex = 2
        Me.txtIntervalo.Text = "0"
        Me.txtIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(-1, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Intervalo:"
        '
        'ckbMesmoDia
        '
        Me.ckbMesmoDia.AutoSize = True
        Me.ckbMesmoDia.Location = New System.Drawing.Point(6, 124)
        Me.ckbMesmoDia.Name = "ckbMesmoDia"
        Me.ckbMesmoDia.Size = New System.Drawing.Size(148, 17)
        Me.ckbMesmoDia.TabIndex = 8
        Me.ckbMesmoDia.Text = "Usar Mesmo dia de Venc."
        Me.ckbMesmoDia.UseVisualStyleBackColor = True
        '
        'frmAdionaParcela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(179, 199)
        Me.Controls.Add(Me.gbParcela)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAdionaParcela"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adiciona Parcela"
        Me.gbParcela.ResumeLayout(False)
        Me.gbParcela.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbParcela As Windows.Forms.GroupBox
    Friend WithEvents btnGeraParcela As Windows.Forms.Button
    Friend WithEvents txtQtdParcelas As Controls.CursoTextBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lblValor As Windows.Forms.Label
    Friend WithEvents dtpVencimento As Windows.Forms.DateTimePicker
    Friend WithEvents txtIntervalo As Controls.CursoTextBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents ckbMesmoDia As Windows.Forms.CheckBox
End Class
