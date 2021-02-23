Imports System.Data.SQLite

Public Class frmAlimento
    Public objBanco As New DBAcesso
    Public objConexao As New SQLiteConnection((objBanco.Conexao).ToString)

    Private Sub frmCadastroAlimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnProcurarAlimento_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs)
        objConexao.Open()

        Dim strSQL As String = String.Empty

        Try

            If Me.txtCodAlimento.Text <> "" Then
                strSQL = $"UPDATE InfosAlimentosNutricionais 
                            SET Alimento= {Me.txtAlimento.Text}, qtde = {Me.txtQtde.Text}, kcal ={Me.txtKCal.Text}, proteina ={Me.txtProteina.Text}, carboidrato = {Me.txtCarboidrato.Text}, 
                            lipidio = {Me.txtLipidio.Text}, calcio = {Me.txtCalcio.Text}, ferro = {Me.txtFerro.Text}, vitC = {Me.txtVitC.Text}
                            WHERE codAlimento = {Me.txtCodAlimento.Text}"
            Else
                strSQL = $"INSERT INTO InfosAlimentosNutricionais (Alimento, qtde, kcal, proteina, carboidrato, lipidio, calcio, ferro, vitC, medidaCaseira) 
                            values ({Me.txtAlimento.Text}, {Me.txtQtde.Text}, {Me.txtKCal.Text}, {Me.txtProteina.Text}, {Me.txtCarboidrato.Text}, {Me.txtLipidio.Text}, {Me.txtCalcio.Text},
                            {Me.txtFerro.Text}, {Me.txtVitC.Text}, {Me.txtMedidaCaseira.Text})"
            End If

            Dim cmd As New SQLiteCommand(strSQL, objConexao)

            cmd.ExecuteNonQuery()
            MsgBox("Seus dados foram salvos", vbInformation, "Atenção!")
            limparCampos()
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao salvar o Alimento.", vbYes, "Alerta")

        End Try

        objConexao.Close()

    End Sub

    Private Sub limparCampos()
        Me.txtAlimento.Text = ""
        Me.txtCalcio.Text = ""
        Me.txtCarboidrato.Text = ""
        Me.txtCodAlimento.Text = ""
        Me.txtFerro.Text = ""
        Me.txtKCal.Text = ""
        Me.txtLipidio.Text = ""
        Me.txtMedidaCaseira.Text = ""
        Me.txtProteina.Text = ""
        Me.txtQtde.Text = ""
        Me.txtVitC.Text = ""
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs)
        objConexao.Open()

        Dim strSQL As String = String.Empty

        Try

            strSQL = $"DELETE FROM InfosAlimentosNutricionais WHERE codAlimento = {Me.txtCodAlimento.Text}"

            Dim cmd As New SQLiteCommand(strSQL, objConexao)

            cmd.ExecuteNonQuery()

            MsgBox("Alimento excluído", vbInformation, "Atenção!")
            limparCampos()
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao excluir o Alimento.", vbYes, "Alerta")
        End Try

        objConexao.Close()
    End Sub
End Class