Public Class PARCELA_CONTA_RECEBER
    'PROPRIEDADES DA TABELA MOV_CONTA_RECEBER_ITEM
    Public Property ID_MOV_CONTA_ITEM As Integer
    Public Property CODIGO_CONTA_RECEBER As Integer
    Public Property CODIGO_CONTA_BANCO As Integer
    Public Property NOME_BANCO As String
    Public Property VALOR_PARCELA_RECEBER As Double
    Public Property DATA_PAGAMENTO_RECEBER As Object = Nothing
    Public Property DATA_VENCIMENTO_RECEBER As Object = Nothing
    Public Property NUMERO_PARCELA_RECEBER As Integer
End Class
