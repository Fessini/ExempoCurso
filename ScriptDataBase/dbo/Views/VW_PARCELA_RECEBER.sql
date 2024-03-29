﻿CREATE VIEW dbo.VW_PARCELA_RECEBER
AS
SELECT        dbo.MOV_CONTA_RECEBER_ITEM.ID_MOV_CONTA_ITEM, dbo.MOV_CONTA_RECEBER_ITEM.CODIGO_CONTA_RECEBER, dbo.MOV_CONTA_RECEBER_ITEM.CODIGO_CONTA_BANCO, 
                         dbo.MOV_CONTA_RECEBER_ITEM.VALOR_PARCELA_RECEBER, dbo.MOV_CONTA_RECEBER_ITEM.DATA_PAGAMENTO_RECEBER, dbo.MOV_CONTA_RECEBER_ITEM.DATA_VENCIMENTO_RECEBER, 
                         dbo.MOV_CONTA_RECEBER_ITEM.NUMERO_PARCELA_RECEBER, dbo.CAD_CONTA_BANCO.DESCRICAO_CONTA_BANCO AS NOME_BANCO, dbo.MOV_CONTA_RECEBER_ITEM.VALOR_RECEBIDO, 
                         dbo.MOV_CONTA_RECEBER_ITEM.VALOR_DESCONTO, dbo.MOV_CONTA_RECEBER_ITEM.VALOR_JUROS
FROM            dbo.MOV_CONTA_RECEBER INNER JOIN
                         dbo.MOV_CONTA_RECEBER_ITEM ON dbo.MOV_CONTA_RECEBER.ID_CONTA_RECEBER = dbo.MOV_CONTA_RECEBER_ITEM.CODIGO_CONTA_RECEBER LEFT OUTER JOIN
                         dbo.CAD_CONTA_BANCO ON dbo.CAD_CONTA_BANCO.ID_CONTA_BANCO = dbo.MOV_CONTA_RECEBER_ITEM.CODIGO_CONTA_RECEBER
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VW_PARCELA_RECEBER';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "MOV_CONTA_RECEBER"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 308
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MOV_CONTA_RECEBER_ITEM"
            Begin Extent = 
               Top = 6
               Left = 346
               Bottom = 245
               Right = 596
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CAD_CONTA_BANCO"
            Begin Extent = 
               Top = 6
               Left = 634
               Bottom = 102
               Right = 877
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VW_PARCELA_RECEBER';



