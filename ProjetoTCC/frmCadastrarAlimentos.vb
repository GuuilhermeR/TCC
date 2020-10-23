Public Class frmCadastrarAlimentos
    Private Sub btnCadastrarAlimento_Click(sender As Object, e As EventArgs) Handles btnCadastrarAlimento.Click

        btnConsultarAlimento.ShowWait(True)

        Dim transaction As MvtConnection.Helpers.TransactionHelper = MvtConnection.Helpers.TransactionHelper.Create(conexaoPadrao)

        Try

            transaction.BeginTransaction()

            conexaoPadrao.NewTable("Alimento", False)

            conexaoPadrao.InsertField("Alimento", Me.txtAlimento.ValueSQL)

            Dim erro As String = conexaoPadrao.ExecuteInsertUpDate(True)

            transaction.CommitTransaction()

            MsgBox($"O Alimento {Me.txtAlimento.Text} foi salvo.", MsgBoxStyle.Exclamation, "MOV.TECH")

        Catch ex As Exception

            MsgBox("Ocorreu um erro ao salvar." & Chr(10) & ex.Message & "!", MsgBoxStyle.Exclamation, "MOV.TECH")

            transaction.RollbackTransaction()

        End Try

        btnConsultarAlimento.HideWait(True)

    End Sub

    Private Sub frmCadastrarAlimentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.btnConsultarAlimento.ShowWait(True)
        CarregarGridAlimento()
        Me.btnConsultarAlimento.HideWait(True)

    End Sub

    Private Sub CarregarGridAlimento()
        Dim strSQL As String = String.Empty

        strSQL = "SELECT * FROM Alimento"

        conexaoPadrao.FillDataGridView(strSQL, dtgAlimentosCadastrados, "", "", "", True, True, True, True)
    End Sub

End Class