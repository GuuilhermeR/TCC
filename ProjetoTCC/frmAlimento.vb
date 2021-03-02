Imports System.Data.OleDb
Imports System.Data.SQLite
Imports System.Security

Public Class frmAlimento
    Public objBanco As New DBAcesso
    Public objConexao As New SQLiteConnection((objBanco.Conexao).ToString)
    Public alimento As New AlimentoDAO
    Public importarPlanilha As New importPlanilhaExcel

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
        If Me.txtCodAlimento.Text <> Nothing Then
            alimento.Deletar(Me.txtCodAlimento.Text)
        Else
            MsgBox("Não é possível excluir sem antes informar o código.")
        End If
    End Sub

    Private Sub txtAlimentoFiltro_Leave(sender As Object, e As EventArgs) Handles txtAlimentoFiltro.Leave
        'ao sair consultar alimento

    End Sub

    Private Sub tbConsulta_Click(sender As Object, e As EventArgs) Handles tbConsulta.Click
        alimento.Buscar(dtgConAlimento)
    End Sub

    Private Sub btnBuscarPlanilha_Click(sender As Object, e As EventArgs) Handles btnBuscarPlanilha.Click
        Me.ofd1.Multiselect = False
        Me.ofd1.Title = "Selecionar Arquivos"
        ofd1.InitialDirectory = "C:\dados"
        ofd1.Filter = "Excel (*.xls;*.xlsx)|*.xls;*.xlsx|" & "All files (*.*)|*.*"
        ofd1.CheckFileExists = True
        ofd1.CheckPathExists = True
        ofd1.FilterIndex = 2
        ofd1.RestoreDirectory = True
        ofd1.ReadOnlyChecked = True
        ofd1.ShowReadOnly = True
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        If dr = System.Windows.Forms.DialogResult.OK Then
            ' Le os arquivos selecionados
            For Each arquivo As String In ofd1.FileNames
                txtCaminhoArquivoExcel.Text += arquivo & vbNewLine
                Try
                    ' Aqui fica o que deve ser executado com os arquivos selecionados.
                Catch ex As SecurityException
                    MessageBox.Show((("Erro de segurança." & vbLf & vbLf & "Mensagem : ") + ex.Message & vbLf & vbLf & "Detalhes:" & vbLf & vbLf) + ex.StackTrace)
                Catch ex As Exception
                    ' Não pode carregar o arquivo (problemas de permissão)
                    MessageBox.Show(("Não é possível exibir o arquivo : " & arquivo.Substring(arquivo.LastIndexOf("\"c))))
                End Try
            Next
        End If
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        If String.IsNullOrWhiteSpace(txtCaminhoArquivoExcel.Text) Then
            MessageBox.Show("Infome o caminho da planilha.", "Caminho da Planilha", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(Me.cbxNomePlanilha.Text) Then
            MessageBox.Show("Selecione o nome da planilha.", "Nome da Planilha", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim caminhoArquivoExcel As String = txtCaminhoArquivoExcel.Text
        Dim nomePlanilhaExcel As String = cbxNomePlanilha.Text & "$"
        Dim conexaoOleDb As OleDbConnection = Nothing
        Dim ds As DataSet
        Dim cmd As OleDbDataAdapter

        Try
            conexaoOleDb = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & caminhoArquivoExcel & ";Extended Properties=Excel 8.0;")
            cmd = New OleDbDataAdapter("Select * from [" & nomePlanilhaExcel & "]", conexaoOleDb)
            cmd.TableMappings.Add("Table", "tabelaExcel")
            ds = New DataSet
            cmd.Fill(ds)
            dtgDados.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao importar a planilha.", Chr(10) & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            objConexao.Close()
        End Try

    End Sub

    Private Sub txtCaminhoArquivoExcel_Leave(sender As Object, e As EventArgs) Handles txtCaminhoArquivoExcel.Leave
        If Me.txtCaminhoArquivoExcel.Text <> "" Then
            importarPlanilha.BuscarPlanilha(Me.txtCaminhoArquivoExcel.Text, Me.cbxNomePlanilha.Text)
        End If
    End Sub
End Class