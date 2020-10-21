Public Class frmCadastroNutricional

    Private Sub frmCalculadoraNutricional_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VerificarAlimentoCadastrado()

        Dim strSQL As String = $" SELECT COUNT(1) as Existe FROM InfosAlimentosNutricionais WHERE "

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        btnConsultar.ShowWait(True)

        Dim transaction As MvtConnection.Helpers.TransactionHelper = MvtConnection.Helpers.TransactionHelper.Create(conexaoPadrao)

        Try

            transaction.BeginTransaction()

            Dim q As MvtConnection.Query.QueryTableBuilder = conexaoPadrao.NewQuery("InfosAlimentosNutricionais", False)

            q.AddKey("codAlimento", Me.txtAlimento.ValueSQL)
            q.AddField("gramas", Me.txtGramas.ValueSQL)
            q.AddField("qtde", Me.txtQtde.ValueSQL)
            q.AddField("kcal", Me.txtKcal.ValueSQL)
            q.AddField("proteina", Me.txtProteina.ValueSQL)
            q.AddField("carboidrato", Me.txtCarboidrato.ValueSQL)
            q.AddField("lipidio", Me.txtLipidio.ValueSQL)
            q.AddField("calcio", Me.txtCalcio.ValueSQL)
            q.AddField("ferro", Me.txtFerro.ValueSQL)
            q.AddField("VitC", Me.txtVitC.ValueSQL)

            Dim res As MvtConnection.Query.QueryCommandResult = q.Save(conexaoPadrao)

            transaction.CommitTransaction()

            MsgBox("Seus dados foram salvos.", MsgBoxStyle.Exclamation, "MOV.TECH")


        Catch ex As Exception

            MsgBox("Ocorreu um erro ao salvar." & ex.Message & "!", MsgBoxStyle.Exclamation, "MOV.TECH")

            transaction.RollbackTransaction()

        End Try

        btnConsultar.HideWait(True)

    End Sub
End Class