Imports System.Data.SQLite
Imports System.IO

Public Class frmConsultaAlimentos

    Public objBanco As New DBAcesso
    Public objConexao As New SQLiteConnection((objBanco.Conexao).ToString)

    Dim quantidadeSalva As Double
    Dim verificarHouveAlteracao As Double

    Private Sub frmConsultaMedidasCaseiras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'teste
    End Sub

    Private Sub btnRecalcular_Click_1(sender As Object, e As EventArgs) Handles btnRecalcular.Click

        For Each row As DataGridViewRow In Me.dtgConsultaAlimentos.Rows

            If row.DefaultCellStyle.ForeColor = Color.Red Then

                Dim ProteinaGramas As Double
                Dim ProteinaKcal As Double

                ProteinaGramas = (row.Cells("qtde").Value * row.Cells("proteina").Value) / (quantidadeSalva)
                ProteinaKcal = ProteinaGramas * 4
                row.Cells("proteina").Value = ProteinaGramas.ToString("N2")

                Dim CarboidratoGramas As Double
                Dim CarboidratoKcal As Double

                CarboidratoGramas = (row.Cells("qtde").Value * row.Cells("carboidrato").Value) / (quantidadeSalva)
                CarboidratoKcal = CarboidratoGramas * 4
                row.Cells("carboidrato").Value = CarboidratoGramas.ToString("N2")

                Dim LipidioGramas As Double
                Dim LipidioKcal As Double

                LipidioGramas = (row.Cells("qtde").Value * row.Cells("lipidio").Value) / (quantidadeSalva)
                LipidioKcal = LipidioGramas * 9
                row.Cells("lipidio").Value = LipidioGramas.ToString("N2")

                Dim somaTotalCaloria As Double
                somaTotalCaloria = ProteinaKcal + CarboidratoKcal + LipidioKcal
                row.Cells("kcal").Value = somaTotalCaloria.ToString("N2")

                Dim calcio As Double
                calcio = (row.Cells("calcio").Value * row.Cells("qtde").Value)
                row.Cells("calcio").Value = calcio.ToString("N2")

                Dim ferro As Double
                ferro = (row.Cells("ferro").Value * row.Cells("qtde").Value)
                row.Cells("ferro").Value = ferro.ToString("N2")

                Dim VitaminaC As Double
                VitaminaC = (row.Cells("vitC").Value * row.Cells("qtde").Value)
                row.Cells("vitC").Value = VitaminaC.ToString("N2")

            End If

        Next
        For Each rows As DataGridViewRow In Me.dtgConsultaAlimentos.Rows

            If rows.DefaultCellStyle.ForeColor = Color.Red Then
                rows.DefaultCellStyle.ForeColor = Color.Green
            End If

        Next

    End Sub

    Private Sub btnConsultar_Click_1(sender As Object, e As EventArgs) Handles btnConsultar.Click

        If objConexao.State = ConnectionState.Closed Then
            objConexao.Open()
        End If

        Dim strSQL As String = $"SELECT Alimento AS Alimento,
                                qtde AS Quantidade, 
                                kcal AS KCal, 
                                proteina AS Proteína, 
                                carboidrato AS Carboidrato, 
                                lipidio AS Lipídio, 
                                calcio AS Cálcio, 
                                ferro AS Ferro, 
                                vitC AS VitaminaC
                                FROM InfosAlimentosNutricionais" & Chr(13) & Chr(10)

        If (Me.txtAlimento.Text) <> "" Then
            strSQL &= $"WHERE codAlimento LIKE '%{Me.txtAlimento.Text}%'"
        End If

        Using cmd As New SQLiteCommand(strSQL, objConexao)
            Using dr As SQLiteDataReader = cmd.ExecuteReader
                criarColunasGrid()
                While dr.Read

                    Me.dtgConsultaAlimentos.Rows.Add(dr.Item("Alimento"), dr.Item("Quantidade"), dr.Item("KCal"),
                                                     dr.Item("Proteína"), dr.Item("Carboidrato"), dr.Item("Lipídio"),
                                                     dr.Item("Cálcio"), dr.Item("Ferro"), dr.Item("VitaminaC"))

                End While

            End Using
        End Using

        objConexao.Close()

    End Sub

    Private Sub criarColunasGrid()

        If Me.dtgConsultaAlimentos.Rows.Count = 0 Then

            Me.dtgConsultaAlimentos.Columns.Add("alimento", "Alimento")
            Me.dtgConsultaAlimentos.Columns.Add("qtde", "Quantidade")
            Me.dtgConsultaAlimentos.Columns.Add("kcal", "KCal")
            Me.dtgConsultaAlimentos.Columns.Add("proteina", "Proteína")
            Me.dtgConsultaAlimentos.Columns.Add("carboidrato", "Carboidrato")
            Me.dtgConsultaAlimentos.Columns.Add("lipidio", "Lipídio")
            Me.dtgConsultaAlimentos.Columns.Add("calcio", "Cálcio")
            Me.dtgConsultaAlimentos.Columns.Add("ferro", "Ferro")
            Me.dtgConsultaAlimentos.Columns.Add("vitC", "Vitamina C")

        End If

    End Sub

    Private Sub dtgConsultaAlimentos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtgConsultaAlimentos.CellEndEdit
        If Not verificarHouveAlteracao = Me.dtgConsultaAlimentos.CurrentCell.Value Then
            Me.dtgConsultaAlimentos.CurrentRow.DefaultCellStyle.ForeColor = Color.Red
        End If
    End Sub

    Private Sub dtgConsultaAlimentos_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dtgConsultaAlimentos.CellBeginEdit
        If e.ColumnIndex > 0 Then
            quantidadeSalva = Me.dtgConsultaAlimentos.CurrentRow.Cells("qtde").Value
            verificarHouveAlteracao = Me.dtgConsultaAlimentos.CurrentCell.Value
        End If
    End Sub
End Class