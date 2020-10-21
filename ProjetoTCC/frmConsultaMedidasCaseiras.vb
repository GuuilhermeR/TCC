Public Class frmConsultaMedidasCaseiras

    Private Sub frmConsultaMedidasCaseiras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtAlimento.Conexao = conexaoPadrao
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        btnConsultar.ShowWait(True)

        Dim strSQL As String = $"SELECT A.Alimento AS Alimento,
                                IAN.gramas AS Gramas, 
                                IAN.qtde AS Quantidade, 
                                IAN.kcal AS KCal, 
                                IAN.proteina AS Proteína, 
                                IAN.carboidrato AS Carboidrato, 
                                IAN.lipidio AS Lipídio, 
                                IAN.calcio AS Cálcio, 
                                IAN.ferro AS Ferro, 
                                IAN.vitC AS VitaminaC
                                FROM InfosAlimentosNutricionais IAN 
                                LEFT JOIN Alimento A 
                                ON A.codAlimento = IAN.codAlimento"

        conexaoPadrao.FillDataGridView(strSQL, dtgMedidasCaseiras, "", "N2", "N1", True, True, False, True)

        btnConsultar.HideWait(True)

    End Sub

End Class