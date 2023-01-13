Imports DataBase
Imports System.Windows.Forms

Public Class frmAdionaParcela
    Public Property Valor As Double
    Public Property Parcelas As DataTable
    Public Property NumeroParcela As Integer
    Public Property DataVenc As Date

    Private Sub btnGeraParcela_Click(sender As Object, e As EventArgs) Handles btnGeraParcela.Click
        Dim dtData As Date = dtpVencimento.Value
        Dim dblValorParcela As Double = Math.Round(Valor / Convert.ToInt32(txtQtdParcelas.Text), 2)
        Dim dblTotalParcela, dblDiferenca As Double
        Dim index As Integer = NumeroParcela

        If dtpVencimento.Value = DataVenc.Date Or dtpVencimento.Value < DataVenc.Date Then
            MessageBox.Show("A data de vencimento não pode ser igual e nem menor que o vencimento da última parcela." & vbNewLine & "Vencimento última parcela " & DataVenc.Date,
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        '
        'Gera as parcelas
        For I As Integer = 1 To Convert.ToInt32(txtQtdParcelas.Text)
            index += 1
            Dim novaLinha As DataRow = Parcelas.NewRow
            novaLinha.Item("VALOR_PARCELA_RECEBER") = dblValorParcela
            novaLinha.Item("NUMERO_PARCELA_RECEBER") = index
            novaLinha.Item("DATA_VENCIMENTO_RECEBER") = dtData.Date
            novaLinha.Item("STATUS") = "I"
            If ckbMesmoDia.Checked = False Then
                dtData = dtData.Date.AddDays(Convert.ToInt32(txtIntervalo.Text))
            Else
                dtData = dtData.Date.AddMonths(1)
            End If
            Parcelas.Rows.Add(novaLinha)
            dblTotalParcela += dblValorParcela
        Next
        '
        'VERIFICA O TOTAL DAS PARCELAS
        dblDiferenca = Math.Round(Convert.ToDouble(Valor) - dblTotalParcela, 2)
        If dblDiferenca > 0 Then
            Parcelas.Rows(NumeroParcela + 1).Item("VALOR_PARCELA_RECEBER") = dblValorParcela + Math.Abs(dblDiferenca)
        Else
            Parcelas.Rows(NumeroParcela + 1).Item("VALOR_PARCELA_RECEBER") = dblValorParcela - Math.Abs(dblDiferenca)
        End If
        Parcelas.AcceptChanges()
        Me.Close()
    End Sub

    Private Sub frmAdionaParcela_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblValor.Text = String.Format("Valor: {0}", FormatNumber(Valor, 2))
        dtpVencimento.Value = DataVenc.Date
    End Sub

    Private Sub ckbMesmoDia_CheckedChanged(sender As Object, e As EventArgs) Handles ckbMesmoDia.CheckedChanged
        If ckbMesmoDia.Checked = True Then
            txtIntervalo.Clear()
            txtIntervalo.Enabled = False
        Else
            txtIntervalo.Enabled = True
        End If
    End Sub
End Class