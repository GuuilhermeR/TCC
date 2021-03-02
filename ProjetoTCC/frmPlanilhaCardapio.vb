Imports System.Data.SQLite

Public Class frmPlanilhaCardapio
    Public objBanco As New DBAcesso
    Public objConexao As New SQLiteConnection((objBanco.Conexao).ToString)
    Private Sub btnProcurarPaciente_Click(sender As Object, e As EventArgs) Handles btnProcurarPaciente.Click

        Dim frmBuscaPaciente As New frmBuscarPaciente
        frmBuscarPaciente.Show()

    End Sub

    Private Sub frmPlanilhaCardapio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregarColunas()

    End Sub

    Private Sub CarregarColunas()

        If Me.dtgRefeicoes.ColumnCount <= 0 Then

            Me.dtgRefeicoes.Columns.Add("refeicao", "Refeição") 'Vai buscar a descrição salva na tela PlanilhaCardapio
            Me.dtgRefeicoes.Columns.Add("alimento", "Alimento")
            Me.dtgRefeicoes.Columns.Add("qtde", "Quantidade")
            Me.dtgRefeicoes.Columns.Add("hora", "Horário")

        End If

    End Sub

    Private Sub CalcularTotalizador()

        'Total Kcal -> De proteína, carboidrato e lipídio.
        'Kcal total na refeição -> Soma dos 3 ^
        'Kcal estipulado e índice de adequação
        '% de Prot,carb e lip.

    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Dim frmAddRefeicao As New frmAdicionarRefeição
        frmAddRefeicao.Show()
    End Sub
End Class