Public Class frmConsultaMedidasCaseiras

    Dim quantidadeSalva As Double
    Dim verificarHouveAlteracao As Double

    Private Sub frmConsultaMedidasCaseiras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtCodAlimento.Conexao = conexaoPadrao
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        btnConsultar.ShowWait(True)

        Dim strSQL As String = $"SELECT Alimento AS Alimento,
                                qtde AS Quantidade, 
                                gramas AS Gramas, 
                                kcal AS KCal, 
                                proteina AS Proteína, 
                                carboidrato AS Carboidrato, 
                                lipidio AS Lipídio, 
                                calcio AS Cálcio, 
                                ferro AS Ferro, 
                                vitC AS VitaminaC
                                FROM InfosAlimentosNutricionais"

        conexaoPadrao.FillDataGridView(strSQL, dtgMedidasCaseiras, "", "N2", "N1", True, True, False, True)
        Me.dtgMedidasCaseiras.Columns("Alimento").ReadOnly = True
        Me.dtgMedidasCaseiras.Columns("kcal").ReadOnly = True
        Me.dtgMedidasCaseiras.Columns("Proteína").ReadOnly = True
        Me.dtgMedidasCaseiras.Columns("Carboidrato").ReadOnly = True
        Me.dtgMedidasCaseiras.Columns("Lipídio").ReadOnly = True
        Me.dtgMedidasCaseiras.Columns("Cálcio").ReadOnly = True
        Me.dtgMedidasCaseiras.Columns("Ferro").ReadOnly = True
        Me.dtgMedidasCaseiras.Columns("VitaminaC").ReadOnly = True
        Me.dtgMedidasCaseiras.Columns("Gramas").ReadOnly = True
        btnConsultar.HideWait(True)

    End Sub

    Private Sub btnRecalcular_Click(sender As Object, e As EventArgs) Handles btnRecalcular.Click

        For Each row As DataGridViewRow In Me.dtgMedidasCaseiras.Rows

            If row.DefaultCellStyle.ForeColor = Color.Red Then

                Dim ProteinaGramas As Double
                Dim ProteinaKcal As Double

                ProteinaGramas = (row.Cells("Quantidade").Value * row.Cells("Proteína").Value) / (quantidadeSalva)
                ProteinaKcal = ProteinaGramas * 4
                row.Cells("Proteína").Value = ProteinaGramas.ToString("N2")

                Dim CarboidratoGramas As Double
                Dim CarboidratoKcal As Double

                CarboidratoGramas = (row.Cells("Quantidade").Value * row.Cells("Carboidrato").Value) / (quantidadeSalva)
                CarboidratoKcal = CarboidratoGramas * 4
                row.Cells("Carboidrato").Value = CarboidratoGramas.ToString("N2")

                Dim LipidioGramas As Double
                Dim LipidioKcal As Double

                LipidioGramas = (row.Cells("Quantidade").Value * row.Cells("Lipídio").Value) / (quantidadeSalva)
                LipidioKcal = LipidioGramas * 9
                row.Cells("Lipídio").Value = LipidioGramas.ToString("N2")

                Dim somaTotalCaloria As Double
                somaTotalCaloria = ProteinaKcal + CarboidratoKcal + LipidioKcal
                row.Cells("KCal").Value = somaTotalCaloria.ToString("N2")

                Dim calcio As Double
                calcio = (row.Cells("Cálcio").Value * row.Cells("Quantidade").Value)
                row.Cells("Cálcio").Value = calcio.ToString("N2")

                Dim ferro As Double
                ferro = (row.Cells("Ferro").Value * row.Cells("Quantidade").Value)
                row.Cells("Cálcio").Value = ferro.ToString("N2")

                Dim VitaminaC As Double
                VitaminaC = (row.Cells("VitaminaC").Value * row.Cells("Quantidade").Value)
                row.Cells("VitaminaC").Value = VitaminaC.ToString("N2")

                Dim gramas As Double
                gramas = (row.Cells("gramas").Value * row.Cells("Quantidade").Value)
                row.Cells("gramas").Value = gramas.ToString("N2")

            End If

        Next

    End Sub

    Private Sub dtgMedidasCaseiras_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtgMedidasCaseiras.CellEndEdit
        If Not verificarHouveAlteracao = Me.dtgMedidasCaseiras.CurrentCell.Value Then
            Me.dtgMedidasCaseiras.CurrentRow.DefaultCellStyle.ForeColor = Color.Red
        End If
    End Sub

    Private Sub dtgMedidasCaseiras_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dtgMedidasCaseiras.CellBeginEdit
        quantidadeSalva = Me.dtgMedidasCaseiras.CurrentRow.Cells("Quantidade").Value
        verificarHouveAlteracao = Me.dtgMedidasCaseiras.CurrentCell.Value
    End Sub
End Class