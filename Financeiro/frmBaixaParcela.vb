Imports DataBase
Imports DataBase.Utils
Imports System.Windows.Forms

Public Class frmBaixaParcela
#Region "Propriedades"
    Public Property ValorParcela As Double
    Public Property ValorBaixa As Double
    Public Property ValorJuros As Double
    Public Property ValorDesconto As Double
    Public Property DataBaixa As Date
    Public Property CodigoBanco As Integer
    Private blnCancelado As Boolean = True
    Public ReadOnly Property Cancelado As Boolean
        Get
            Return blnCancelado
        End Get
    End Property
#End Region
#Region "Métodos"
    Private Sub LoadBanco()
        Dim objBanco As New CAD_CONTA_BANCO
        Dim dt As DataTable

        Try
            dt = objBanco.BuscaBancos
            '
            'ADICIONAR UMA NOVA LINHA NO DATATABLE
            Dim novo = dt.NewRow
            novo.Item("DESCRICAO_CONTA_BANCO") = "-----Selecione-----"
            novo.Item("ID_CONTA_BANCO") = 0
            dt.Rows.InsertAt(novo, 0)
            '
            cboBanco.DataSource = dt
            cboBanco.DisplayMember = "DESCRICAO_CONTA_BANCO"
            cboBanco.ValueMember = "ID_CONTA_BANCO"

        Catch ex As Exception
            TrataErro("Problema ao tentar carregar bancos.", ex)
        End Try
    End Sub
#End Region

    Private Sub frmBaixaParcela_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadBanco()
        ValorBaixa = ValorParcela
        lblValorParcela.Text = String.Format("Valor parcela: {0}", FormatNumber(ValorParcela, 2))
        lblValorBaixa.Text = String.Format("Valor baixa: {0}", FormatNumber(ValorParcela, 2))
    End Sub

    Private Sub btnPerDesconto_Click(sender As Object, e As EventArgs) Handles btnPerDesconto.Click
        Dim desc As Double
        Dim per As Double
        Dim strPer As String = InputBox("Informe um percentual.", "Percentual", "2")
        If IsNumeric(strPer) Then
            per = Convert.ToDouble(strPer)
            desc = Math.Round(((per / 100) * ValorParcela), 2)
            txtDesconto.Text = FormatNumber(desc, 2)
            ValorBaixa = ValorParcela - desc
            lblValorBaixa.Text = String.Format("Valor Baixa: {0}", FormatNumber(ValorBaixa, 2))
        Else
            MessageBox.Show("Formato valor inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPerJuros_Click(sender As Object, e As EventArgs) Handles btnPerJuros.Click
        Dim juros As Double
        Dim per As Double
        Dim strPer As String = InputBox("Informe um percentual.", "Percentual", "2")
        If IsNumeric(strPer) Then
            per = Convert.ToDouble(strPer)
            juros = Math.Round(((per / 100) * ValorParcela), 2)
            txtJuros.Text = FormatNumber(juros, 2)
            ValorBaixa = ValorParcela + juros

            lblValorBaixa.Text = String.Format("Valor Baixa: {0}", FormatNumber(ValorBaixa, 2))
        Else
            MessageBox.Show("Formato valor inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtJuros_TextChanged(sender As Object, e As EventArgs) Handles txtJuros.TextChanged
        If txtJuros.TextLength = 0 Then
            ValorBaixa = ValorParcela
        Else
            If IsNumeric(txtJuros.Text) = True Then
                ValorBaixa = ValorParcela + Convert.ToDouble(txtJuros.Text)
                epValida.SetError(btnPerJuros, "")
            Else
                epValida.SetError(btnPerJuros, "Formato incorreto de valor.")
            End If
        End If
        lblValorBaixa.Text = String.Format("Valor Baixa: {0}", FormatNumber(ValorBaixa, 2))
    End Sub

    Private Sub txtDesconto_TextChanged(sender As Object, e As EventArgs) Handles txtDesconto.TextChanged
        If txtDesconto.TextLength = 0 Then
            ValorBaixa = ValorParcela
        Else
            If IsNumeric(txtDesconto.Text) = True Then
                ValorBaixa = ValorParcela - Convert.ToDouble(txtDesconto.Text)
                epValida.SetError(btnPerDesconto, "")
            Else
                epValida.SetError(btnPerDesconto, "Formato incorreto de valor.")
            End If
        End If
        lblValorBaixa.Text = String.Format("Valor Baixa: {0}", FormatNumber(ValorBaixa, 2))
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If IsDate(dtpBaixa.Value) Then
            If dtpBaixa.Value > Now.Date Then
                MessageBox.Show("Favor selecionar data menor ou igual a data atual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If txtDesconto.TextLength > 0 Then
                    If IsNumeric(txtDesconto.Text) Then
                        ValorDesconto = Convert.ToDouble(txtDesconto.Text)
                    Else
                        MessageBox.Show("Valor de desconto incorreto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtDesconto.Focus()
                        txtDesconto.SelectAll()
                        Exit Sub
                    End If
                End If
                If txtJuros.TextLength > 0 Then
                    If IsNumeric(txtJuros.Text) Then
                        ValorJuros = Convert.ToDouble(txtJuros.Text)
                    Else
                        MessageBox.Show("Valor de juros incorreto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtJuros.Focus()
                        txtJuros.SelectAll()
                        Exit Sub
                    End If
                End If
                If cboBanco.SelectedIndex = 0 Then
                    MessageBox.Show("Favor selecionar um banco para a baixa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                CodigoBanco = cboBanco.SelectedValue
                DataBaixa = dtpBaixa.Value
                blnCancelado = False
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class