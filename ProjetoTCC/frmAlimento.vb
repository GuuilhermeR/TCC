Imports System.Data.OleDb
Imports System.Data.SQLite
Imports System.IO
Imports System.Security
Imports ExcelDataReader

Public Class frmAlimento
    Public objBanco As New DBAcesso
    Public objConexao As New SQLiteConnection((objBanco.Conexao).ToString)
    Public alimento As New AlimentoDAO
    Dim tables As DataTableCollection


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

            Dim cmd As New Data.SQLite.SQLiteCommand(strSQL, objConexao)

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
        If Me.txtCodAlimento.Text <> Nothing Then
            alimento.Deletar(Me.txtCodAlimento.Text)
        Else
            MsgBox("Não é possível excluir sem antes informar o código.")
        End If
    End Sub

    Private Sub txtAlimentoFiltro_Leave(sender As Object, e As EventArgs) Handles txtAlimentoFiltro.Leave
        alimento.Buscar(dtgConAlimento, Me.txtAlimento.Text)
    End Sub

    Private Sub tbConsulta_Click(sender As Object, e As EventArgs) Handles tbConsulta.Click
        alimento.Buscar(Me.dtgConAlimento, Nothing)
    End Sub

    Private Sub btnBuscarPlanilha_Click(sender As Object, e As EventArgs) Handles btnBuscarPlanilha.Click
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls"}
            If ofd.ShowDialog() = DialogResult.OK Then
                Me.txtCaminhoArquivoExcel.Text = ofd.FileName
                Using stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
                    Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                        Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                                                                 .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                                                                 .UseHeaderRow = True}})
                        tables = result.Tables
                        cbxNomePlanilha.Items.Clear()
                        For Each table As DataTable In tables
                            cbxNomePlanilha.Items.Add(table.TableName)
                        Next
                    End Using
                End Using
            End If
        End Using
    End Sub

    Private Sub cbxNomePlanilha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxNomePlanilha.SelectedIndexChanged
        Dim dt As DataTable = tables(cbxNomePlanilha.SelectedItem.ToString())
        dtgDados.DataSource = dt
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

    End Sub
End Class