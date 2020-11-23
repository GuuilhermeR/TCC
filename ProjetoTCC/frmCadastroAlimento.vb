Imports System.Data.SQLite

Public Class frmCadastroAlimento
    Public objBanco As New DBAcesso
    Public objConexao As New SQLiteConnection((objBanco.Conexao).ToString)

    Private Sub frmCadastroAlimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnProcurarAlimento_Click(sender As Object, e As EventArgs) Handles btnProcurarAlimento.Click

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        objConexao.Open()

        Dim strSQL As String = String.Empty

        Try

            If Me.txtCodAlimento.Text <> "" Then
                strSQL = $"UPDATE InfosAlimentosNutricionais SET Alimento= @Alimento, qtde = @qtde, kcal = @kcal, proteina = @proteina, carboidrato = @carboidrato, lipidio = @lipidio, calcio = @calcio, ferro = @ferro, vitC = @vitC WHERE codAlimento = {Me.txtCodAlimento.Text}"
            Else
                strSQL = "INSERT INTO InfosAlimentosNutricionais (Alimento, qtde, kcal, proteina, carboidrato, lipidio, calcio, ferro, vitC, medidaCaseira) values (@Alimento, @qtde, @kcal, @proteina, @Carboidrato, @lipidio, @calcio, @ferro, @vitC, @medidaCaseira)"
            End If

            Dim cmd As New SQLiteCommand(strSQL, objConexao)

            cmd.Parameters.Add(New SQLiteParameter("@Alimento", Me.txtAlimento.Text))
            cmd.Parameters.Add(New SQLiteParameter("@qtde", Me.txtQtde.Text))
            cmd.Parameters.Add(New SQLiteParameter("@kcal", Me.txtKCal.Text))
            cmd.Parameters.Add(New SQLiteParameter("@proteina", Me.txtProteina.Text))
            cmd.Parameters.Add(New SQLiteParameter("@carboidrato", Me.txtCarboidrato.Text))
            cmd.Parameters.Add(New SQLiteParameter("@lipidio", Me.txtLipidio.Text))
            cmd.Parameters.Add(New SQLiteParameter("@calcio", Me.txtCalcio.Text))
            cmd.Parameters.Add(New SQLiteParameter("@ferro", Me.txtFerro.Text))
            cmd.Parameters.Add(New SQLiteParameter("@vitC", Me.txtVitC.Text))
            cmd.Parameters.Add(New SQLiteParameter("@medidaCaseira", Me.txtMedidaCaseira.Text))

            cmd.ExecuteNonQuery()
            MsgBox("Seus dados foram salvos", vbInformation, "Atenção!")
            limparCampos()
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao salvar o Alimento.", vbYes, "Alerta")

        End Try

        objConexao.Close()

    End Sub

    Private Sub limparCampos()
        Me.txtAlimento.Clear()
        Me.txtCalcio.Clear()
        Me.txtCarboidrato.Clear()
        Me.txtCodAlimento.Clear()
        Me.txtFerro.Clear()
        Me.txtKCal.Clear()
        Me.txtLipidio.Clear()
        Me.txtMedidaCaseira.Clear()
        Me.txtProteina.Clear()
        Me.txtQtde.Clear()
        Me.txtVitC.Clear()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        objConexao.Open()

        Dim strSQL As String = String.Empty

        Try

            strSQL = $"DELETE FROM InfosAlimentosNutricionais WHERE codAlimento = {Me.txtCodAlimento.Text}"

            Dim cmd As New SQLiteCommand(strSQL, objConexao)

            cmd.Parameters.Add(New SQLiteParameter("@Alimento", Me.txtAlimento.Text))
            cmd.Parameters.Add(New SQLiteParameter("@qtde", Me.txtQtde.Text))
            cmd.Parameters.Add(New SQLiteParameter("@kcal", Me.txtKCal.Text))
            cmd.Parameters.Add(New SQLiteParameter("@proteina", Me.txtProteina.Text))
            cmd.Parameters.Add(New SQLiteParameter("@carboidrato", Me.txtCarboidrato.Text))
            cmd.Parameters.Add(New SQLiteParameter("@lipidio", Me.txtLipidio.Text))
            cmd.Parameters.Add(New SQLiteParameter("@calcio", Me.txtCalcio.Text))
            cmd.Parameters.Add(New SQLiteParameter("@ferro", Me.txtFerro.Text))
            cmd.Parameters.Add(New SQLiteParameter("@vitC", Me.txtVitC.Text))
            cmd.Parameters.Add(New SQLiteParameter("@medidaCaseira", Me.txtMedidaCaseira.Text))

            cmd.ExecuteNonQuery()
            MsgBox("Alimento excluído", vbInformation, "Atenção!")
            limparCampos()
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao excluir o Alimento.", vbYes, "Alerta")
        End Try

        objConexao.Close()
    End Sub
End Class